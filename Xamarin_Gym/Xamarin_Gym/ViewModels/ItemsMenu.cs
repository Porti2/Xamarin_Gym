using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin_Gym.Paginas;

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

        private void Navigate()
        {
            App.Master.IsPresented = false;
            switch (PageName)
            {
                case "AltaEntrenador":
                    App.Navigator.PushAsync(new AltaEntrenador());
                    break;
                case "ListaEntrenadores":
                    App.Navigator.PushAsync(new ListaEntrenadores());
                    break;
                case "AltaCliente":
                    App.Navigator.PushAsync(new AltaCliente());
                    break;
                case "ListaClientes":
                    App.Navigator.PushAsync(new ListaClientes());
                    break;
                default:
                    break;
            }
        }
    }
}
