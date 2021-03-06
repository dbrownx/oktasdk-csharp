﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Okta.Core.Models
{
    /// <summary>
    /// Read only objects that are related to another <see cref="ApiObject"/>.
    /// </summary>
    /// <remarks>
    /// These are typically used to save a roundtrip HTTP call
    /// </remarks>
    public class Embedded : ApiObject
    {
        public Embedded()
        {
            Factors = new List<Factor>();
        }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        [JsonProperty("user")]
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the factors.
        /// </summary>
        /// <value>
        /// The factors.
        /// </value>
        [JsonProperty("factors")]
        public List<Factor> Factors { get; set; }

        /// <summary>
        /// Gets or sets the factor.
        /// </summary>
        /// <value>
        /// The factor.
        /// </value>
        [JsonProperty("factor")]
        public Factor Factor { get; set; }
    }
}
