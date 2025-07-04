// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Newtonsoft.Json;

namespace ProxmoxSharp.Models
{
    public class ProxmoxSupportInfo
    {
        [JsonProperty("backup-max-workers")]
        public bool BackupMaxWorkers { get; set; }

        [JsonProperty("pbs-library-version")]
        public string PbsLibraryVersion { get; set; }

        [JsonProperty("pbs-masterkey")]
        public bool PbsMasterkey { get; set; }

        [JsonProperty("backup-fleecing")]
        public bool BackupFleecing { get; set; }

        [JsonProperty("query-bitmap-info")]
        public bool QueryBitmapInfo { get; set; }

        [JsonProperty("pbs-dirty-bitmap")]
        public bool PbsDirtyBitmap { get; set; }

        [JsonProperty("pbs-dirty-bitmap-savevm")]
        public bool PbsDirtyBitmapSaveVm { get; set; }

        [JsonProperty("pbs-dirty-bitmap-migration")]
        public bool PbsDirtyBitmapMigration { get; set; }
    }
}
