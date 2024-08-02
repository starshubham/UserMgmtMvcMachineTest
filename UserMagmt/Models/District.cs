using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UserMagmt.Models
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DistrictName { get; set; }
        [Required]
        [ForeignKey("State")]
        public int StateId { get; set;}

        [JsonIgnore]
        public State State { get; set; }
    }
}
