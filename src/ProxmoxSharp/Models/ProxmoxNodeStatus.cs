// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace ProxmoxSharp.Models
{
    public class ProxmoxNodeStatus
    {
        [JsonProperty("boot-info")]
        public ProxmoxBootInfo BootInfo { get; set; }

        [JsonProperty("swap")]
        public ProxmoxMemoryStats Swap { get; set; }

        [JsonProperty("rootfs")]
        public ProxmoxStorageStats RootFs { get; set; }

        [JsonProperty("pveversion")]
        public string PveVersion { get; set; }

        [JsonProperty("cpuinfo")]
        public ProxmoxCpuInfo CpuInfo { get; set; }

        [JsonProperty("memory")]
        public ProxmoxMemoryStats Memory { get; set; }

        [JsonProperty("ksm")]
        public ProxmoxKsmInfo Ksm { get; set; }

        [JsonProperty("idle")]
        public double Idle { get; set; }

        [JsonProperty("cpu")]
        public double Cpu { get; set; }

        [JsonProperty("loadavg")]
        public string[] LoadAverage { get; set; }

        [JsonProperty("current-kernel")]
        public ProxmoxKernelInfo CurrentKernel { get; set; }

        [JsonProperty("kversion")]
        public string KernelVersion { get; set; }

        [JsonProperty("wait")]
        public double Wait { get; set; }

        [JsonProperty("uptime")]
        public long Uptime { get; set; }
    }
}
