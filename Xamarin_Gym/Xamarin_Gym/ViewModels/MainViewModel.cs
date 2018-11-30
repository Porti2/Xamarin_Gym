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
            LoadData();
        }

        public ObservableCollection<ItemsMenu> Menu { get; set; }
        public ObservableCollection<DatosEntrenadores> VerEntrenadores { get; set; }


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

        private void LoadData()
        {
            VerEntrenadores = new ObservableCollection<DatosEntrenadores>();

            for(int i = 0; i < 7; i++)
            {
                VerEntrenadores.Add(new DatosEntrenadores()
                {
                    Id = "1",
                    Nombre = "Entrenador 1",
                    DNI = 54987,
                    Telefono = 65487634,
                    Correo = "entrador1@gmail.com",
                    Direccion = "Mozartr, 155",
                    Ciudad = "Almeria"
                });
            }
        }
    }
}
