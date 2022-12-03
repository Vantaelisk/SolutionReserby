using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReserbyFormsApp
{
    public partial class SplashBienvenida : Form
    {
        public SplashBienvenida()
        {
            InitializeComponent();
        }

        int contador = 0; //Declaramos una variable tipo int para que nos funcione como un referente del tiempo en el cual se debe abrir y cerrar el splash.
        

        /// <summary>
        /// Los siguientes eventos son utilizados para el efecto de aparecer y desvanecer del formulario de bienvenida.
        /// </summary>
        /// <param name="sender">Referencia a la herramienta timer, la cual disparó el evento Tick</param>
        /// <param name="e">Parámetro que nos sirve para pasar la información del evento a la clase EventArgs</param>
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*Si la opacidadd es menor que 1, entonces haremos que esta aumente de 0.05 en 0.05, pues la
             opacidad funciona con porcentajes. Una vez que el contador llegue a 100, detendremos el timer 1
            e iniciaremos el timer 2*/
            if (this.Opacity < 1) this.Opacity += 0.05;
            contador += 1;
            if(contador == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*El timer 2 disminuirá la opacidad de 0.1 en 0.1 hasta llegar a 0, y una vez que esto suceda
             vamos a ocultar el formulario de bienvenida y vamos a mostrar el formulario de Login.*/
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Hide();
                FormLogin formulario = new FormLogin();
                formulario.ShowDialog();
            }
        }

        private void SplashBienvenida_Load(object sender, EventArgs e)
        {
            /*En el evento del Splash lo iniciamos con opacidad 0 para que pueda funcionar la condición del timer1
             e iniciamos el timer*/
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
