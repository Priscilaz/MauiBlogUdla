


using MauiBlogUdla.Data;
using MauiBlogUdla.Models;
using MauiBlogUdla.Pages;

namespace MauiBlogUdla
{
    public partial class App : Application
    {
        static SQLiteData? _bancoDatos;
     public static SQLiteData BancoDatos {

            get
            {
                if (_bancoDatos == null)
                {
                    _bancoDatos = new SQLiteData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Datos.db"));
                   /* _bancoDatos =
                        new SQLiteData(DependencyService.Get<ISQLiteBD>().SQLiteLocalPath("Datos.db"));*/
                }
                return _bancoDatos;
            }
        }

        public static Usuario Usuario { get;set; }
        public static Post Posts { get;set; }    
        public App()
        {
            InitializeComponent();

          
        MainPage = new NavigationPage(new HomePage());  
        }
    }
}
