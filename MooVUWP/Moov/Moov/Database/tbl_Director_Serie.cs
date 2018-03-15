using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Moov.Database
{
    class tbl_Director_Serie
    {
        [ForeignKey(typeof(Director))]
        public int director_ID { get; set; }

        [ForeignKey(typeof(Serie))]
        public int serie_ID { get; set; }
    }
}
