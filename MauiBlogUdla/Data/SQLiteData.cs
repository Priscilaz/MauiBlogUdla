using MauiBlogUdla.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlogUdla.Data
{
     
    public class SQLiteData
       
    {
        readonly SQLiteAsyncConnection _conexionDB;
      
        public UsuarioData UsuarioDataTable {  get; set; }

        public SQLiteData(string path) {
            _conexionDB = new SQLiteAsyncConnection(path);

            _conexionDB.CreateTableAsync<Usuario>().Wait();

            UsuarioDataTable = new UsuarioData(_conexionDB);

        }

    }
}
