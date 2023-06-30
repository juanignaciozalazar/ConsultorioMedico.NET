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
    public partial class FormAgregaHistoria : Form
    {
        FormHistoriaClinica sender;
        int idPaciente;
        public FormAgregaHistoria(FormHistoriaClinica sender, int idPaciente)
        {
            this.sender = sender;
            this.idPaciente = idPaciente;
            InitializeComponent();
            initDefaultValues();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query =
                    "INSERT INTO HistoriaClinica (IdPaciente, FechaConsulta, Motivo, Detalle, EstudiosSolicitados, MedicacionSuministrada) " +
                    "VALUES (@IdPaciente, GETDATE(), @Motivo, @Detalle, @EstudiosSolicitados, @MedicacionSuministrada);";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@IdPaciente", this.idPaciente);
                cmd.Parameters.AddWithValue("@Motivo", richTextBox1.Text) ;
                cmd.Parameters.AddWithValue("@Detalle", richTextBox2.Text);
                cmd.Parameters.AddWithValue("@EstudiosSolicitados", richTextBox3.Text);
                cmd.Parameters.AddWithValue("@MedicacionSuministrada", richTextBox4.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            this.sender.UpdateHistoriaGridView();
            this.Dispose();
        }

        private void initDefaultValues()
        {
            using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query =
                    "SELECT Nombre, NroDocumento FROM Paciente WHERE Id = @idPaciente;";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@idPaciente", this.idPaciente);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                IDataRecord record = reader as IDataRecord;

                label8.Text = (string)reader[0];
                label7.Text = reader[1].ToString();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
