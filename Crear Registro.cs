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
    public partial class Crear_Registro : Form
    {
        public string NombreCompleto { get; set; }
        public string Sexo { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Direccion { get; set; }
        public int NumeroDeTelefono { get; set; }
        public string SeguroMedico { get; set; }
        public string EstadoCivil { get; set; }
        public string Alergias { get; set; }
        public string MedicamentosRecetados { get; set; }
        public string AntecedentesDeEnfermedadesFamiliares { get; set; }
        public string EstadoDeVidaHabitos { get; set; }
        public string InformacionDeContactoDeEmergencia { get; set; }
        public string VacunasInmunizaciones { get; set; }
        public string InformacionRelevante { get; set; }
        public Crear_Registro()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conexion = new OleDbConnection();
                conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\aleja\Desktop\RegistroMédico.accdb;Persist Security Info=False;";
                conexion.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO RegistroPacientes(NombreCompleto, Sexo, FechaDeNacimiento, Dirección, NúmeroDeTeléfono, SeguroMédico, EstadoCivil, Alergias, MedicamentosRecetados, AntecedentesDeEnfermedadesFamiliares, EstadoDeVidaHabitos, InformacionDeContactoDeEmergencia, VacunasInmunizaciones, InformacionRelevante) VALUES (@NombreCompleto, @Sexo, @FechaDeNacimiento, @Direccion, @NumeroDeTelefono, @SeguroMedico, @EstadoCivil, @Alergias, @MedicamentosRecetados, @AntecedentesDeEnfermedadesFamiliares, @EstadoDeVidaHabitos, @InformacionDeContactoDeEmergencia, @VacunasInmunizaciones, @InformacionRelevante)";
                comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                comando.Parameters.AddWithValue("@Sexo", Sexo);
                comando.Parameters.AddWithValue("@FechaDeNacimiento", FechaDeNacimiento);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@NumeroDeTelefono", NumeroDeTelefono);
                comando.Parameters.AddWithValue("@SeguroMedico", SeguroMedico);
                comando.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
                comando.Parameters.AddWithValue("@Alergias", Alergias);
                comando.Parameters.AddWithValue("@MedicamentosRecetados", MedicamentosRecetados);
                comando.Parameters.AddWithValue("@AntecedentesDeEnfermedadesFamiliares", AntecedentesDeEnfermedadesFamiliares);
                comando.Parameters.AddWithValue("@EstadoDeVidaHabitos", EstadoDeVidaHabitos);
                comando.Parameters.AddWithValue("@InformacionDeContactoDeEmergencia", InformacionDeContactoDeEmergencia);
                comando.Parameters.AddWithValue("@VacunasInmunizaciones", VacunasInmunizaciones);
                comando.Parameters.AddWithValue("@InformacionRelevante", InformacionRelevante);
                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show($"Error {er}");
            }
            Crear_Registro_Doctor ventana = new Crear_Registro_Doctor();
            ventana.Show();

            this.Hide();
        }

        private void Crear_Registro_Load(object sender, EventArgs e)
        {
        }
    }
}
