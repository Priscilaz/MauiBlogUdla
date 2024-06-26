namespace MauiBlogUdla.Pages;

public partial class LoginUsuarioPage : ContentPage
{
	public LoginUsuarioPage()
	{
		InitializeComponent();
	}

    private void ClickIngreso(object sender, EventArgs e)
    {

    }

    private void ClickRegistroInicio(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegistrarUsuarioPage());
    }
}