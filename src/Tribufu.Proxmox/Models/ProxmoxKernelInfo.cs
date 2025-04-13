// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace Tribufu.Proxmox.Models
{
    public class ProxmoxKernelInfo
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("sysname")]
        public string SysName { get; set; }

        [JsonProperty("release")]
        public string Release { get; set; }

        [JsonProperty("machine")]
        public string Machine { get; set; }
    }
}
