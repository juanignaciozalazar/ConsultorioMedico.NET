using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsultorioMedico
{
    public partial class FormAgregaCita : Form
    {
        int idPaciente;
        public FormAgregaCita(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
            initDefaultValues();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query =
                    "INSERT INTO Cita (IdPaciente, FechaCita, Motivo) VALUES (@IdPaciente, @FechaCita, @Motivo);";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                cmd.Parameters.AddWithValue("@FechaCita", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Motivo", richTextBox1.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            this.Dispose();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void initDefaultValues()
        {
            using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query =
                    "SELECT TOP 1 Nombre, NroDocumento FROM Paciente WHERE Id = @IdPaciente";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                IDataRecord record = reader as IDataRecord;

                labelNombre.Text = record[0].ToString();
                labelDNI.Text = record[1].ToString();
                
                reader.Close();

            }
        }

        
    }
}
