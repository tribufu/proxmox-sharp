// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using dotenv.net;

namespace ProxmoxSharp.Tests
{
    public static class Program
    {
        public static async Task Main()
        {
            DotEnv.Load(new DotEnvOptions(ignoreExceptions: true, envFilePaths: [".env", "../../.env"]));

            var proxmox = ProxmoxApi.FromEnv()!;
            var nodes = (await proxmox.GetNodesAsync()).Data;
            Console.WriteLine($"nodes:");
            foreach (var node in nodes)
            {
                Console.WriteLine($"- {node.Node}");
            }

            var vms = (await proxmox.GetVMsAsync(nodes[0].Node)).Data;
            Console.WriteLine($"vms:");
            foreach (var vm in vms)
            {
                Console.WriteLine($"- {vm.Name}");
            }
        }
    }
}
