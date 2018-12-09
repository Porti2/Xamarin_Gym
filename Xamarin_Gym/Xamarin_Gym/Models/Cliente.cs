using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Gym.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        //[PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public string Nombre { get; set; }

        public int DNI { get; set; }

        public int Telefono { get; set; }
         
        public DateTime Nacimiento { get; set; }

        public string Correo { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

    }
}
