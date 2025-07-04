// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProxmoxSharp.Models
{
    public class ProxmoxBlockStats
    {
        [JsonProperty("rd_operations")]
        public long RdOperations { get; set; }

        [JsonProperty("wr_total_time_ns")]
        public long WrTotalTimeNs { get; set; }

        [JsonProperty("wr_highest_offset")]
        public long WrHighestOffset { get; set; }

        [JsonProperty("flush_operations")]
        public long FlushOperations { get; set; }

        [JsonProperty("failed_zone_append_operations")]
        public long FailedZoneAppendOperations { get; set; }

        [JsonProperty("invalid_wr_operations")]
        public long InvalidWrOperations { get; set; }

        [JsonProperty("invalid_rd_operations")]
        public long InvalidRdOperations { get; set; }

        [JsonProperty("rd_bytes")]
        public long RdBytes { get; set; }

        [JsonProperty("invalid_zone_append_operations")]
        public long InvalidZoneAppendOperations { get; set; }

        [JsonProperty("account_invalid")]
        public bool AccountInvalid { get; set; }

        [JsonProperty("failed_rd_operations")]
        public long FailedRdOperations { get; set; }

        [JsonProperty("timed_stats")]
        public List<object> TimedStats { get; set; }

        [JsonProperty("zone_append_operations")]
        public long ZoneAppendOperations { get; set; }

        [JsonProperty("failed_flush_operations")]
        public long FailedFlushOperations { get; set; }

        [JsonProperty("zone_append_merged")]
        public long ZoneAppendMerged { get; set; }

        [JsonProperty("flush_total_time_ns")]
        public long FlushTotalTimeNs { get; set; }

        [JsonProperty("invalid_unmap_operations")]
        public long InvalidUnmapOperations { get; set; }

        [JsonProperty("invalid_flush_operations")]
        public long InvalidFlushOperations { get; set; }

        [JsonProperty("rd_merged")]
        public long RdMerged { get; set; }

        [JsonProperty("unmap_bytes")]
        public long UnmapBytes { get; set; }

        [JsonProperty("unmap_operations")]
        public long UnmapOperations { get; set; }

        [JsonProperty("zone_append_bytes")]
        public long ZoneAppendBytes { get; set; }

        [JsonProperty("wr_operations")]
        public long WrOperations { get; set; }

        [JsonProperty("rd_total_time_ns")]
        public long RdTotalTimeNs { get; set; }

        [JsonProperty("wr_bytes")]
        public long WrBytes { get; set; }

        [JsonProperty("zone_append_total_time_ns")]
        public long ZoneAppendTotalTimeNs { get; set; }

        [JsonProperty("account_failed")]
        public bool AccountFailed { get; set; }

        [JsonProperty("failed_unmap_operations")]
        public long FailedUnmapOperations { get; set; }

        [JsonProperty("unmap_merged")]
        public long UnmapMerged { get; set; }

        [JsonProperty("unmap_total_time_ns")]
        public long UnmapTotalTimeNs { get; set; }

        [JsonProperty("wr_merged")]
        public long WrMerged { get; set; }

        [JsonProperty("idle_time_ns")]
        public long? IdleTimeNs { get; set; }
    }
}
