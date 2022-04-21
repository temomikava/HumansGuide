using HumansGuideApi.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HumansGuideApi.Models
{
    public class ConnectedHuman
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public int HumanId { get; set; }
        public Human Human { get; set; }
        public int BaseConnectedHumanId { get; set; }
        public HumanConnectionType ConnectionType { get; set; }
    }
}

