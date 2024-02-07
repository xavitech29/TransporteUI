namespace UI.Windows.Formularios
{
    partial class FrmRuta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdRuta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbGuardarRuta = new System.Windows.Forms.PictureBox();
            this.dateTimePickerFechaRuta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLlegada = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtNombreRuta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListarRutas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Ruta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtIdRuta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pbGuardarRuta);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaRuta);
            this.groupBox1.Controls.Add(this.dateTimePickerLlegada);
            this.groupBox1.Controls.Add(this.dateTimePickerSalida);
            this.groupBox1.Controls.Add(this.txtCapacidad);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.txtOrigen);
            this.groupBox1.Controls.Add(this.txtNombreRuta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtIdRuta
            // 
            this.txtIdRuta.Enabled = false;
            this.txtIdRuta.Location = new System.Drawing.Point(218, 42);
            this.txtIdRuta.Name = "txtIdRuta";
            this.txtIdRuta.Size = new System.Drawing.Size(100, 20);
            this.txtIdRuta.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Codigo";
            // 
            // pbGuardarRuta
            // 
            this.pbGuardarRuta.Image = global::UI.Windows.Properties.Resources.guardar1;
            this.pbGuardarRuta.Location = new System.Drawing.Point(353, 19);
            this.pbGuardarRuta.Name = "pbGuardarRuta";
            this.pbGuardarRuta.Size = new System.Drawing.Size(44, 44);
            this.pbGuardarRuta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuardarRuta.TabIndex = 18;
            this.pbGuardarRuta.TabStop = false;
            this.pbGuardarRuta.Click += new System.EventHandler(this.pbGuardarRuta_Click);
            // 
            // dateTimePickerFechaRuta
            // 
            this.dateTimePickerFechaRuta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaRuta.Location = new System.Drawing.Point(92, 158);
            this.dateTimePickerFechaRuta.Name = "dateTimePickerFechaRuta";
            this.dateTimePickerFechaRuta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaRuta.TabIndex = 17;
            this.dateTimePickerFechaRuta.Value = new System.DateTime(2024, 1, 30, 0, 0, 0, 0);
            // 
            // dateTimePickerLlegada
            // 
            this.dateTimePickerLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerLlegada.Location = new System.Drawing.Point(91, 126);
            this.dateTimePickerLlegada.Name = "dateTimePickerLlegada";
            this.dateTimePickerLlegada.ShowUpDown = true;
            this.dateTimePickerLlegada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLlegada.TabIndex = 16;
            this.dateTimePickerLlegada.Value = new System.DateTime(2024, 1, 30, 19, 3, 0, 0);
            // 
            // dateTimePickerSalida
            // 
            this.dateTimePickerSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerSalida.Location = new System.Drawing.Point(92, 97);
            this.dateTimePickerSalida.Name = "dateTimePickerSalida";
            this.dateTimePickerSalida.ShowUpDown = true;
            this.dateTimePickerSalida.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSalida.TabIndex = 15;
            this.dateTimePickerSalida.Value = new System.DateTime(2024, 1, 30, 19, 3, 0, 0);
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(92, 188);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidad.TabIndex = 13;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(92, 70);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 9;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(92, 43);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtOrigen.TabIndex = 8;
            // 
            // txtNombreRuta
            // 
            this.txtNombreRuta.Location = new System.Drawing.Point(92, 13);
            this.txtNombreRuta.Name = "txtNombreRuta";
            this.txtNombreRuta.Size = new System.Drawing.Size(100, 20);
            this.txtNombreRuta.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Capacidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Ruta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora LLegada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen";
            // 
            // dgvListarRutas
            // 
            this.dgvListarRutas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListarRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarRutas.Location = new System.Drawing.Point(31, 270);
            this.dgvListarRutas.Name = "dgvListarRutas";
            this.dgvListarRutas.Size = new System.Drawing.Size(746, 150);
            this.dgvListarRutas.TabIndex = 2;
            this.dgvListarRutas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarRutas_CellMouseDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(343, 87);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListarRutas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmRuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRuta";
            this.Load += new System.EventHandler(this.FrmRuta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardarRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarRutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtNombreRuta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListarRutas;
        private System.Windows.Forms.DateTimePicker dateTimePickerLlegada;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalida;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaRuta;
        private System.Windows.Forms.PictureBox pbGuardarRuta;
        private System.Windows.Forms.TextBox txtIdRuta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
    }
}