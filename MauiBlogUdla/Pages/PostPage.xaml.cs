using MauiBlogUdla.Data;
using MauiBlogUdla.Models;
using System.Collections.Generic;
 
namespace MauiBlogUdla.Pages
{
    public partial class PostPage : ContentPage
    {
        private PostData _postData;

        public PostPage()
        {
            InitializeComponent();
            _postData = new PostData();
            LoadPosts();
        }

        private void LoadPosts()
        {
            List<Post> posts = _postData.GetPost(""); // Get all posts
            PostsListView.ItemsSource = posts;
        }

        private async void OnPostTapped(object sender, ItemTappedEventArgs e)
        {
            var post = e.Item as Post;
            if (post != null)
            {
               // await Navigation.PushAsync(new PostPage(post));
            }
        }

        private void PostPicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClickPostNodo(object sender, EventArgs e)
        {

        }
    }
}
