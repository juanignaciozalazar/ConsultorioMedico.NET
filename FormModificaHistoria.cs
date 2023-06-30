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
    public partial class FormModificaHistoria : Form
    {
        FormHistoriaClinica sender;
        int idPaciente;
        public FormModificaHistoria(FormHistoriaClinica sender, int idPaciente)
        {
            this.sender = sender;
            this.idPaciente = idPaciente;
            InitializeComponent();
            initDefaultValues();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

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
    }
}
