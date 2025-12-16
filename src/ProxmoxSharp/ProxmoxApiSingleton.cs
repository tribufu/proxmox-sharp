// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

namespace ProxmoxSharp
{
    /// <summary>
    /// Tribufu API
    /// </summary>
    /// <remarks>
    /// Helper class to get a singleton instance of the <see cref="ProxmoxApi"/>.
    /// </remarks>
    public static class ProxmoxApiSingleton
    {
        private static ProxmoxApi _instance = null;

        /// <summary>
        /// Get the singleton instance of <see cref="ProxmoxApi"/>.
        /// </summary>
        public static ProxmoxApi GetInstance()
        {
            if (_instance == null)
            {
                _instance = ProxmoxApi.FromEnv();
            }

            return _instance;
        }

        /// <summary>
        /// Reset the singleton instance of <see cref="ProxmoxApi"/>.
        /// </summary>
        public static void ResetInstance()
        {
            _instance = null;
        }
    }
}
