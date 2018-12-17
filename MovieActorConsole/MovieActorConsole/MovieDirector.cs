using System;
using System.Collections.Generic;
using System.Text;

namespace MovieActorConsole
{
    public class MovieDirector
    {
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }

    }
}
