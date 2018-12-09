using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Gym.Models;
using Xamarin_Gym.Services;
using Xamarin_Gym.Paginas;
using SQLite;
using Xamarin_Gym.Services.Sqlite;

namespace Xamarin_Gym.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AltaCliente : ContentPage
    {
       // private ISqliteService _sqliteService;

        public AltaCliente()
        {
            InitializeComponent();
        }

        private async Task<bool> ValidarFormulario()
        {
            //Valida si el valor en el Entry se encuentra vacio o es igual a Null
            if (String.IsNullOrWhiteSpace(NombreEntry.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo del nombre es obligatorio.", "OK");
                return false;
            }
            //Valida que solo se ingresen letras
            else if (!NombreEntry.Text.ToCharArray().All(Char.IsLetter))
            {
                await this.DisplayAlert("Advertencia", "Tu nombre contiene números, porfavor eliminelos.", "OK");
                return false;
            }

            //*********************************************************************************************************

            if (String.IsNullOrWhiteSpace(EmailEntry.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo del correo electronico es obligatorio.", "OK");
                return false;
            }
            else
            {
                //Valida que el formato del correo sea valido
                bool isEmail = Regex.IsMatch(EmailEntry.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (!isEmail)
                {
                    await this.DisplayAlert("Advertencia", "El formato del correo electrónico es incorrecto, revíselo e intente de nuevo.", "OK");
                    return false;
                }
            }

            //*********************************************************************************************************

            if (String.IsNullOrWhiteSpace(TelefonoEntry.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo del número telefono es obligatorio.", "OK");
                return false;
            }
            //Valida si la cantidad de digitos ingresados es menor a 10
            else if (TelefonoEntry.Text.Length > 10)
            {
                await this.DisplayAlert("Advertencia", "No puede haber mas de 10 digitos, por favor intentelo de nuevo.", "OK");
                return false;
            }
            else
            {
                //Valida que solo se ingresen numeros
                if (!TelefonoEntry.Text.ToCharArray().All(Char.IsDigit))
                {
                    await this.DisplayAlert("Advertencia", "El numero de telefono es incorrecto, solo se aceptan numeros.", "OK");
                    return false;
                }
            }

            //*********************************************************************************************************

            if (String.IsNullOrWhiteSpace(DNIEntry.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo del DNI es obligatorio.", "OK");
                return false;
            }
            //Valida que solo se introducen numeros
            else if (!DNIEntry.Text.ToCharArray().All(Char.IsDigit))
            {
                await this.DisplayAlert("Advertencia", "El formato del DNI es incorrecto, solo se aceptan numeros.", "OK");
                return false;
            }

            return true;
        }

        public async void Continue_Tapped(object sender, EventArgs e)
        {

            if (await ValidarFormulario())
            {
                await DisplayAlert("Exito", "Todos los campos son correctos.", "OK");
                /*
                var cliente = new Cliente
                {
                    Nombre = NombreEntry.Text,
                    DNI = Int32.Parse(DNIEntry.Text),
                    Telefono = Int32.Parse(TelefonoEntry.Text),
                    Nacimiento = FechaNacimientoEntry.Date,
                    Correo = EmailEntry.Text,
                    Direccion = DireccionEntry.Text,
                    Ciudad = Convert.ToString(CiudadEntry.SelectedItem)
                };

                NombreEntry.Text = "";
                DNIEntry.Text = "";
                TelefonoEntry.Text = "";
                FechaNacimientoEntry.Date = DateTime.Now;
                EmailEntry.Text = "";
                DireccionEntry.Text = "";
                CiudadEntry.SelectedItem = "";
                
                await _sqliteService.Insert(cliente);
                await DisplayAlert("Confirmación", "Cliente añadido correctamente.", "OK");
                */
            }
        }
    }
}