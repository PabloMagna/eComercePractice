using eComerce.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eComerce.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public List<Actor_Movie> Actor_Movies { get; set; }
        public int IdCinema { get; set; }
        [ForeignKey("IdCinema")]
        public Cinema Cinema { get; set; }

        public int IdProducer { get; set; }
        [ForeignKey("IdProducer")]
        public Producer Producer { get; set; }

    }
}