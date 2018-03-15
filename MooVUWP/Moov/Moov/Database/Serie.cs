using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Moov.Database
{
    class Serie
    {
        [PrimaryKey, AutoIncrement]
        public int serie_ID { get; set; }

        public string serie_Name { get; set; }

        public int serie_Seasons { get; set; }

        public int serie_Episodes { get; set; }

        [ForeignKey(typeof(Director))]
        public int director_ID { get; set; }
    }
}
