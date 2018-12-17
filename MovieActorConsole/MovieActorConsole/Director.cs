using System;
using System.Collections.Generic;
using System.Text;

namespace MovieActorConsole
{
    public class Director
    {
        public int DirectorId { get; set; }

        public string FirtsName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<MovieDirector> Movies { get; set; }
    }
}
