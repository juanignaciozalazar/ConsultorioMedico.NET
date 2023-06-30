namespace ConsultorioMedico
{
    partial class FormAgenda
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
            this.PersonaGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.CitasGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistroPersonas = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.buttonActualizarCitas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CitasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonaGridView
            // 
            this.PersonaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonaGridView.Location = new System.Drawing.Point(58, 68);
            this.PersonaGridView.Name = "PersonaGridView";
            this.PersonaGridView.RowTemplate.Height = 24;
            this.PersonaGridView.Size = new System.Drawing.Size(388, 334);
            this.PersonaGridView.TabIndex = 0;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 492);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 65);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSalir.Location = new System.Drawing.Point(693, 3);
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
            this.buttonEliminar.Location = new System.Drawing.Point(463, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(224, 59);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonModificar.Location = new System.Drawing.Point(233, 3);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(224, 59);
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
            this.buttonAgregar.Size = new System.Drawing.Size(224, 59);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // CitasGridView
            // 
            this.CitasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CitasGridView.Location = new System.Drawing.Point(463, 68);
            this.CitasGridView.Name = "CitasGridView";
            this.CitasGridView.RowTemplate.Height = 24;
            this.CitasGridView.Size = new System.Drawing.Size(400, 334);
            this.CitasGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Citas";
            // 
            // buttonRegistroPersonas
            // 
            this.buttonRegistroPersonas.Location = new System.Drawing.Point(84, 417);
            this.buttonRegistroPersonas.Name = "buttonRegistroPersonas";
            this.buttonRegistroPersonas.Size = new System.Drawing.Size(163, 36);
            this.buttonRegistroPersonas.TabIndex = 5;
            this.buttonRegistroPersonas.Text = "Registro de personas";
            this.buttonRegistroPersonas.UseVisualStyleBackColor = true;
            this.buttonRegistroPersonas.Click += new System.EventHandler(this.buttonRegistroPersonas_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(289, 417);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(126, 36);
            this.Actualizar.TabIndex = 6;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // buttonActualizarCitas
            // 
            this.buttonActualizarCitas.Location = new System.Drawing.Point(620, 417);
            this.buttonActualizarCitas.Name = "buttonActualizarCitas";
            this.buttonActualizarCitas.Size = new System.Drawing.Size(126, 36);
            this.buttonActualizarCitas.TabIndex = 7;
            this.buttonActualizarCitas.Text = "Actualizar";
            this.buttonActualizarCitas.UseVisualStyleBackColor = true;
            this.buttonActualizarCitas.Click += new System.EventHandler(this.buttonActualizarCitas_Click);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 557);
            this.Controls.Add(this.buttonActualizarCitas);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.buttonRegistroPersonas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CitasGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PersonaGridView);
            this.Name = "FormAgenda";
            this.Text = "Agenda de citas";
            ((System.ComponentModel.ISupportInitialize)(this.PersonaGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CitasGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonaGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView CitasGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegistroPersonas;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button buttonActualizarCitas;
    }
}