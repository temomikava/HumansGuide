﻿using HumansGuideApi.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HumansGuideApi.Models
{
    public class Human:BaseModel
    {       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string PersonalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Image { get; set; }
        public City City { get; set; }
        public ICollection<PhoneNumber> Phones { get; set; }
        public List<ConnectedHuman> ConnecteHumans { get; set; }
    }
}
