using MauiBlogUdla.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlogUdla.Data
{
    public class PostData
    {
        
        private static readonly string _conexionDBPath= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Post.db3");
        private static SQLiteConnection _conexionDB;
        private static List<Post> _posts = new List<Post>();


        public PostData()
        {
            _conexionDB = new SQLiteConnection(_conexionDBPath);
            _conexionDB.CreateTable<Post>();

        }
        public List<Post> GetPost(string postId)
        {
            return  _conexionDB.Table<Post>().Where(x=>x.Titulo==postId).ToList();
        }
        public List<Post> GetAllPosts()
        {
            return _conexionDB.Table<Post>().ToList();
        }
        public void GuardarPost(Post post)
        {
            _conexionDB.Insert(post);
        }

        public static List<Post> Posts
        {
            get { return _posts; }
        }
        public void UpdatePost(Post post)
        {
            _conexionDB.Update(post);
        }

        public void DeletePost(int id)
        {
            _conexionDB.Delete<Post>(id);
        }
    }
}
