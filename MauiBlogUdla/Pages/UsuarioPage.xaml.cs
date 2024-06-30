using MauiBlogUdla.Data;
using MauiBlogUdla.Models;
using MauiBlogUdla.ViewModels; 

namespace MauiBlogUdla.Pages;

public partial class UsuarioPage : ContentPage
{
	public List<Usuario> Usuarios { get; set; }
	public UsuarioPage( )
	{
		InitializeComponent();
	//	BindingContext = new UsuarioPageViewModel();

        ActualizarPage( );
	}

	private async void ActualizarPage()
	{
		Usuarios = await App.BancoDatos.UsuarioDataTable.ListaUsuarios();
		//listaUsuario.ItemTemplate = await App.BancoDatos.UsuarioDataTable.ListaUsuarios();		//listaUsuario.Layout = await App.BancoDatos.UsuarioDataTable.ListaUsuarios();
		// listaUsuario.ItemsSource=await App.BancoDatos.UsuarioDataTable.ListaUsuarios();
		BindingContext = this;
    }

    private void CerrarSesion(object sender, EventArgs e)
    {
		Navigation.PushAsync(new HomePage());
    }
}