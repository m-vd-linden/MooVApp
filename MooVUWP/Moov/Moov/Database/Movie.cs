using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Moov.Database
{   
    class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int movie_ID { get; set; }

        public string movie_TItle { get; set; }
            
        public int movie_Duration { get; set; }

        public string movie_Description { get; set; }

        [ForeignKey(typeof(Director))]
        public int director_ID { get; set; }

        //insert way of saving movie image to a blob
    }
}
