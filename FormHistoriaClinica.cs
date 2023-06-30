using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class FormHistoriaClinica : Form
    {
        public FormHistoriaClinica()
        {
            InitializeComponent();
            UpdatePersonasGridView();
        }

        FormRegistro formRegistro;
        FormAgregaHistoria formAgregaHistoria;
        FormModificaHistoria formModificaHistoria;
        int idPaciente;
        

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            this.formAgregaHistoria = new FormAgregaHistoria(this, getSelectedPersonId());
            this.formAgregaHistoria.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (getSelectedHistoriaId() != 0)
            {
                this.formModificaHistoria = new FormModificaHistoria(this, getSelectedHistoriaId());
                this.formModificaHistoria.ShowDialog();
            }
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int IdHistoria = getSelectedHistoriaId();
            if (IdHistoria != 0)
            {
                using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
                {
                    string query =
                        "DELETE FROM HistoriaClinica WHERE Id = @IdHistoria;";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@IdHistoria", IdHistoria);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            UpdateHistoriaGridView();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void UpdatePersonasGridView()
        {
            using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query =
                    "SELECT Id, NroDocumento, Nombre FROM Paciente";
                SqlCommand cmd = new SqlCommand(query, connection);

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);

                this.PersonaGridView.DataSource = dt;
            }
            PersonaGridView.Update(); PersonaGridView.Refresh();
        }

        public void UpdateHistoriaGridView()
        {
            using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query =
                    "SELECT Id, FechaConsulta, Motivo, Detalle, EstudiosSolicitados, MedicacionSuministrada FROM HistoriaClinica WHERE IdPaciente = @IdPaciente ORDER BY FechaConsulta DESC";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@IdPaciente", getSelectedPersonId());
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);

                this.HistoriaGridView.DataSource = dt;
            }
            PersonaGridView.Update(); PersonaGridView.Refresh();
        }

        private int getSelectedPersonId()
        {
            int rowIndex = PersonaGridView.CurrentCell.RowIndex;
            int id = Convert.ToInt32(PersonaGridView.Rows[rowIndex].Cells[0].Value.ToString());
            return id;
        }

        private int getSelectedHistoriaId()
        {
            int id = 0;
            if (HistoriaGridView.CurrentCell != null)
            {
                int rowIndex = HistoriaGridView.CurrentCell.RowIndex;
                id = Convert.ToInt32(HistoriaGridView.Rows[rowIndex].Cells[0].Value.ToString());
            }
            return id;
        }

        private void buttonRegistroPersonas_Click(object sender, EventArgs e)
        {
            this.formRegistro = new FormRegistro();
            formRegistro.ShowDialog();
        }

        private void buttonActualizarPersona_Click(object sender, EventArgs e)
        {
            UpdatePersonasGridView();
        }

        private void buttonActualizarHistoria_Click(object sender, EventArgs e)
        {
            UpdateHistoriaGridView();
        }
    }
}
