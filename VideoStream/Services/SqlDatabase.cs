using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using VideoStream.Models;

namespace VideoStream.Services
{
    public class SqlDatabase
    {
        readonly SQLiteAsyncConnection database;

        public SqlDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Video>().Wait();
        }

        public async Task<List<Video>> GetAllVideos()
        {
            return await database.Table<Video>().ToListAsync();
        }

        public async Task AddVideo(Video video)
        {
           await database.InsertAsync(video);
        }
    }
}
