 
using System.Collections.Generic;
namespace MauiBlogUdla.Pages;

public partial class PostPageNodo : ContentPage
{
    //public event EventHandler BackButtonClicked;

    public PostPageNodo()
	{
        InitializeComponent();
    }

    private void ClickPostNodo(object sender, EventArgs e)
    {

    }

    private void PostPicker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private async void ClickVolver(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListaFeedPage());    
    }
}