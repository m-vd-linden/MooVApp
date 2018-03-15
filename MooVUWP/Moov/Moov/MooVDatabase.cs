using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Moov.Database;
using SQLiteNetExtensions.Attributes;

namespace Moov
{
    class MooVDatabase
    {
        readonly SQLiteAsyncConnection database;
        public MooVDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTablesAsync<User, Genre>().Wait();
            database.CreateTablesAsync<Actor, Director>().Wait();
            database.CreateTablesAsync<Movie, Serie>().Wait();
            database.CreateTablesAsync<tbl_Director_Movie, tbl_Director_Serie>().Wait();
            database.CreateTableAsync<tbl_User_Genre>().Wait();
        }
        
        public SQLiteAsyncConnection getInstance()
        {
            return database;
        }
    }
}
