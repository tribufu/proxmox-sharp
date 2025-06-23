// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using dotenv.net;

namespace Tribufu.Proxmox.Tests
{
    public static class Program
    {
        public static async Task Main()
        {
            DotEnv.Load(new DotEnvOptions(ignoreExceptions: true, envFilePaths: [".env", "../../.env"]));

            var clusterUrl = Environment.GetEnvironmentVariable("PROXMOX_CLUSTER_URL");
            var tokenId = Environment.GetEnvironmentVariable("PROXMOX_TOKEN_ID");
            var tokenSecret = Environment.GetEnvironmentVariable("PROXMOX_TOKEN_SECRET");

            var proxmox = new ProxmoxClient(clusterUrl, tokenId, tokenSecret);

            var nodes = await proxmox.ListVirtualMachinesAsync("broadwell");
            foreach (var node in nodes)
            {
                Console.WriteLine($"- {node.Name}");
            }
        }
    }
}
