using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using LoginClass; //Librería en la que pasamos el método con el Connectionstring del xml linkeado a nuestra base de datos.

namespace ReserbyFormsApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creamos este método con las variables execute, user y pass, de tipo Login (extraída de nuestra librería de clases) 
        /// y string para realizar la validación de los usuarios dentro del formulario del login.
        /// </summary>
        public void Conectar()
        {
            Login execute = new Login(); //Creamos una nueva variable de clase Login para poder operar con ella trayendo los elementos de la librería.
            string user = Usertxt.Text;
            string pass = Passwordtxt.Text;

            execute.Entrar(user, pass); //Ejecutamos la función de entrada dentro de la librería y le pasamos como parámetro nuestros cuadros de texto.

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Conectar();//Conectamos la función de validación al botón de login.
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Los siguientes eventos son utilizados para los cuadros de texto Passwordtxt y Usertxt, esto para hacer que
        /// el texto por default dentro de dichos cuadros de texto se limpie y nos quede una vista más estética a la
        /// hora de introducir la información de usuario.
        /// </summary>
        /// <param name="sender">Hace refencia al objeto Usertxt que disparó el evento Enter</param>
        /// <param name="e">Parámetro que nos sirve para pasar la información del evento a la clase EventArgs</param>
    

        private void Usertxt_Enter(object sender, EventArgs e)
        {
            /*Si el textbox contiene la palabra "Correo electrónico", al hacer clic en dicho sitio, el textbox
             se limpiará automáticamente*/
            if (Usertxt.Text == "Correo electrónico")
            {
                Usertxt.Text = "";
                Usertxt.ForeColor = Color.AntiqueWhite;
            }
        }

        private void Usertxt_Leave(object sender, EventArgs e)
        {
            /*Si el textbox está vacío, cuando se haga clic en otro lado, el textbox volverá a tener su contenido
             original, en este caso, la palabra "Correo electrónico"*/
            if (Usertxt.Text == "")
            {
                Usertxt.Text = "Correo electrónico";
                Usertxt.ForeColor = Color.White;
            }
        }

        private void Passwordtxt_Enter(object sender, EventArgs e)
        {
            if (Passwordtxt.Text == "Contraseña")
            {
                Passwordtxt.Text = "";
                Passwordtxt.ForeColor = Color.AntiqueWhite;
            }

        }

        private void Passwordtxt_Leave(object sender, EventArgs e)
        {
            if (Passwordtxt.Text == "")
            {
                Passwordtxt.Text = "Contraseña";
                Passwordtxt.ForeColor = Color.White;
            }
        }
    }
}
