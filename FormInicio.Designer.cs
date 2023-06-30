namespace ConsultorioMedico
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.buttonAgenda = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonInformeHistoria = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonInformeCitas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRegistro.Location = new System.Drawing.Point(15, 15);
            this.buttonRegistro.Margin = new System.Windows.Forms.Padding(15);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(107, 84);
            this.buttonRegistro.TabIndex = 0;
            this.buttonRegistro.Text = "Registro Pacientes";
            this.buttonRegistro.UseVisualStyleBackColor = true;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click);
            // 
            // buttonAgenda
            // 
            this.buttonAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAgenda.Location = new System.Drawing.Point(152, 15);
            this.buttonAgenda.Margin = new System.Windows.Forms.Padding(15);
            this.buttonAgenda.Name = "buttonAgenda";
            this.buttonAgenda.Size = new System.Drawing.Size(107, 84);
            this.buttonAgenda.TabIndex = 1;
            this.buttonAgenda.Text = "Agenda de Citas";
            this.buttonAgenda.UseVisualStyleBackColor = true;
            this.buttonAgenda.Click += new System.EventHandler(this.buttonAgenda_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonRegistro, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonInformeHistoria, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAgenda, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonInformeCitas, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 252);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 114);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonInformeHistoria
            // 
            this.buttonInformeHistoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInformeHistoria.Location = new System.Drawing.Point(426, 15);
            this.buttonInformeHistoria.Margin = new System.Windows.Forms.Padding(15);
            this.buttonInformeHistoria.Name = "buttonInformeHistoria";
            this.buttonInformeHistoria.Size = new System.Drawing.Size(107, 84);
            this.buttonInformeHistoria.TabIndex = 3;
            this.buttonInformeHistoria.Text = "Informe Historia Clinica";
            this.buttonInformeHistoria.UseVisualStyleBackColor = true;
            this.buttonInformeHistoria.Click += new System.EventHandler(this.buttonInformeHistoria_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(289, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 84);
            this.button3.TabIndex = 2;
            this.button3.Text = "Historia Clínica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonHistoriaClinica_Click);
            // 
            // buttonInformeCitas
            // 
            this.buttonInformeCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInformeCitas.Location = new System.Drawing.Point(563, 15);
            this.buttonInformeCitas.Margin = new System.Windows.Forms.Padding(15);
            this.buttonInformeCitas.Name = "buttonInformeCitas";
            this.buttonInformeCitas.Size = new System.Drawing.Size(111, 84);
            this.buttonInformeCitas.TabIndex = 4;
            this.buttonInformeCitas.Text = "Citas del dia";
            this.buttonInformeCitas.UseVisualStyleBackColor = true;
            this.buttonInformeCitas.Click += new System.EventHandler(this.buttonInformeCitas_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormInicio";
            this.Text = "Consultorio Médico";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistro;
        private System.Windows.Forms.Button buttonAgenda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonInformeHistoria;
        private System.Windows.Forms.Button buttonInformeCitas;
    }
}

