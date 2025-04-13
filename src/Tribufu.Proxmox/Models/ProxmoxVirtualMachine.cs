// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace Tribufu.Proxmox.Models
{
    public class ProxmoxVirtualMachine
    {
        [JsonProperty("vmid")]
        public int VmId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("uptime")]
        public long Uptime { get; set; }

        [JsonProperty("cpu")]
        public double Cpu { get; set; }

        [JsonProperty("cpus")]
        public int CpuCount { get; set; }

        [JsonProperty("mem")]
        public long MemoryUsed { get; set; }

        [JsonProperty("maxmem")]
        public long MemoryTotal { get; set; }

        [JsonProperty("disk")]
        public long DiskUsed { get; set; }

        [JsonProperty("maxdisk")]
        public long DiskTotal { get; set; }

        [JsonProperty("diskread")]
        public long DiskRead { get; set; }

        [JsonProperty("diskwrite")]
        public long DiskWrite { get; set; }

        [JsonProperty("netin")]
        public long NetworkIn { get; set; }

        [JsonProperty("netout")]
        public long NetworkOut { get; set; }

        [JsonProperty("pid")]
        public int Pid { get; set; }
    }
}
