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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void cierra(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cierra(object sender, FormClosingEventArgs e)
        {

        }
    }
}
