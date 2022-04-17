using HumansGuideApi.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HumansGuideApi.Models
{
    public class PhoneNumber
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public PhoneNumberType Type { get; set; }
        public string Number { get; set; }
        [JsonIgnore]
        public int HumanId { get; set; }
        public Human Human { get; set; }
    }
}
