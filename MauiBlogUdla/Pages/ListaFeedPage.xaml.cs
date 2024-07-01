namespace MauiBlogUdla.Pages;

public partial class ListaFeedPage : ContentPage
{
   // private View _originalContent;
    public ListaFeedPage()
	{
		InitializeComponent();
        //_originalContent = ContenArea.Content;
            
    }

    private void ficaButton_Clicked(object sender, EventArgs e)
    {
      
    }

    private void nodoButton_Clicked(object sender, EventArgs e)
    {

        var postPageNodo = new PostPageNodo();
        ContenArea.Content= postPageNodo.Content;

        // Subscribe to the BackButtonClicked event
      
    }
}