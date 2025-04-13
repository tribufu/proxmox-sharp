// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace Tribufu.Proxmox.Models
{
    public class ProxmoxMemoryStats
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("used")]
        public long Used { get; set; }

        [JsonProperty("free")]
        public long Free { get; set; }
    }
}
