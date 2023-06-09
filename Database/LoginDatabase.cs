using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstaFood.Models;
using SQLite;

namespace InstaFood.Database
{
    public class LoginDatabase
    {
        private readonly SQLiteAsyncConnection database;

        public LoginDatabase(string dbpath)
        {
            database = new SQLiteAsyncConnection(dbpath);
            database.CreateTableAsync<User>().Wait();
        }

        public Task<User> GetLoginData(string username, string password)
        {
            return database.Table<User>().Where(x => x.Username == username).FirstOrDefaultAsync();
        }

        public Task<int> SaveLoginData(User userdata)
        {
            return database.InsertAsync(userdata);
        }

        //public async Task<string> ResetPassword(User user)
        //{


        //}
    }
}
