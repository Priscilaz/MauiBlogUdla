namespace MauiBlogUdla.Pages;

public partial class PaginaPrincipalPage : TabbedPage
{
	public PaginaPrincipalPage()
	{
		InitializeComponent();
		var pagina1 = new ListaFeedPage()
		{
			Title = "Home",
			IconImageSource = "dotnet_bot.png"
		};

        var pagina2 = new PostPage()
        {
            Title = "Post",
			
            IconImageSource = ""
        };
        var pagina3 = new UsuarioPage()
        {
            Title = "Usuario",

            IconImageSource = "usuario.png"
        };

        this.Children.Add(pagina1);
        this.Children.Add(pagina2);
        this.Children.Add(pagina3);

    }
}