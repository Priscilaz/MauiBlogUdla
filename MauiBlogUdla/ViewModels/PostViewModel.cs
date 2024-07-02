using MauiBlogUdla.Models;
using MauiBlogUdla.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
 

namespace MauiBlogUdla.ViewModels
{
    public class PostViewModel : INotifyPropertyChanged
    {
        private PostData _postData;
        private ObservableCollection<Post> _posts;

        private string _titulo;
        private string _contenido;
        private string _comentario;

        public string Titulo
        {
            get { return _titulo; }
            set
            {
                _titulo = value;
                OnPropertyChanged();
            }
        }

        public string Contenido
        {
            get { return _contenido; }
            set
            {
                _contenido = value;
                OnPropertyChanged();
            }
        }

        public string Comentario
        {
            get { return _comentario; }
            set
            {
                _comentario = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Post> Posts
        {
            get { return _posts; }
            set
            {
                _posts = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadPostsCommand { get; }
        public ICommand AddPostCommand { get; }

        public PostViewModel()
        {
            _postData = new PostData();
            _posts = new ObservableCollection<Post>();
            LoadPostsCommand = new Command(LoadPosts);
            AddPostCommand = new Command(AddPost);
            LoadPosts();
        }

        private void LoadPosts()
        {
            var posts = _postData.GetAllPosts();
            Posts = new ObservableCollection<Post>(posts);
        }

        private void AddPost()
        {
            var newPost = new Post
            {
                Titulo = this.Titulo,
                Contenido = this.Contenido,
                Comentario = this.Comentario
            };

            _postData.GuardarPost(newPost);
            LoadPosts(); // Refresh the posts list
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
