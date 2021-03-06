﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Okta.Core.Models
{
    /// <summary>
    /// The context of an authorization flow.
    /// </summary>
    /// <remarks>
    /// This should be representative of the <see cref="User"/> attempting to authenticate.
    /// </remarks>
    public class AuthContext : ApiObject
    {
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        [JsonProperty("deviceToken")]
        public string DeviceToken { get; set; }
    }
}
