using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Xamarin_Gym.ViewModels
{
    public class MainViewModel
    {

        public MainViewModel()
        {
            LoadMenu();
        }

        public ObservableCollection<ItemsMenu> Menu { get; set; }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<ItemsMenu>();

            Menu.Add(new ItemsMenu()
            {
                Icon = "ic_launcher",
                Title = "Entrenadores",
                PageName = "ListaEntrenadores"
            });

            Menu.Add(new ItemsMenu()
            {
                Icon = "ic_launcher",
                Title = "Añadir Entrenador",
                PageName = "AltaEntrenador"
            });

            Menu.Add(new ItemsMenu()
            {
                Icon = "ic_launcher",
                Title = "Clientes",
                PageName = "ListaClientes"
            });

            Menu.Add(new ItemsMenu()
            {
                Icon = "ic_launcher",
                Title = "Añadir Cliente",
                PageName = "AltaCliente"
            });
        }
    }
}
