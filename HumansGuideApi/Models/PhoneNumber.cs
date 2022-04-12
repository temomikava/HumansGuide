using HumansGuideApi.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace HumansGuideApi.Models
{
    public class PhoneNumber
    {
        [Key]
        public int Id { get; set; }
        public PhoneNumberType Type { get; set; }
        public string Number { get; set; }
        public int HumanId { get; set; }
        public Human Human { get; set; }
    }
}
