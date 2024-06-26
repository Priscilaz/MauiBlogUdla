namespace MauiBlogUdla.Pages;

public partial class UsuarioPage : ContentPage
{
	public UsuarioPage()
	{
		InitializeComponent();
		ActualizarPage();
	}

	private async void ActualizarPage()
	{
		
	listaUsuario.ItemsSource=await App.BancoDatos.UsuarioDataTable.ListaUsuarios();

	}
}