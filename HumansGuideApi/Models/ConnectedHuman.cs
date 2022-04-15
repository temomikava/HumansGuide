using HumansGuideApi.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HumansGuideApi.Models
{
    public class ConnectedHuman
    {
        [Key]
        public int Id { get; set; }
        public int HumanId { get; set; }
        [ForeignKey(nameof(HumanId))]
        public Human Human { get; set; }
        public int ConnectedHumanId { get; set; }
        [ForeignKey(nameof(ConnectedHumanId))]
        public Human ConnetedHuman { get; set; }
        
        public HumanConnectionType ConnectionType { get; set; }
    }
}

