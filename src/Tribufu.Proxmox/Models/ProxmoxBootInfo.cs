// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace Tribufu.Proxmox.Models
{
    public class ProxmoxBootInfo
    {
        [JsonProperty("secureboot")]
        public int SecureBoot { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }
    }
}
