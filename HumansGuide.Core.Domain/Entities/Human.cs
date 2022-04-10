using HumansGuide.Core.Domain.Basics;
using HumansGuide.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansGuide.Core.Domain.Entities
{
    public class Human:AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string PersonalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Image { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public List<PhoneNumber> Phones { get; set; }
        public List<ConnectedHuman> ConnecteHumans { get; set; }
    }
}
