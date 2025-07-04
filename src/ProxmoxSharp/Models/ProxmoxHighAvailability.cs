// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace ProxmoxSharp.Models
{
    public class ProxmoxHighAvailability
    {
        [JsonProperty("managed")]
        public int Managed { get; set; }
    }
}
