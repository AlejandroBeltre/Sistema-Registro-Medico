using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesarrolloFinal
{
    public partial class Modifcar_Registro : Form
    {
        public Modifcar_Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conexion = new OleDbConnection();
                conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\aleja\Desktop\RegistroMédico.accdb;Persist Security Info=False;";
                conexion.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM RegistroPacientes WHERE NombreCompleto = @NombreCompleto";
                comando.Parameters.AddWithValue("@NombreCompleto", txtNombreCompleto.Text);

                OleDbDataReader reader = comando.ExecuteReader();
                conexion.Close();
            } catch(Exception er) 
            {
                MessageBox.Show($"Error {er}");
            }

            Modificar_Registro_Paciente ventana = new Modificar_Registro_Paciente();
            ventana.Show();

            this.Hide();
        }
    }
}
