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
    public partial class FormAgregaPaciente : Form
    {
        FormRegistro sender;
        public FormAgregaPaciente(FormRegistro sender)
        {
            InitializeComponent();
            this.sender = sender;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query = "INSERT INTO Paciente (NroDocumento, Nombre, FechaNacimiento, Genero, Direccion, NroTelefono, Email) " +
                                "VALUES (@NroDocumento, @Nombre,  @FechaNacimiento, @Genero, @Direccion, @NroTelefono, @Email); ";
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
