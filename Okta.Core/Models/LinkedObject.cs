﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Okta.Core.Models
{
    /// <summary>
    /// An entity that has HAL links
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class LinkedObject : ApiObject
    {
        internal LinkedObject()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        /// <summary>
        /// Gets the self URI.
        /// </summary>
        /// <value>
        /// The self URI.
        /// </value>
        public Uri SelfUri { get { return Links.ContainsKey("self") ? ((List<Link>)Links["self"]).First().Href : null; } }

        /// <summary>
        /// Gets or sets the HAL links of an object.
        /// </summary>
        /// <value>
        /// The HAL links.
        /// </value>
        [JsonProperty("_links")]
        public Dictionary<string, List<Link>> Links { get; set; }
    }
}
