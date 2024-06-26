namespace MauiBlogUdla.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void ClickLogin(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginUsuarioPage());
    }

    private async void ClickRegistro(object sender, EventArgs e)
    {
       await Navigation.PushAsync(new RegistrarUsuarioPage());  
    }
}