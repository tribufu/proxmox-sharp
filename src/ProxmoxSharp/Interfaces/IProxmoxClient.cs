// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using ProxmoxSharp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProxmoxSharp.Interfaces
{
    public interface IProxmoxClient
    {
        Task<bool> LoginAsync(string username, string password);

        Task<List<ProxmoxNode>> ListNodesAsync();

        Task<ProxmoxNodeStatus> GetNodeStatusAsync(string node);

        Task<List<ProxmoxVirtualMachine>> ListVirtualMachinesAsync(string node);

        Task<ProxmoxVirtualMachineStatus> GetVirtualMachineStatusAsync(string node, int vmid);

        Task<bool> CreateVirtualMachineAsync(string node, int vmid, string name, int memoryMb, int cores, string storage, string iso, string netConfig = "virtio,bridge=vmbr0");

        Task<bool> StartVirtualMachineAsync(string node, int vmid);

        Task<bool> RebootVirtualMachineAsync(string node, int vmid);

        Task<bool> ResetVirtualMachineAsync(string node, int vmid);

        Task<bool> SuspendVirtualMachineAsync(string node, int vmid);

        Task<bool> ResumeVirtualMachineAsync(string node, int vmid);

        Task<bool> ShutdownVirtualMachineAsync(string node, int vmid);

        Task<bool> StopVirtualMachineAsync(string node, int vmid);

        Task<List<ProxmoxContainer>> ListContainersAsync(string node);
    }
}
