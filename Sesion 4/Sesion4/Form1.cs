using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion4
{
    public partial class Form1 : Form
    {
        public int Porcentaje {  get; set; }

        public Form1()
        {
            InitializeComponent();

            Porcentaje = (int) (this.Opacity*100);   // convertir con (int) el double a un entero
            nudPorcentaje.Value = Porcentaje;
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {

            this.Opacity = (this.Opacity>=1)?1: // Operador ternario: si la opacidad es mayor o igual a 1
                this.Opacity+=0.01;  // de lo contrario va a aumentar en un 10%
            mostrarOpacity();
            this.nudPorcentaje.Value = (int) (this.Opacity*100);
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            this.Opacity = (this.Opacity<=0.2)?0.2:
                this.Opacity-=0.01;
            mostrarOpacity();
            this.nudPorcentaje.Value = (int)(this.Opacity*100);
        }

        private void mostrarOpacity()
        {
            this.Text = "";
            this.Text = "Ejemplo 1 " + (this.Opacity * 100).ToString() + "%";   // agregar el *100 para multiplicarlo y por último el .ToString
            
            if (this.Opacity > 0.5) {   // si el valor de la opacidad es mayor del 50%...
                this.BackColor = Color.Red; // el fonde tendrá un color rojo...
            }
            else {
                this.BackColor = Color.Green;   // de lo contrario si el valor de la opacidad de enor del 50%, el fonde tendrá un color verde
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void nudPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (double) (nudPorcentaje.Value/100);
            mostrarOpacity();
            progressBar1.Value = (int) nudPorcentaje.Value;
        }
    }
}
