using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Moov.Database
{
    class Genre
    {
        [PrimaryKey, AutoIncrement]
        public int genre_ID { get; set; }

        public string genre { get; set; }
    }
}
