using MauiBlogUdla.Data;
using MauiBlogUdla.Models;
using PropertyChanged;
using System.Windows.Input;

namespace MauiBlogUdla.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class UsuarioPageViewModel
    {

 
        public UsuarioData UsuarioData { get; set; }    
        public Usuario CurrentUsuario { get; set; }
        public ICommand GuardarUsuario { get; set; }

        public UsuarioPageViewModel()
        {

         // var User = App.BancoDatos.UsuarioDataTable.ListaUsuarios();

     //       listaUsuario.ItemsSource = await App.BancoDatos.UsuarioDataTable.ListaUsuarios();
        }

    }

}
