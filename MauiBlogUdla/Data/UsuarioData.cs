using MauiBlogUdla.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlogUdla.Data
{
    public class UsuarioData
    {
        private SQLiteAsyncConnection _conexionDB;
        
        public UsuarioData(SQLiteAsyncConnection conexionDB)
        {
            _conexionDB = conexionDB;
        }
        public Task<List<Usuario>> ListaUsuarios()
        {
            var resultado= Task.FromResult(new List<Usuario> { App.Usuario});

             
            var lista= _conexionDB
                .Table<Usuario>()
                .ToListAsync();
            return resultado;
        }

     



        public Task<Usuario> GetUsuario(string username, string password)
        {
            var usuario = _conexionDB.Table<Usuario>().Where(x=>x.Username == username&& x.Password == password).FirstOrDefaultAsync();
            return usuario;
        }
        public Task<Usuario> GetUsuario(Guid Id)
        {
            var usuario = _conexionDB
               .Table<Usuario>().Where(x=>x.Id == Id).FirstOrDefaultAsync();
            return usuario;
        }

        public async Task<int> GuardarUsuario(Usuario usuario) {

            var usuarioGuardado = await GetUsuario(usuario.Id);
            if (usuarioGuardado == null)
            {
                return await _conexionDB.InsertAsync(usuario);
            }
            else { 
            return await _conexionDB.UpdateAsync(usuario);
            }

        }
        public async Task<int> EliminarUsuario(Guid id)
        {
            return await _conexionDB.DeleteAsync(id);   
        }

        internal Usuario GetUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
