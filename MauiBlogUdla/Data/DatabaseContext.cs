 
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlogUdla.Data
{
    public class DatabaseContext
    {
        private const string DbName = "MyDatabase.db3";
        private static string DbPath => Path.Combine(FileSystem.AppDataDirectory, DbName);

        private SQLiteAsyncConnection _connection;
        private SQLiteAsyncConnection Database => (_connection ??= new SQLiteAsyncConnection
            (DbPath,    SQLiteOpenFlags.Create|SQLiteOpenFlags.ReadWrite|SQLiteOpenFlags.SharedCache));


      public async Task<IEnumerable<TTable>> GetAllAsync<TTable>() where TTable : class, new()
        {
            await Database.CreateTableAsync<TTable>();
           return await Database.Table<TTable>().ToListAsync();

        }
        public async Task<IEnumerable<TTable>> GetFilteredAsync<TTable>(Expression<Func<TTable,bool>> predicate) where TTable : class, new()
        {
            await Database.CreateTableAsync<TTable>();
            return await Database.Table<TTable>().Where(predicate).ToListAsync();

        }


    }
}
