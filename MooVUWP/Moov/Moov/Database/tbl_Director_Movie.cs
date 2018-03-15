using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Moov.Database
{
    class tbl_Director_Movie
    {
        [ForeignKey(typeof(Director))]
        public int director_ID { get; set; }

        [ForeignKey(typeof(Movie))]
        public int movie_ID { get; set; }
    }
}
