using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class FormModificaPaciente : Form
    {
        private FormRegistro sender;
        int idPaciente;
        public FormModificaPaciente(FormRegistro sender, int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
            this.sender = sender;
            SetDefaultValues();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query =
                    "UPDATE Paciente" +
                    "SET " +
                    "NroDocumento = @NroDocumento, " +
                    "Nombre = @Nombre, " +
                    "FechaNacimiento = @FechaNacimiento, " +
                    "Genero = @Genero, " +
                    "Direccion = @Direccion, " +
                    "NroTelefono = @NroTelefono, " +
                    "Email = @Email;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", textBox1.Text);
                cmd.Parameters.AddWithValue("@NroDocumento", Convert.ToInt32(textBox2.Text));
                cmd.Parameters.AddWithValue("@FechaNacimiento", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Genero", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Direccion", textBox3.Text);
                cmd.Parameters.AddWithValue("@NroTelefono", textBox4.Text);
                cmd.Parameters.AddWithValue("@Email", textBox5.Text);

                SqlDataAdapter adapter = new SqlDataAdapter();
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.sender.UpdateDataGridView();
            this.Dispose();
        }

        private void SetDefaultValues()
        {
            DataTable dt;
            using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query =
                    "SELECT TOP 1 * FROM Paciente WHERE ID = @IdPaciente";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                IDataRecord record = reader as IDataRecord;

                label9.Text = record[0].ToString();
                textBox1.Text = record[1].ToString();
                textBox2.Text = record[2].ToString();
                dateTimePicker1.Value = (DateTime)record[3];
                comboBox1.Text = (string) record[4];
                textBox3.Text = (string)record[5];
                textBox4.Text = record[6].ToString();
                textBox5.Text = record[7].ToString();
                reader.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
