namespace ConsultorioMedico
{
    partial class FormHistoriaClinica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonActualizarHistoria = new System.Windows.Forms.Button();
            this.buttonActualizarPersona = new System.Windows.Forms.Button();
            this.buttonRegistroPersonas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HistoriaGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.PersonaGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.HistoriaGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonActualizarHistoria
            // 
            this.buttonActualizarHistoria.Location = new System.Drawing.Point(620, 404);
            this.buttonActualizarHistoria.Name = "buttonActualizarHistoria";
            this.buttonActualizarHistoria.Size = new System.Drawing.Size(126, 36);
            this.buttonActualizarHistoria.TabIndex = 15;
            this.buttonActualizarHistoria.Text = "Actualizar";
            this.buttonActualizarHistoria.UseVisualStyleBackColor = true;
            this.buttonActualizarHistoria.Click += new System.EventHandler(this.buttonActualizarHistoria_Click);
            // 
            // buttonActualizarPersona
            // 
            this.buttonActualizarPersona.Location = new System.Drawing.Point(289, 404);
            this.buttonActualizarPersona.Name = "buttonActualizarPersona";
            this.buttonActualizarPersona.Size = new System.Drawing.Size(126, 36);
            this.buttonActualizarPersona.TabIndex = 14;
            this.buttonActualizarPersona.Text = "Actualizar";
            this.buttonActualizarPersona.UseVisualStyleBackColor = true;
            this.buttonActualizarPersona.Click += new System.EventHandler(this.buttonActualizarPersona_Click);
            // 
            // buttonRegistroPersonas
            // 
            this.buttonRegistroPersonas.Location = new System.Drawing.Point(84, 404);
            this.buttonRegistroPersonas.Name = "buttonRegistroPersonas";
            this.buttonRegistroPersonas.Size = new System.Drawing.Size(163, 36);
            this.buttonRegistroPersonas.TabIndex = 13;
            this.buttonRegistroPersonas.Text = "Registro de personas";
            this.buttonRegistroPersonas.UseVisualStyleBackColor = true;
            this.buttonRegistroPersonas.Click += new System.EventHandler(this.buttonRegistroPersonas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Historia Clinica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pacientes";
            // 
            // HistoriaGridView
            // 
            this.HistoriaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoriaGridView.Location = new System.Drawing.Point(463, 55);
            this.HistoriaGridView.Name = "HistoriaGridView";
            this.HistoriaGridView.RowTemplate.Height = 24;
            this.HistoriaGridView.Size = new System.Drawing.Size(400, 334);
            this.HistoriaGridView.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSalir, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonEliminar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonModificar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAgregar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 472);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 65);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSalir.Location = new System.Drawing.Point(690, 3);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(224, 59);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEliminar.Location = new System.Drawing.Point(461, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(223, 59);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonModificar.Location = new System.Drawing.Point(232, 3);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(223, 59);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAgregar.Location = new System.Drawing.Point(3, 3);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(223, 59);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // PersonaGridView
            // 
            this.PersonaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonaGridView.Location = new System.Drawing.Point(58, 55);
            this.PersonaGridView.Name = "PersonaGridView";
            this.PersonaGridView.RowTemplate.Height = 24;
            this.PersonaGridView.Size = new System.Drawing.Size(388, 334);
            this.PersonaGridView.TabIndex = 8;
            // 
            // FormHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 537);
            this.Controls.Add(this.buttonActualizarHistoria);
            this.Controls.Add(this.buttonActualizarPersona);
            this.Controls.Add(this.buttonRegistroPersonas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HistoriaGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PersonaGridView);
            this.Name = "FormHistoriaClinica";
            this.Text = "FormHistoriaClinica";
            ((System.ComponentModel.ISupportInitialize)(this.HistoriaGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonActualizarHistoria;
        private System.Windows.Forms.Button buttonActualizarPersona;
        private System.Windows.Forms.Button buttonRegistroPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView HistoriaGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView PersonaGridView;
    }
}