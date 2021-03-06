using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Okta.Core.Models
{
    /// <summary>
    /// A user's profile.
    /// </summary>
    /// <remarks>
    /// This includes all of a user's attributes regardless of source.
    /// </remarks>
    public class UserProfile : ApiObject
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }
    }
}