using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Gym.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaView : ContentPage
    {
        public PaginaView()
        {
            InitializeComponent();
        }

        private void AddEntrenador(object sender, EventArgs e)
        {
            App.Navigator.PushAsync(new AltaEntrenador());
        }

        private void VerEntrenador(object sender, EventArgs e)
        {
            App.Navigator.PushAsync(new ListaEntrenadores());
        }

        private void AddCliente(object sender, EventArgs e)
        {
            App.Navigator.PushAsync(new AltaCliente());
        }

        private void VerCliente(object sender, EventArgs e)
        {
            App.Navigator.PushAsync(new ListaClientes());
        }
    }
}