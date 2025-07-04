// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace ProxmoxSharp.Models
{
    public class ProxmoxNode
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("node")]
        public string Name { get; set; }

        [JsonProperty("uptime")]
        public long Uptime { get; set; }

        [JsonProperty("ssl_fingerprint")]
        public string SslFingerprint { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cpu")]
        public double Cpu { get; set; }

        [JsonProperty("maxcpu")]
        public int MaxCpu { get; set; }

        [JsonProperty("disk")]
        public long Disk { get; set; }

        [JsonProperty("maxmem")]
        public long MaxMemory { get; set; }

        [JsonProperty("mem")]
        public long Memory { get; set; }

        [JsonProperty("maxdisk")]
        public long MaxDisk { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
