using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_Gym.ViewModels;

namespace Xamarin_Gym.Infraestructura
{
    public class InstanciarMenu
    {
        public InstanciarMenu()
        {
            Main = new MainViewModel();
        }

        public MainViewModel Main { get; set; }

    }
}
