// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace Tribufu.Proxmox.Models
{
    public class ProxmoxNicStats
    {
        [JsonProperty("netin")]
        public long NetIn { get; set; }

        [JsonProperty("netout")]
        public long NetOut { get; set; }
    }
}
