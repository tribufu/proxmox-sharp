// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace Tribufu.Proxmox.Models
{
    public class ProxmoxCpuInfo
    {
        [JsonProperty("cores")]
        public int Cores { get; set; }

        [JsonProperty("mhz")]
        public string MHz { get; set; }

        [JsonProperty("cpus")]
        public int Cpus { get; set; }

        [JsonProperty("sockets")]
        public int Sockets { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("flags")]
        public string Flags { get; set; }

        [JsonProperty("user_hz")]
        public int UserHz { get; set; }

        [JsonProperty("hvm")]
        public string Hvm { get; set; }
    }
}
