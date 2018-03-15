using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Moov.Database
{
    class tbl_User_Genre
    {
        [ForeignKey(typeof(User))]
        public int user_ID { get; set; }

        [ForeignKey(typeof(Genre))]
        public int genre_ID { get; set; }
    }
}
