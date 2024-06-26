using MauiBlogUdla.Models;

namespace MauiBlogUdla.Pages;

public partial class RegistrarUsuarioPage : ContentPage
{
    Usuario _usuario;
   
    public RegistrarUsuarioPage()
	{
		InitializeComponent();
	    _usuario= new Usuario();
        this.BindingContext = _usuario; 
    }

    private async void ClickRegistrarse(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_usuario.Username) && string.IsNullOrEmpty(_usuario.Password) && string.IsNullOrWhiteSpace(_usuario.Nombre) && string.IsNullOrWhiteSpace(_usuario.Apellido)) {
            await DisplayAlert("Atencion","Llena toda la informacion","Ok");
            return;
        }
        var registro = await App.BancoDatos.UsuarioDataTable.GuardarUsuario(_usuario);
        if (registro > 0) {
            await Navigation.PopAsync();
        }



    }

    private void ClickInicioSesionRegistro(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginUsuarioPage());   
    }
}