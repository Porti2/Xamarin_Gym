using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin_Gym.Models;

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
        public ObservableCollection<Cliente> ListaClientes { get; set; }


        private void LoadMenu()
        {
            Menu = new ObservableCollection<ItemsMenu>
            {
                new ItemsMenu()
                {
                    Icon = "entrenador",
                    Title = "Entrenadores",
                    PageName = "ListaEntrenadores"
                },

                new ItemsMenu()
                {
                    Icon = "addEntrenador",
                    Title = "Añadir Entrenador",
                    PageName = "AltaEntrenador"
                },

                new ItemsMenu()
                {
                    Icon = "clientes",
                    Title = "Clientes",
                    PageName = "ListaClientes"
                },

                new ItemsMenu()
                {
                    Icon = "add",
                    Title = "Añadir Cliente",
                    PageName = "AltaCliente"
                }
            };
        }

        private void LoadData()
        {

            ListaClientes = new ObservableCollection<Cliente>
                {
                    new Cliente()
                    {
                        ID = 1,
                        Nombre = "Aaron Martin Gutierrez",
                        DNI = Int32.Parse("54697083"),
                        Telefono = Int32.Parse("64891706"),
                        Nacimiento = Convert.ToDateTime("12/12/1996"),
                        Correo = "Aaron_Martin@gmail.com",
                        Direccion = "Mozart, 250",
                        Ciudad = "Almería"
                    },
                     new Cliente()
                    {
                        ID = 2,
                        Nombre = "Maria Martin Gutierrez",
                        DNI = Int32.Parse("54697083"),
                        Telefono = Int32.Parse("64891706"),
                        Nacimiento = Convert.ToDateTime("12/12/1996"),
                        Correo = "Maria_Martin@gmail.com",
                        Direccion = "Mozart, 250",
                        Ciudad = "Almería"
                    },
                     new Cliente()
                    {
                        ID = 3,
                        Nombre = "Concha San Franciso",
                        DNI = Int32.Parse("89435678"),
                        Telefono = Int32.Parse("94267859"),
                        Nacimiento = Convert.ToDateTime("10/1/1995"),
                        Correo = "SanFrancisco@gmail.com",
                        Direccion = "Mozart, 250",
                        Ciudad = "Almería"
                    }
                };

        }
    }
}
