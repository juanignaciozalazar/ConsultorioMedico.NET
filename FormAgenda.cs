using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class FormAgenda : Form
    {
        FormRegistro formRegistro;
        FormAgregaCita formAgregaCita;
        FormModificaCita formModificaCita;
        int idPaciente;
        public FormAgenda()
        {
            InitializeComponent();
            UpdatePersonasGridView();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            this.formAgregaCita = new FormAgregaCita(getSelectedPersonId());
            this.formAgregaCita.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            this.formModificaCita = new FormModificaCita(getSelectedCitaId());
            this.formModificaCita.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query =
                    "DELETE FROM Cita WHERE Id = @IdCita;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdCita", getSelectedCitaId());
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            UpdateCitasGridView();
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

        public void UpdateCitasGridView()
        {
            using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query =
                    "SELECT Id, FechaCita, Motivo FROM Cita WHERE IdPaciente = @IdPaciente ORDER BY FechaCita DESC";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@IdPaciente", getSelectedPersonId());
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);

                this.CitasGridView.DataSource = dt;
            }
            PersonaGridView.Update(); PersonaGridView.Refresh();
        }

        private int getSelectedPersonId()
        {
            int rowIndex = PersonaGridView.CurrentCell.RowIndex;
            int id = Convert.ToInt32(PersonaGridView.Rows[rowIndex].Cells[0].Value.ToString());
            return id;
        }

        private int getSelectedCitaId()
        {
            int id = 0;
            if (CitasGridView.CurrentCell != null) {
                int rowIndex = CitasGridView.CurrentCell.RowIndex;
                id = Convert.ToInt32(CitasGridView.Rows[rowIndex].Cells[0].Value.ToString());
            }
            return id;
        }

        private void buttonRegistroPersonas_Click(object sender, EventArgs e)
        {
            this.formRegistro = new FormRegistro();
            formRegistro.ShowDialog();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            UpdatePersonasGridView();
        }

        private void buttonActualizarCitas_Click(object sender, EventArgs e)
        {
            UpdateCitasGridView();
        }
    }
}
