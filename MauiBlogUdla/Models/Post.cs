using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlogUdla.Models
{
    public class Post
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }   
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}
