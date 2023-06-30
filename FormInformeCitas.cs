using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class FormInformeCitas : Form
    {
        public FormInformeCitas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Elija donde guardar el informe";
            saveFileDialog.DefaultExt = ".pdf";
            saveFileDialog.ShowDialog();
            
            GenerarPDF(dateTimePicker1.Value, saveFileDialog.FileName);
        }

        public void GenerarPDF(DateTime fecha, string path)
        {
            // Conexión a la base de datos
            string connectionString = Constantes.stringConexion;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Consulta SQL para recuperar los datos necesarios
            string query = "SELECT p.NroDocumento, p.Nombre, p.NroTelefono, p.Email, c.Motivo FROM Cita c INNER JOIN Paciente p ON p.Id = c.IdPaciente WHERE CAST(FechaCita AS DATE) = CAST(@FechaCita AS DATE)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FechaCita", fecha);
            SqlDataReader reader = command.ExecuteReader();

            // Crear el documento PDF
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
            document.Open();

            // Crear el titulo del PDF
            Paragraph title = new Paragraph();
            title.Alignment = Element.ALIGN_CENTER;
            title.Font = FontFactory.GetFont("Arial", 24);
            title.Add("\nFecha: " + fecha.ToString() + "\n\n\n");
            document.Add(title);

            // Agregar los datos recuperados a la planilla
            PdfPTable table = new PdfPTable(5);
            table.AddCell("DNI");
            table.AddCell("Nombre");
            table.AddCell("Telefono");
            table.AddCell("Email");
            table.AddCell("Motivo");

            while (reader.Read())
            {
                table.AddCell(reader.GetInt32(0).ToString());
                table.AddCell(reader.GetString(1));
                table.AddCell(reader.GetInt64(2).ToString());
                table.AddCell(reader.GetString(3));
                table.AddCell(reader.GetString(4));
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
