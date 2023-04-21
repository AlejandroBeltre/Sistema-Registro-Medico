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
    public partial class Sistema_Registro_Médico : Form
    {
        public Sistema_Registro_Médico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crear_Registro ventana  = new Crear_Registro();
            ventana.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Modifcar_Registro ventana2 = new Modifcar_Registro();
            ventana2.Show();

            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            Eliminar_Registro ventana3 = new Eliminar_Registro();
            ventana3.Show();

            this.Hide();
        }

        private void Sistema_Registro_Médico_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Crear un objeto OpenFileDialog para seleccionar el archivo de base de datos Access
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de base de datos Access (*.accdb)|*.accdb|Todos los archivos (*.*)|*.*";

            // Si se selecciona un archivo, establecer la cadena de conexión y abrir la conexión
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string connectionString = $"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\aleja\\Desktop\\RegistroMédico.accdb;Persist Security Info=False;";
                OleDbConnection connection = new OleDbConnection(connectionString);
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos de Access.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}