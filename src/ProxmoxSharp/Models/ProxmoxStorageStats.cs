// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace ProxmoxSharp.Models
{
    public class ProxmoxStorageStats
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("avail")]
        public long Available { get; set; }

        [JsonProperty("used")]
        public long Used { get; set; }

        [JsonProperty("free")]
        public long Free { get; set; }
    }
}
