using iTextSharp.text;
using iTextSharp.text.pdf;
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
using System.Xml.Linq;

namespace ConsultorioMedico
{
    public partial class FormInformeHistoria : Form
    {
        string rutaGuardar;
        public FormInformeHistoria()
        {
            InitializeComponent();
            initDataGrid();
        }

        private void initDataGrid()
        {
            using (SqlConnection connection = new SqlConnection (Constantes.stringConexion))
            {
                string query =
                    "SELECT * FROM Paciente";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                this.dataGridView1.DataSource = table;
                this.dataGridView1.Refresh();
            }
        }

        private int getSelectedPersonId()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            return id;
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Elija donde guardar el informe";
            saveFileDialog.DefaultExt = ".pdf";
            saveFileDialog.ShowDialog();
            rutaGuardar = saveFileDialog.FileName;
            GenerarPDF(getSelectedPersonId(), rutaGuardar);
        }
        public void GenerarPDF(int idPaciente, string path)
        {
            // Conexión a la base de datos
            string connectionString = Constantes.stringConexion;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Consulta SQL para recuperar los datos necesarios
            string query = "SELECT p.Nombre, h.FechaConsulta, h.Motivo, h.Detalle, h.EstudiosSolicitados, h.MedicacionSuministrada FROM HistoriaClinica h INNER JOIN Paciente p ON p.Id = h.IdPaciente WHERE IdPaciente = @IdPaciente";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdPaciente", idPaciente);
            SqlDataReader reader = command.ExecuteReader();

            // Crear el documento PDF
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
            document.Open();

            // Agregar los datos recuperados a la planilla
            PdfPTable table = new PdfPTable(6);
            table.AddCell("Nombre");
            table.AddCell("Fecha de Consulta");
            table.AddCell("Motivo");
            table.AddCell("Detalle");
            table.AddCell("EstudiosSolicitados");
            table.AddCell("MedicacionSuministrada");

            while (reader.Read())
            {
                table.AddCell(reader.GetString(0));
                table.AddCell(reader.GetDateTime(1).ToString());
                table.AddCell(reader.GetString(2));
                table.AddCell(reader.GetString(3));
                table.AddCell(reader.GetString(4));
                table.AddCell(reader.GetString(5));
            }

            // Agregar la planilla al documento PDF
            document.Add(table);

            // Cerrar la conexión y guardar el archivo PDF
            reader.Close();
            connection.Close();
            document.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
