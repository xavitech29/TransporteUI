namespace UI.Windows.Formularios
{
    partial class FrmHistorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerHistorial = new System.Windows.Forms.DateTimePicker();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.cboRuta = new System.Windows.Forms.ComboBox();
            this.cboEstudiante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdHistorial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbGuardarHistorial = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Reserva";
            // 
            // dateTimePickerHistorial
            // 
            this.dateTimePickerHistorial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHistorial.Location = new System.Drawing.Point(92, 16);
            this.dateTimePickerHistorial.Name = "dateTimePickerHistorial";
            this.dateTimePickerHistorial.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHistorial.TabIndex = 1;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(12, 184);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(776, 150);
            this.dgvHistorial.TabIndex = 3;
            this.dgvHistorial.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHistorial_CellMouseDoubleClick);
            // 
            // cboRuta
            // 
            this.cboRuta.FormattingEnabled = true;
            this.cboRuta.Location = new System.Drawing.Point(92, 58);
            this.cboRuta.Name = "cboRuta";
            this.cboRuta.Size = new System.Drawing.Size(121, 21);
            this.cboRuta.TabIndex = 4;
            // 
            // cboEstudiante
            // 
            this.cboEstudiante.FormattingEnabled = true;
            this.cboEstudiante.Location = new System.Drawing.Point(92, 107);
            this.cboEstudiante.Name = "cboEstudiante";
            this.cboEstudiante.Size = new System.Drawing.Size(121, 21);
            this.cboEstudiante.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ruta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estudiante:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtIdHistorial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pbGuardarHistorial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboEstudiante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerHistorial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboRuta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 149);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtIdHistorial
            // 
            this.txtIdHistorial.Enabled = false;
            this.txtIdHistorial.Location = new System.Drawing.Point(362, 20);
            this.txtIdHistorial.Name = "txtIdHistorial";
            this.txtIdHistorial.Size = new System.Drawing.Size(100, 20);
            this.txtIdHistorial.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codigo";
            // 
            // pbGuardarHistorial
            // 
            this.pbGuardarHistorial.Image = global::UI.Windows.Properties.Resources.guardar1;
            this.pbGuardarHistorial.Location = new System.Drawing.Point(481, 43);
            this.pbGuardarHistorial.Name = "pbGuardarHistorial";
            this.pbGuardarHistorial.Size = new System.Drawing.Size(40, 36);
            this.pbGuardarHistorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardarHistorial.TabIndex = 8;
            this.pbGuardarHistorial.TabStop = false;
            this.pbGuardarHistorial.Click += new System.EventHandler(this.pbGuardarHistorial_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(457, 107);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistorial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.ComboBox cboRuta;
        private System.Windows.Forms.ComboBox cboEstudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbGuardarHistorial;
        private System.Windows.Forms.TextBox txtIdHistorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
    }
}