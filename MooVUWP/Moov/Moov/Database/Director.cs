using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Moov.Database
{
    class Director
    {
        [PrimaryKey, AutoIncrement]
        public int director_ID { get; set; }
    }
}
