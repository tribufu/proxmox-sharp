// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tribufu.Proxmox.Models
{
    public class ProxmoxVirtualMachineStatus
    {
        [JsonProperty("vmid")]
        public int VmId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nics")]
        public Dictionary<string, ProxmoxNicStats> Nics { get; set; }

        [JsonProperty("blockstat")]
        public Dictionary<string, ProxmoxBlockStats> BlockStat { get; set; }

        [JsonProperty("maxdisk")]
        public long MaxDisk { get; set; }

        [JsonProperty("cpu")]
        public double Cpu { get; set; }

        [JsonProperty("mem")]
        public long Mem { get; set; }

        [JsonProperty("netin")]
        public long NetIn { get; set; }

        [JsonProperty("pid")]
        public int Pid { get; set; }

        [JsonProperty("qmpstatus")]
        public string QmpStatus { get; set; }

        [JsonProperty("uptime")]
        public long Uptime { get; set; }

        [JsonProperty("agent")]
        public int Agent { get; set; }

        [JsonProperty("running-qemu")]
        public string RunningQemu { get; set; }

        [JsonProperty("proxmox-support")]
        public ProxmoxSupportInfo ProxmoxSupport { get; set; }

        [JsonProperty("maxmem")]
        public long MaxMem { get; set; }

        [JsonProperty("disk")]
        public double Disk { get; set; }

        [JsonProperty("ballooninfo")]
        public ProxmoxBalloonInfo BalloonInfo { get; set; }

        [JsonProperty("netout")]
        public long NetOut { get; set; }

        [JsonProperty("freemem")]
        public long FreeMem { get; set; }

        [JsonProperty("diskread")]
        public long DiskRead { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("diskwrite")]
        public long DiskWrite { get; set; }

        [JsonProperty("running-machine")]
        public string RunningMachine { get; set; }

        [JsonProperty("balloon")]
        public long Balloon { get; set; }

        [JsonProperty("ha")]
        public ProxmoxHighAvailability Ha { get; set; }

        [JsonProperty("cpus")]
        public int Cpus { get; set; }
    }
}
