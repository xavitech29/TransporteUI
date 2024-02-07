namespace UI.Windows.Formularios
{
    partial class FrmReserva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbGuardarReserva = new System.Windows.Forms.PictureBox();
            this.cboReservaVehiculo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboReservaRuta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboReservaEstudiante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEstadoReserva = new System.Windows.Forms.CheckBox();
            this.dateTimePickerHoraReserva = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.dgvListarReserva = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.pbGuardarReserva);
            this.groupBox1.Controls.Add(this.cboReservaVehiculo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIdReserva);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboReservaRuta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboReservaEstudiante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkEstadoReserva);
            this.groupBox1.Controls.Add(this.dateTimePickerHoraReserva);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaReserva);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pbGuardarReserva
            // 
            this.pbGuardarReserva.Image = global::UI.Windows.Properties.Resources.guardar1;
            this.pbGuardarReserva.Location = new System.Drawing.Point(653, 29);
            this.pbGuardarReserva.Name = "pbGuardarReserva";
            this.pbGuardarReserva.Size = new System.Drawing.Size(48, 48);
            this.pbGuardarReserva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardarReserva.TabIndex = 15;
            this.pbGuardarReserva.TabStop = false;
            this.pbGuardarReserva.Click += new System.EventHandler(this.pbGuardarReserva_Click);
            // 
            // cboReservaVehiculo
            // 
            this.cboReservaVehiculo.FormattingEnabled = true;
            this.cboReservaVehiculo.Location = new System.Drawing.Point(385, 86);
            this.cboReservaVehiculo.Name = "cboReservaVehiculo";
            this.cboReservaVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cboReservaVehiculo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vehiculo";
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Enabled = false;
            this.txtIdReserva.Location = new System.Drawing.Point(385, 39);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(100, 20);
            this.txtIdReserva.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Codigo";
            // 
            // cboReservaRuta
            // 
            this.cboReservaRuta.FormattingEnabled = true;
            this.cboReservaRuta.Location = new System.Drawing.Point(93, 169);
            this.cboReservaRuta.Name = "cboReservaRuta";
            this.cboReservaRuta.Size = new System.Drawing.Size(121, 21);
            this.cboReservaRuta.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ruta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estudiante";
            // 
            // cboReservaEstudiante
            // 
            this.cboReservaEstudiante.FormattingEnabled = true;
            this.cboReservaEstudiante.Location = new System.Drawing.Point(93, 131);
            this.cboReservaEstudiante.Name = "cboReservaEstudiante";
            this.cboReservaEstudiante.Size = new System.Drawing.Size(121, 21);
            this.cboReservaEstudiante.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora Reserva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Reserva";
            // 
            // chkEstadoReserva
            // 
            this.chkEstadoReserva.AutoSize = true;
            this.chkEstadoReserva.Location = new System.Drawing.Point(93, 204);
            this.chkEstadoReserva.Name = "chkEstadoReserva";
            this.chkEstadoReserva.Size = new System.Drawing.Size(59, 17);
            this.chkEstadoReserva.TabIndex = 2;
            this.chkEstadoReserva.Text = "Estado";
            this.chkEstadoReserva.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerHoraReserva
            // 
            this.dateTimePickerHoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraReserva.Location = new System.Drawing.Point(93, 88);
            this.dateTimePickerHoraReserva.Name = "dateTimePickerHoraReserva";
            this.dateTimePickerHoraReserva.ShowUpDown = true;
            this.dateTimePickerHoraReserva.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHoraReserva.TabIndex = 1;
            this.dateTimePickerHoraReserva.Value = new System.DateTime(2024, 1, 30, 19, 6, 0, 0);
            // 
            // dateTimePickerFechaReserva
            // 
            this.dateTimePickerFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaReserva.Location = new System.Drawing.Point(93, 39);
            this.dateTimePickerFechaReserva.Name = "dateTimePickerFechaReserva";
            this.dateTimePickerFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaReserva.TabIndex = 0;
            this.dateTimePickerFechaReserva.Value = new System.DateTime(2024, 1, 30, 0, 0, 0, 0);
            // 
            // dgvListarReserva
            // 
            this.dgvListarReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListarReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarReserva.Location = new System.Drawing.Point(13, 278);
            this.dgvListarReserva.Name = "dgvListarReserva";
            this.dgvListarReserva.Size = new System.Drawing.Size(762, 150);
            this.dgvListarReserva.TabIndex = 1;
            this.dgvListarReserva.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarReserva_CellMouseDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(646, 110);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListarReserva);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReserva";
            this.Load += new System.EventHandler(this.FrmReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEstadoReserva;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraReserva;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListarReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboReservaEstudiante;
        private System.Windows.Forms.ComboBox cboReservaRuta;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboReservaVehiculo;
        private System.Windows.Forms.PictureBox pbGuardarReserva;
        private System.Windows.Forms.Button btnEliminar;
    }
}