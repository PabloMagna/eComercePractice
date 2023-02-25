using eComerce.Data.Enums;
using eComerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eComerce.Data
{
    public class AppDbInitilalizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(
                        new Actor { FullName = "Tom Hanks", Bio = "Tom Hanks es un actor estadounidense conocido por sus papeles en películas como Forrest Gump, Náufrago y El Código Da Vinci.", ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Tom_Hanks-2745_%28cropped%29.jpg/220px-Tom_Hanks-2745_%28cropped%29.jpg" },
                        new Actor { FullName = "Tom Cruise", Bio = "Tom Cruise es un actor estadounidense famoso por su trabajo en películas como Top Gun, Misión Imposible y Entrevista con el Vampiro.", ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/Tom_Cruise_by_Gage_Skidmore.jpg/220px-Tom_Cruise_by_Gage_Skidmore.jpg" },
                        new Actor { FullName = "Tom Hardy", Bio = "Tom Hardy es un actor británico conocido por su trabajo en películas como Origen, El Caballero de la Noche Asciende y Mad Max: Furia en el Camino.", ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Tom_Hardy_by_Gage_Skidmore_2.jpg/220px-Tom_Hardy_by_Gage_Skidmore_2.jpg" },
                        new Actor { FullName = "Tom Holland", Bio = "Tom Holland es un actor británico conocido por interpretar a Spider-Man en el Universo Cinematográfico de Marvel.", ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/Tom_Holland_by_Gage_Skidmore.jpg/220px-Tom_Holland_by_Gage_Skidmore.jpg" },
                        new Actor { FullName = "Christian Bale", Bio = "Christian Bale es un actor británico conocido por su trabajo en películas como El Maquinista, Batman Begins y El Gran Truco.", ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Christian_Bale_2019.jpg/220px-Christian_Bale_2019.jpg" }
                    );
                    context.SaveChanges();
                }
                if (!context.Producers.Any())
                {

                    context.Producers.AddRange(
                        new Producer { FullName = "Kathleen Kennedy", Bio = "Kathleen Kennedy es una productora de cine estadounidense conocida por su trabajo en películas como la saga de Star Wars, Indiana Jones y Jurassic Park.", ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/Kathleen_Kennedy_by_Gage_Skidmore_3.jpg/220px-Kathleen_Kennedy_by_Gage_Skidmore_3.jpg" },
                        new Producer { FullName = "Scott Rudin", Bio = "Scott Rudin es un productor de cine estadounidense conocido por su trabajo en películas como La Red Social, No es País para Viejos y Lady Bird.", ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Scott_Rudin_TIFF_2010.jpg/220px-Scott_Rudin_TIFF_2010.jpg" },
                        new Producer { FullName = "Jerry Bruckheimer", Bio = "Jerry Bruckheimer es un productor de cine estadounidense conocido por su trabajo en películas como Top Gun, Piratas del Caribe y Armageddon.", ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Jerry_Bruckheimer_2014.jpg/220px-Jerry_Bruckheimer_2014.jpg" },
                        new Producer { FullName = "Kevin Feige", Bio = "Kevin Feige es un productor de cine estadounidense conocido por su trabajo en el Universo Cinematográfico de Marvel, produciendo películas como Iron Man, Los Vengadores y Black Panther.", ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Kevin_Feige_by_Gage_Skidmore_3.jpg/220px-Kevin_Feige_by_Gage_Skidmore_3.jpg" },
                        new Producer { FullName = "Emma Thomas", Bio = "Emma Thomas es una productora de cine británica conocida por su trabajo en películas como la trilogía de El Caballero de la Noche, Interestelar y Dunkerque.", ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/Emma_Thomas_2012_%28cropped%29.jpg/220px-Emma_Thomas_2012_%28cropped%29.jpg" }
                    );
                    context.SaveChanges();
                }
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(
                        new Cinema
                        {
                            Name = "Cineplex",
                            ProfilePicture = "https://example.com/cineplex.jpg",
                            Description = "Cineplex is a modern cinema chain with a focus on blockbuster movies.",
                        },
                        new Cinema
                        {
                            Name = "The Royal",
                            ProfilePicture = "https://example.com/royal.jpg",
                            Description = "The Royal is a historic cinema that showcases independent and art-house films.",
                        },
                        new Cinema
                        {
                            Name = "Cinemark",
                            ProfilePicture = "https://example.com/cinemark.jpg",
                            Description = "Cinemark is a popular cinema chain that shows a mix of mainstream and independent movies.",
                        },
                        new Cinema
                        {
                            Name = "The Bijou",
                            ProfilePicture = "https://example.com/bijou.jpg",
                            Description = "The Bijou is a cozy cinema that specializes in classic and foreign films.",
                        },
                        new Cinema
                        {
                            Name = "AMC",
                            ProfilePicture = "https://example.com/amc.jpg",
                            Description = "AMC is a large cinema chain that shows a wide variety of movies, from blockbusters to indie films.",
                        }
                    );
                    context.SaveChanges();
                }

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(
                        new Movie
                        {
                            Name = "The Shawshank Redemption",
                            Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            Price = 7.99,
                            ImageUrl = "https://m.media-amazon.com/images/I/51F+PNbuvTL._AC_.jpg",
                            StarDate = new DateTime(1994, 9, 23),
                            EndDate = new DateTime(1994, 12, 1),
                            MovieCategory = MovieCategory.Drama,
                            IdCinema = 1,
                            IdProducer = 3
                        },
                        new Movie
                        {
                            Name = "The Godfather",
                            Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                            Price = 9.99,
                            ImageUrl = "https://m.media-amazon.com/images/I/51lV7Qf4l4L._AC_.jpg",
                            StarDate = new DateTime(1972, 3, 24),
                            EndDate = new DateTime(1972, 7, 19),
                            MovieCategory = MovieCategory.Crime,
                            IdCinema = 2,
                            IdProducer = 4
                        },
                        new Movie
                        {
                            Name = "The Matrix",
                            Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                            Price = 6.99,
                            ImageUrl = "https://m.media-amazon.com/images/I/51EG732BV3L._AC_.jpg",
                            StarDate = new DateTime(1999, 3, 31),
                            EndDate = new DateTime(1999, 8, 26),
                            MovieCategory = MovieCategory.Action,
                            IdCinema = 3,
                            IdProducer = 5
                        },
                        new Movie
                        {
                            Name = "The Silence of the Lambs",
                            Description = "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.",
                            Price = 8.99,
                            ImageUrl = "https://m.media-amazon.com/images/I/41z5bsyv5TL._AC_.jpg",
                            StarDate = new DateTime(1991, 2, 14),
                            EndDate = new DateTime(1991, 7, 11),
                            MovieCategory = MovieCategory.Thriller,
                            IdCinema = 4,
                            IdProducer = 1
                        },
                        new Movie
                        {
                            Name = "The Lord of the Rings: The Return of the King",
                            Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                            Price = 10.99,
                            ImageUrl = "https://m.media-amazon.com/images/I/51y+nvFyv-L._AC_.jpg",
                            StarDate = new DateTime(2003, 12, 17),
                            EndDate = new DateTime(2004, 6, 10),
                            MovieCategory = MovieCategory.Fantasy,
                            IdCinema = 1,
                            IdProducer = 2
                        });
                    context.SaveChanges();
                }
                if (!context.Actors_Movies.Any())
                {

                    context.Actors_Movies.AddRange(
                        new Actor_Movie { ActorId = 1, MovieId = 1 },
                        new Actor_Movie { ActorId = 2, MovieId = 3 },
                        new Actor_Movie { ActorId = 3, MovieId = 5 },
                        new Actor_Movie { ActorId = 4, MovieId = 4 },
                        new Actor_Movie { ActorId = 5, MovieId = 2 });
                }
            }
        }
    }
}
