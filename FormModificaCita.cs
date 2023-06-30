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
    public partial class FormModificaCita : Form
    {
        int idCita;
        int idPaciente;
        public FormModificaCita(int idCita)
        {
            InitializeComponent();
            this.idCita = idCita;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query =
                    "UPDATE Cita " +
                    "SET " +
                    "IdPaciente = @IdPaciente" +
                    "FechaCita = @FechaCita" +
                    "Motivo = @Motivo" +
                    "WHERE Id = @CitaId";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@IdPaciente", idPaciente);
                cmd.Parameters.AddWithValue("@FechaCita", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Motivo", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@CitaId", idCita);
            }
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
                    "SELECT TOP 1 p.Nombre, p.NroDocumento, p.Id FROM Paciente p INNER JOIN Cita c ON p.Id = c.PersonaId WHERE c.Id = @IdCita";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdCita", idCita);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                IDataRecord record = reader as IDataRecord;

                
                labelNombre.Text = record[0].ToString();
                labelDNI.Text = record[1].ToString();
                this.idPaciente = (int)record[2];
                reader.Close();

            }
        }
    }
}
