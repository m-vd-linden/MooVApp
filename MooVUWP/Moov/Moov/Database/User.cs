using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Moov.Database
{
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int user_ID { get; set; }

        public string userName { get; set; }

        public string status { get; set; }
    }
}
