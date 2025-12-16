// Copyright (c) Tribufu. All Rights Reserved.
// SPDX-License-Identifier: MIT

using ProxmoxSharp.Api;
using ProxmoxSharp.Client;
using System;
using System.Net;
using System.Runtime.InteropServices;

namespace ProxmoxSharp
{
    /// <summary>
    /// Proxmox API
    /// </summary>
    /// <remarks>
    /// Use this class to interact with the Proxmox API.
    /// </remarks>
    public sealed class ProxmoxApi : ProxmoxGeneratedApi
    {
        /// <summary>
        /// Create a <see cref="ProxmoxApi"/> instance.
        /// </summary>
        public ProxmoxApi(string baseUrl, string tokenId, string tokenSecret) : base(CreateConfiguration(baseUrl, tokenId, tokenSecret))
        {
        }

        /// <summary>
        /// Try to create a <see cref="ProxmoxApi"/> from environment variables.
        /// </summary>
        /// <remarks>
        /// This will only work if the environment variables are set.
        /// </remarks>
        /// <returns><see cref="ProxmoxApi"/> instance or null if environment variables not set</returns>
        /// <example>
        /// // Environment variable PROXMOX_API_KEY must be set
        /// var api = ProxmoxApi.FromEnv();
        /// </example>
        public static ProxmoxApi FromEnv()
        {
            var baseUrl = Environment.GetEnvironmentVariable("PROXMOX_URL");
            var tokenId = Environment.GetEnvironmentVariable("PROXMOX_TOKEN_ID");
            var tokenSecret = Environment.GetEnvironmentVariable("PROXMOX_TOKEN_SECRET");

            if (!string.IsNullOrEmpty(baseUrl) && !string.IsNullOrEmpty(tokenId) && !string.IsNullOrEmpty(tokenSecret))
            {
                return new ProxmoxApi(baseUrl, tokenId, tokenSecret);
            }

            return null;
        }

        /// <summary>
        /// Gets the version of the Proxmox API client.
        /// </summary>
        public static string GetVersion()
        {
            var version = typeof(ProxmoxApi).Assembly.GetName().Version;
            return $"{version?.Major}.{version?.Minor}.{version?.Build}";
        }

        /// <summary>
        /// Gets the user agent string for the Proxmox API client.
        /// </summary>
        public static string GetUserAgent()
        {
            var version = GetVersion();
            var frameworkDescription = RuntimeInformation.FrameworkDescription.Trim();
            //var runtimeIdentifier = RuntimeInformation.RuntimeIdentifier.Trim();
            return $"ProxmoxSharp/{version} ({frameworkDescription})";
        }

        /// <summary>
        /// Checks if debug mode is enabled.
        /// </summary>
        /// <returns>True if debug mode is enabled, otherwise false</returns>
        public static bool DebugEnabled()
        {
#if DEBUG
            return true;
#else
            return  false;
#endif
        }

        /// <summary>
        /// Creates a configuration for the Proxmox API client.
        /// </summary>
        private static Configuration CreateConfiguration(string baseUrl, string tokenId, string tokenSecret)
        {
            var config = new Configuration
            {
                BasePath = baseUrl.TrimEnd('/') + "/api2/json/",
                UserAgent = WebUtility.UrlEncode(GetUserAgent()),
            };

            if (!string.IsNullOrEmpty(tokenId) && !string.IsNullOrEmpty(tokenSecret))
            {
                config.DefaultHeaders["Authorization"] = $"PVEAPIToken={tokenId}={tokenSecret}";
            }

            return config;
        }
    }
}
