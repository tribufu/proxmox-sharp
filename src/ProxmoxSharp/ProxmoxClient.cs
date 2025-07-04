// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json.Linq;
using ProxmoxSharp.Interfaces;
using ProxmoxSharp.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProxmoxSharp
{
    public class ProxmoxClient : IProxmoxClient
    {
        private readonly RestClient _client;

        private string _ticket;

        private string _csrfToken;

        public ProxmoxClient(string baseUrl, string tokenId, string secret)
        {
            var options = new RestClientOptions(baseUrl.TrimEnd('/') + "/api2/json/")
            {
                RemoteCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            _client = new RestClient(options);

            if (!string.IsNullOrEmpty(tokenId) && !string.IsNullOrEmpty(secret))
            {
                _client.AddDefaultHeader("Authorization", $"PVEAPIToken={tokenId}={secret}");
            }
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var request = new RestRequest("access/ticket", Method.Post);
            request.AddParameter("username", username);
            request.AddParameter("password", password);

            var response = await _client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                var json = JObject.Parse(response.Content);
                var data = json["data"];
                _ticket = data["ticket"].ToString();
                _csrfToken = data["CSRFPreventionToken"].ToString();

                _client.AddDefaultHeader("Cookie", $"PVEAuthCookie={_ticket}");
                _client.AddDefaultHeader("CSRFPreventionToken", _csrfToken);
            }

            return response.IsSuccessful;
        }

        public async Task<List<ProxmoxNode>> ListNodesAsync()
        {
            var request = new RestRequest($"nodes", Method.Get);

            var response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful)
            {
                throw new Exception($"Failed to list nodes: {response.StatusCode}");
            }

            var json = JObject.Parse(response.Content);
            return json["data"].ToObject<List<ProxmoxNode>>();
        }

        public async Task<ProxmoxNodeStatus> GetNodeStatusAsync(string node)
        {
            var request = new RestRequest($"nodes/{node}/status", Method.Get);

            var response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful)
            {
                throw new Exception($"Failed to get node {node}: {response.StatusCode}");
            }

            var json = JObject.Parse(response.Content);
            return json["data"].ToObject<ProxmoxNodeStatus>();
        }

        public async Task<bool> CreateVirtualMachineAsync(string node, int vmid, string name, int memoryMb, int cores, string storage, string iso, string netConfig = "virtio,bridge=vmbr0")
        {
            var request = new RestRequest($"nodes/{node}/qemu", Method.Post);
            request.AddParameter("vmid", vmid);
            request.AddParameter("name", name);
            request.AddParameter("memory", memoryMb);
            request.AddParameter("cores", cores);
            request.AddParameter("ide2", iso + ",media=cdrom");
            request.AddParameter("scsihw", "virtio-scsi-pci");
            request.AddParameter("scsi0", $"{storage}:32");
            request.AddParameter("net0", netConfig);

            var response = await _client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<List<ProxmoxVirtualMachine>> ListVirtualMachinesAsync(string node)
        {
            var request = new RestRequest($"nodes/{node}/qemu", Method.Get);

            var response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful)
            {
                throw new Exception($"Failed to list VMs: {response.StatusCode}");
            }

            var json = JObject.Parse(response.Content);
            return json["data"].ToObject<List<ProxmoxVirtualMachine>>();
        }

        public async Task<ProxmoxVirtualMachineStatus> GetVirtualMachineStatusAsync(string node, int vmid)
        {
            var request = new RestRequest($"nodes/{node}/qemu/{vmid}/status/current", Method.Get);

            var response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful)
            {
                throw new Exception($"Failed to start VM {vmid}: {response.StatusCode}");
            }

            var json = JObject.Parse(response.Content);
            return json["data"].ToObject<ProxmoxVirtualMachineStatus>();
        }

        public async Task<bool> StartVirtualMachineAsync(string node, int vmid)
        {
            var request = new RestRequest($"nodes/{node}/qemu/{vmid}/status/start", Method.Post);
            var response = await _client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> RebootVirtualMachineAsync(string node, int vmid)
        {
            var request = new RestRequest($"nodes/{node}/qemu/{vmid}/status/reboot", Method.Post);
            var response = await _client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> ResetVirtualMachineAsync(string node, int vmid)
        {
            var request = new RestRequest($"nodes/{node}/qemu/{vmid}/status/reset", Method.Post);
            var response = await _client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> SuspendVirtualMachineAsync(string node, int vmid)
        {
            var request = new RestRequest($"nodes/{node}/qemu/{vmid}/status/suspend", Method.Post);
            var response = await _client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> ResumeVirtualMachineAsync(string node, int vmid)
        {
            var request = new RestRequest($"nodes/{node}/qemu/{vmid}/status/resume", Method.Post);
            var response = await _client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> ShutdownVirtualMachineAsync(string node, int vmid)
        {
            var request = new RestRequest($"nodes/{node}/qemu/{vmid}/status/shutdown", Method.Post);
            var response = await _client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> StopVirtualMachineAsync(string node, int vmid)
        {
            var request = new RestRequest($"nodes/{node}/qemu/{vmid}/status/stop", Method.Post);
            var response = await _client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<List<ProxmoxContainer>> ListContainersAsync(string node)
        {
            var request = new RestRequest($"nodes/{node}/lxc", Method.Get);

            var response = await _client.ExecuteAsync(request);
            if (!response.IsSuccessful)
            {
                throw new Exception($"Failed to list LXC containers: {response.StatusCode}");
            }

            var json = JObject.Parse(response.Content);
            return json["data"].ToObject<List<ProxmoxContainer>>();
        }
    }
}
