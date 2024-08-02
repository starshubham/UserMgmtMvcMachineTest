using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UserMagmt.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a user name")]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please select a state")]
        [DisplayName("State")]
        [ForeignKey("State")]
        public int StateId { get; set; }

        [Required(ErrorMessage = "Please select a district")]
        [ForeignKey("District")]
        [DisplayName("District")]
        public int DistrictId { get; set; }

        [JsonIgnore]
        public State State { get; set; }

        [JsonIgnore]
        public District District { get; set; }
    }
}
