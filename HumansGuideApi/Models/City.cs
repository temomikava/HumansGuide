using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HumansGuideApi.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Human> Humans { get; set; }
    }
}
