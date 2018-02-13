using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationOK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonEurosClick(object sender, EventArgs e)
        {
            double valor = Double.Parse(this.texto.Text)/166.0;
            MessageBox.Show("El valor es " + valor);
            this.resultado.Text = "Euros: " + valor;
            this.botonEuros.Visible = false;

           // Form f = new Producto();
           // f.Visible = true;
            new Producto().Visible = true;
           // this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
