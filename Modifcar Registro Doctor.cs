using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesarrolloFinal
{
    public partial class Modifcar_Registro_Doctor : Form
    {
        public Modifcar_Registro_Doctor()
        {
            InitializeComponent();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla_de_guardado_exitoso ventana = new Pantalla_de_guardado_exitoso();
            ventana.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
