﻿using HumansGuideApi.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HumansGuideApi.Models
{
    public  class Human
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string PersonalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Image { get; set; }
        public int CityId { get; set; }
        [JsonIgnore]
        public City City { get; set; }
        public List<PhoneNumber> Phones { get; set; }
        public List<ConnectedHuman>ConnectedHumans { get; set; }
    }
}
