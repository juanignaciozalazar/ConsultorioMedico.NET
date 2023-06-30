using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class FormInicio : Form
    {
        FormRegistro formRegistro;
        FormAgenda formAgenda;
        FormHistoriaClinica formHistoriaClinica;
        FormInformeHistoria formInformeHistoria;
        FormInformeCitas formInformeCitas;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            this.formRegistro = new FormRegistro();
            this.formRegistro.ShowDialog();
        }

        private void buttonAgenda_Click(object sender, EventArgs e)
        {
            this.formAgenda = new FormAgenda();
            this.formAgenda.ShowDialog();
        }

        private void buttonHistoriaClinica_Click(object sender, EventArgs e)
        {
            this.formHistoriaClinica = new FormHistoriaClinica();
            this.formHistoriaClinica.ShowDialog();
        }

        private void buttonInformeHistoria_Click(object sender, EventArgs e)
        {
             this.formInformeHistoria = new FormInformeHistoria();
            this.formInformeHistoria.ShowDialog();
        }

        private void buttonInformeCitas_Click(object sender, EventArgs e)
        {
            this.formInformeCitas = new FormInformeCitas();
            this.formInformeCitas.ShowDialog();
        }
    }
}
