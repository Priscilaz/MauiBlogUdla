namespace MauiBlogUdla.Pages;

public partial class LoginUsuarioPage : ContentPage
{
	public LoginUsuarioPage()
	{
		InitializeComponent();
	}

    private async void ClickIngreso(object sender, EventArgs e)
    {
        string email= usernameEntry.Text;
        string password= passwordEntry.Text;
        if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password)) 
        { 
            var usuario = await App.BancoDatos.UsuarioDataTable.GetUsuario(email, password);
            if (usuario == null) {
                await DisplayAlert("Error", "Username o contraseña invalidos", "Ok");
                return;
            }

            App.Usuario = usuario;
            
           Navigation.PushAsync(new PaginaPrincipalPage());
        
        }
    }

    private void ClickRegistroInicio(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegistrarUsuarioPage());
    }
}