using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace eComerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePicture { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public List<Actor_Movie> Actor_movie { get; set; }
    }
}
