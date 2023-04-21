using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;    

namespace DesarrolloFinal
{
    public partial class Crear_Registro_Doctor : Form
    {
        public string NombreCompleto { get; set; }
        public string Sexo { get; set; }
        public int NumeroDeLicencia { get; set; }
        public string EspecialidadMedica { get; set; }
        public string Notas { get; set; }
        public string FechaDeIngreso { get; set; }
        public string DuraccionDeConsulta { get; set; }
        public string ResultadoDePruebasExamenes { get; set; }
        public string Diagnostico { get; set; }
        public string InformacionSobreMedicamentos { get; set; }
        public Crear_Registro_Doctor()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conexion = new OleDbConnection();
                conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\aleja\Desktop\RegistroMédico.accdb;Persist Security Info=False;";
                conexion.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO RegistroDoctores (NombreCompleto, Sexo, NúmeroDeLicencia, EspecialidadMedica, Notas, FechaDeIngreso, DuracciónDeConsulta, ResultadoDePruebasExamenes, Diagnóstico, InformaciónSobreMedicamentos) VALUES (@NombreCompleto, @Sexo, @NumeroDeLicencia, @EspecialidadMedica, @Notas, @FechaDeIngreso, @DuraccionDeConsulta, @ResultadoDePruebasExamenes, @Diagnostico, @InformacionSobreMedicamentos)";

                comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                comando.Parameters.AddWithValue("@Sexo", Sexo);
                comando.Parameters.AddWithValue("@NumeroDeLicencia", NumeroDeLicencia);
                comando.Parameters.AddWithValue("@EspecialidadMedica", EspecialidadMedica);
                comando.Parameters.AddWithValue("@Notas", Notas);
                comando.Parameters.AddWithValue("@FechaDeIngreso", FechaDeIngreso);
                comando.Parameters.AddWithValue("@DuraccionDeConsulta", DuraccionDeConsulta);
                comando.Parameters.AddWithValue("@ResultadoDePruebasExamenes", ResultadoDePruebasExamenes);
                comando.Parameters.AddWithValue("@Diagnostico", Diagnostico);
                comando.Parameters.AddWithValue("@InformacionSobreMedicamentos", InformacionSobreMedicamentos);
                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }
        private void Crear_Registro_Doctor_Load(object sender, EventArgs e)
        {

        }
    }
}
