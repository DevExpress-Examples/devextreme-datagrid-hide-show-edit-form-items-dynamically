using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ASP_NET_Core.Models {
    public class Employee {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("ID")]
        public int ID { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("FirstName")]
        public string FirstName { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("LastName")]
        public string LastName { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("Phone")]
        public string Phone { get; set; }

        [Display(Name = "Title")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("Prefix")]
        public string Prefix { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("Position")]
        public string Position { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("BirthDate")]
        public DateTime? BirthDate { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("HireDate")]
        public DateTime? HireDate { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("Notes")]
        public string Notes { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("Email")]
        public string Email { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("Address")]
        public string Address { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("City")]
        public string City { get; set; }

        [Display(Name = "State")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("StateID")]
        public int? StateID { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("State")]
        public string State { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyName("AddressRequired")]
        public bool AddressRequired { get; set; }
    }
}
