using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment12._2._2.Models
{
    public class Country
    {
        [Key]
        [Required]
        public int CountryId { get; set; }
        [Required]
        public string CountryName { get; set; }
        [Required]
        public virtual ICollection<Draw> Draws { get; set; }
    }
}
