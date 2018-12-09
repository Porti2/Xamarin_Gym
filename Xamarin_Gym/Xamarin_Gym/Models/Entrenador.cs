using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Gym.Models
{
    public class Entrenador
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public String Nombre { get; set; }

        public int DNI { get; set; }

        public int Telefono { get; set; }

        public DateTime Nacimiento { get; set; }

        public String Correo { get; set; }

        public String Direccion { get; set; }

        public String Ciudad { get; set; }
    }
}
