using System;
using System.Collections.Generic;
using System.Text;

namespace MovieActorConsole
{
    public class Actor
    {
        public int ActorId { get; set; }

        public string FirtsName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<MovieActor> MovieActor { get; set; }
    }
}
