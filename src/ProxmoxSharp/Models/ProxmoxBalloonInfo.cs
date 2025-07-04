// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace ProxmoxSharp.Models
{
    public class ProxmoxBalloonInfo
    {
        [JsonProperty("major_page_faults")]
        public long MajorPageFaults { get; set; }

        [JsonProperty("total_mem")]
        public long TotalMem { get; set; }

        [JsonProperty("mem_swapped_out")]
        public long MemSwappedOut { get; set; }

        [JsonProperty("minor_page_faults")]
        public long MinorPageFaults { get; set; }

        [JsonProperty("mem_swapped_in")]
        public long MemSwappedIn { get; set; }

        [JsonProperty("max_mem")]
        public long MaxMem { get; set; }

        [JsonProperty("last_update")]
        public long LastUpdate { get; set; }

        [JsonProperty("actual")]
        public long Actual { get; set; }

        [JsonProperty("free_mem")]
        public long FreeMem { get; set; }
    }
}
