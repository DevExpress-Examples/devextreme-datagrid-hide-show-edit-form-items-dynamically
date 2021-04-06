using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_NET_Core.Models {
    public class Employee {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ID")]
        public int ID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "FirstName")]
        public string FirstName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "LastName")]
        public string LastName { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Title")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Prefix")]
        public string Prefix { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Position")]
        public string Position { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "BirthDate")]
        public DateTime? BirthDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "HireDate")]
        public DateTime? HireDate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Notes")]
        public string Notes { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Email")]
        public string Email { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Address")]
        public string Address { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "StateID")]
        public int? StateID { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "State")]
        public string State { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "AddressRequired")]
        public bool AddressRequired { get; set; }
    }
}
