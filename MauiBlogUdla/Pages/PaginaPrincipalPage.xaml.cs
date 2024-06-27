namespace MauiBlogUdla.Pages;

public partial class PaginaPrincipalPage : TabbedPage
{
	public PaginaPrincipalPage()
	{
		InitializeComponent();
		var pagina1 = new ListaFeedPage()
		{
			Title = "Home",
			IconImageSource = ""
		};

        var pagina2 = new UsuarioPage()
        {
            Title = "Usuario",
            IconImageSource = ""
        };

		this.Children.Add(pagina1);
        this.Children.Add(pagina2);
		
	}
}