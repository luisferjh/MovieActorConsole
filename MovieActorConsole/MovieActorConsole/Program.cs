using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MovieActorConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new MovieDbContext())
            //{
            //    var movie1 = new Movie
            //    {
            //        Title = "Avengers Infinity war",
            //        Description = "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat",
            //        Genre = "Action, SuperHero, Comedy",
            //        ReleaseDate = new DateTime(2018, 5, 10),
            //        Rating = "PG-13",
            //        Price = 2
            //    };

            //    //pelicula 2
            //    var movie2 = new Movie
            //    {
            //        Title = "Ready Player One",
            //        Description = "When the creator of a virtual reality world called the OASIS dies, he releases a video",
            //        Genre = "Adventure, Scifi, Action",
            //        ReleaseDate = new DateTime(2018, 3, 19),
            //        Rating = "PG-13",
            //        Price = 3

            //    };

            //    context.AddRange(new Movie[] { movie1, movie2 });
            //    context.SaveChanges();
            //    Console.WriteLine("movies saved");
            //}

            //using (var context = new MovieDbContext())
            //{
            //    var actor1 = new Actor
            //    {
            //        FirtsName = "Robert",
            //        LastName = "Downey jr",
            //        Email = "Robert@jr.com"
            //    };

            //    var actor2 = new Actor
            //    {
            //        FirtsName = "Tye",
            //        LastName = "Sheridan",
            //        Email = "Tye@outlook.com"
            //    };

            //    var actor3 = new Actor
            //    {
            //        FirtsName = "Christ",
            //        LastName = "Hemsworth",
            //        Email = "Christ@gmail.com"
            //    };

            //    context.AddRange(new Actor[] { actor1, actor2, actor3 });
            //    context.SaveChanges();
            //    Console.WriteLine("Actors saved");
            //}


            //// Guardar un movieActor
            //using (var context = new MovieDbContext())
            //{
            //    var movie1 = context.Movies.First();
            //    var actor1 = context.Actors.First();

            //    var movieActor1 = new MovieActor();
            //    movieActor1.MovieId = movie1.MovieId;
            //    movieActor1.ActorId = actor1.ActorId;

            //    context.Add(movieActor1);
            //    context.SaveChanges();
            //    Console.WriteLine("Movieactor saved");
            //}

            //// Guardar otro movieActor
            //using (var context = new MovieDbContext())
            //{
            //    var movie1 = context.Movies.First();
            //    var actor3 = context.Actors.Last();

            //    var movieActor2 = new MovieActor();
            //    movieActor2.MovieId = movie1.MovieId;
            //    movieActor2.ActorId = actor3.ActorId;

            //    context.Add(movieActor2);
            //    context.SaveChanges();
            //    Console.WriteLine("Movieactor saved");                
            //}

            ////Guardar otro movieActor
            //using (var context =  new MovieDbContext())
            //{
            //consultar el segundo actor de la base de datos 1 forma
            //var movie2 = context.Movies.Last();
            //int id = 2;
            //var actor2 = context.Actors.Where(x => x.ActorId == id).ToList();
            //Console.WriteLine(actor2[0]);

            ////consultar el segundo actor de la base de datos 2 forma
            //var actors = context.Actors.Where(a => a.ActorId == id)
            //    .Select(p => new { p.FirtsName, p.LastName, p.Email });
            //foreach (var parameter in actors)
            //{
            //    Console.WriteLine("Name: {0}", parameter.FirtsName);
            //    Console.WriteLine("Last Name: {0}", parameter.LastName);
            //    Console.WriteLine("Email: ${0}", parameter.Email);
            //    Console.WriteLine("");
            //}

            //guardar otro movieActor
            //var movieActor3 = new MovieActor();
            //movieActor3.ActorId = actor2[0].ActorId;
            //movieActor3.MovieId = movie2.MovieId;

            //context.Add(movieActor3);
            //context.SaveChanges();
            //Console.WriteLine("Movieactor saved");
            //}


            //insertar datos tabla director y directorMovies
            //insertar datos director
            //using (var context = new MovieDbContext())
            //{
            //    var director1 = new Director
            //    {
            //        FirtsName = "Joe y anthony",
            //        LastName = "Russo",
            //        Email = "joeanthony@gmail.com"
            //    };

            //    var director2 = new Director
            //    {
            //        FirtsName = "Steven",
            //        LastName = "Spielberg",
            //        Email = "stevebg@outlook.com"
            //    };

            //    context.AddRange(new Director[] { director1, director2 });
            //    context.SaveChanges();
            //    Console.WriteLine("Directors saved");
            //}


            //insertar MovieDirector relacionados
            //using (var context = new MovieDbContext())
            //{
            //    var director = context.Directors.Single(d => d.DirectorId == 1);
            //    var movie = context.Movies.Single(m => m.MovieId == 1);

            //    var movieDirector1 = new MovieDirector();
            //    movieDirector1.DirectorId = director.DirectorId;
            //    movieDirector1.MovieId = movie.MovieId;

            //    context.Add(movieDirector1);
            //    context.SaveChanges();

            //    var director2 = context.Directors.Single(d => d.DirectorId == 2);
            //    var movie2 = context.Movies.Single(m => m.MovieId == 2);

            //    var movieDirector2 = new MovieDirector();
            //    movieDirector2.DirectorId = director2.DirectorId;
            //    movieDirector2.MovieId = movie2.MovieId;

            //    context.Add(movieDirector2);
            //    context.SaveChanges();
            //    Console.WriteLine("MovieDirector saved");

            //}


            ////consultas muchos a muchos
            //using (var context = new MovieDbContext())
            //{
               
                //traemos toda la data movieActor
                //var allMovieActor = context.MovieActors.ToList();

                //traemos toda la data MovieActor incluyendo la informacion de las peliculas y actores
                //var allMovieActorRelated = context.MovieActors
                //                           .Include(x => x.Movie).Include(x => x.Actor).ToList();

                //var actor = context.Actors.Select(x => x.ActorId).First();

                ////bring all the movies from specific actor
                //var allMoviesFromActor = context.MovieActors
                //    .Where(x => x.ActorId == actor)
                //    .Include(x => x.Movie).ToList();

                //Console.WriteLine(actor);

                //foreach (var item in allMoviesFromActor)
                //{
                //    Console.WriteLine(item.Actor.FirtsName);
                //    Console.WriteLine(item.Movie.Title);
                //    Console.WriteLine("all read");

                //}

                //Console.WriteLine(allMovieActor);
                //Console.WriteLine(allMovieActorRelated);
            //}


            //consultas de todo tipo a todas las tablas
            using (var context = new MovieDbContext())
            {
                //con FirstOrDefault() cuando encuentr el primer registro que coincida, para la iteracion
                //y devuelve el que cumpla la primera condicion, siempre devuelve un registro
                //var movie = context.Movies
                //                .Where(m => m.Title == "Ready Player One")
                //                .FirstOrDefault();


                //busqueda con clave primaria a travez de find
                //var movie = context.Movies.Find(4);
                //Console.WriteLine(movie);

                var movieDirector = context.MovieDirectors.Find(1, 1);
                Console.WriteLine(movieDirector);

                var allMovieDirectorRelated = context.MovieDirectors
                        .Include(x => x.Movie).Include(x => x.Director).ToList();

                //var allMovieActorRelated = context.MovieActors
                //                               .Include(x => x.Movie).Include(x => x.Actor).ToList();

                //var movieActor = context.MovieActors.Find(2, 5);
                //Console.WriteLine(movieActor.Movie.Title);

                //var movieD = context.Movies.Where(m => m.Title == "Ready Player One").Include(d => d.MovieDirector).

                //Console.WriteLine(movie.Title);
                //Console.WriteLine(movie.Genre);
                //Console.WriteLine(movie.Description);
                //Console.WriteLine(movie.Rating);
                //Console.WriteLine(movie.ReleaseDate);
                //Console.WriteLine(movie.MovieDirector);

            }

            Console.ReadKey();
        }
    }
}
