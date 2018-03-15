using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Moov.Database
{
    class Actor
    {
        [PrimaryKey, AutoIncrement]
        public int actor_ID { get; set; }

        public string actor_Name { get; set; }
    }
}
