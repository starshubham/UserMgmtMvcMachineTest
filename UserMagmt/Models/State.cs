using System.ComponentModel.DataAnnotations;

namespace UserMagmt.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StateName { get; set; }
    }
}
