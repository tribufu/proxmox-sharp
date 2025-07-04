// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace ProxmoxSharp.Models
{
    public class ProxmoxKsmInfo
    {
        [JsonProperty("shared")]
        public long Shared { get; set; }
    }
}
