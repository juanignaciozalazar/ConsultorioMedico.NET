using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    
    public partial class FormRegistro : Form
    {
        string pathRepo;
        private string stringConexion;
        FormAgregaPaciente formAgregaPaciente;
        FormModificaPaciente formModificaPaciente;
        public FormRegistro()
        {
            pathRepo = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            stringConexion = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={pathRepo}\Database1.mdf;Integrated Security=True"; 
            InitializeComponent();
            UpdateDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            formAgregaPaciente = new FormAgregaPaciente(this);
            formAgregaPaciente.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());

            using (SqlConnection connection = new SqlConnection(Constantes.stringConexion))
            {
                string query = "DELETE FROM Paciente WHERE Id = @IdPaciente";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdPaciente", id);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            UpdateDataGridView();
        }

        public void UpdateDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(stringConexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Paciente", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                this.dataGridView1.DataSource = table;
            }
            dataGridView1.Update(); dataGridView1.Refresh();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            this.formModificaPaciente = new FormModificaPaciente(this, id);
            this.formModificaPaciente.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
