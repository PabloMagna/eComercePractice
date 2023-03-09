using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace eComerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required]
        [MaxLength(200)]
        public string ProfilePicture { get; set; }

        [Display(Name = "Full Name")]
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required]
        [MaxLength(50)]
        public string Bio { get; set; }
        public List<Actor_Movie>? Actor_movies { get; set; }

    }

}
