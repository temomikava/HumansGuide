﻿using HumansGuideApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace HumansGuideApi.Models
{
    public class ConnectedHuman
    {
        [Key]
        public int Id { get; set; }
        public int HumanId { get; set; }
        public Human Human { get; set; }
        public HumanConnectionType ConnectionType { get; set; }
    }
}