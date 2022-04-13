using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment12._2._2.Models
{
    public enum CountryName
    {
        Italy,
        Holland,
        French
    }
    public class Draw
    {
        [Key]
        [Display(Name = "Draw ID")]
        [Required(ErrorMessage = "Please enter draw id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter author name")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter draw name"), Display(Name = "Draw Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter draw price")]
        public double Price { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter image url address")]
        public string ImageUrl { get; set; }
        public CountryName Country { get; set; }
        public int CountryId { get; set; }
    }
}
