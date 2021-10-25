using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS3PB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewDos : ContentPage
    {
        public viewDos(string usuario, string contrasena)
        {
            //verificar GIT prueba 1 cambio
            InitializeComponent();
            //Envio de los label etiquetas
            lblUsuario.Text = usuario;
            lblContrasena.Text = contrasena;
            //Envio de las cajas de texto
            txtUsuario.Text = usuario;
            txtContrasena.Text = contrasena;

        }
    }
}