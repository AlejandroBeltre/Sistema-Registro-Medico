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
    public partial class Modificar_Registro_Paciente : Form
    {
        public Modificar_Registro_Paciente()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modifcar_Registro_Doctor ventana = new Modifcar_Registro_Doctor();
            ventana.Show();

            this.Hide();
        }
    }
}
