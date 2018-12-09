using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_Gym.Paginas;
using Xamarin_Gym.Services;

namespace Xamarin_Gym.ViewModels
{
    public class ItemsMenu
    {

        public string Icon { get; set; }

        public string Title { get; set; }

        public string PageName { get; set; }


        public ICommand NavigateCommand
        {
            get { return new RelayCommand(Navigate); }
        }

        private async void Navigate()
        {
            App.Master.IsPresented = false;
            switch (PageName)
            {
                case "AltaEntrenador":
                    await App.Navigator.PushAsync(new AltaEntrenador());
                    break;
                case "ListaEntrenadores":
                    await App.Navigator.PushAsync(new ListaEntrenadores());
                    break;
                case "AltaCliente":
                    await App.Navigator.PushAsync(new AltaCliente());
                    break;
                case "ListaClientes":
                    await App.Navigator.PushAsync(new ListaClientes());
                    break;
                default:
                    break;
            }
        }
        
        private static async Task Navigate<T>(T page) where T : Page
        {
            NavigationPage.SetHasBackButton(page, false);
            
            await App.Navigator.PushAsync(page);
        }
        
    }
}
