using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.ControladoresAplicacion;
using UI.Windows.VistaModelo;

namespace UI.Windows.Formularios
{
    public partial class FrmHistorial : Form
    {
        private HistorialControladorAplicacion historialControlador;
        private HistorialVistaModelo historialVistaModelo;
        private RutaControladorAplicacion rutaControladorAplicacion;
     
        private EstudianteControladorAplicacion estudianteControladorAplicacion;
        
        public FrmHistorial()
        {
            InitializeComponent();
            historialControlador = new HistorialControladorAplicacion();
            rutaControladorAplicacion = new RutaControladorAplicacion();
            estudianteControladorAplicacion = new EstudianteControladorAplicacion();
        }

        private void InsertarHistorial()
        {
            historialVistaModelo = new HistorialVistaModelo();
            historialVistaModelo.Fecha_reserva = dateTimePickerHistorial.Value;
            historialVistaModelo.Id_ruta = int.Parse(cboRuta.SelectedValue.ToString());
            historialVistaModelo.Id_estudiante = int.Parse(cboEstudiante.SelectedValue.ToString());

            // Si el campo de ID no está vacío, significa que estás actualizando un historial existente
            if (txtIdHistorial.Text.Length > 0)
            {
                int idHistorial;
                if (!int.TryParse(txtIdHistorial.Text, out idHistorial))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para el ID del historial.");
                    return;
                }
                historialVistaModelo.Id_historial = idHistorial;

                if (historialControlador.ActualizarHistorial(historialVistaModelo))
                {
                    MessageBox.Show("Historial actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede actualizar el historial");
                }
            }
            else
            {
                if (historialControlador.InsertarHistorial(historialVistaModelo))
                {
                    MessageBox.Show("Historial insertado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede insertar el historial");
                }
            }

            ListarHistoriales();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            ListarHistoriales();
            ComboboxRutasyEstudiantes();
        }

        
            
        private void ComboboxRutasyEstudiantes()
        {
            cboRuta.DataSource = rutaControladorAplicacion.ListarRuta();
            cboRuta.DisplayMember = "nombre_ruta";
            cboRuta.ValueMember = "id_ruta";

           
            cboEstudiante.DataSource = estudianteControladorAplicacion.ListarEstudiante();
            cboEstudiante.DisplayMember = "nombre";
            cboEstudiante.ValueMember = "id_estudiante";

        }
        private void ListarHistoriales()
        {
            dgvHistorial.DataSource = historialControlador.ListarHistorial();

        }

        private void pbGuardarHistorial_Click(object sender, EventArgs e)
        {
        
                InsertarHistorial();
                Limpiar();


        }

        private void dgvHistorial_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvHistorial.SelectedRows.Count > 0)
            {

                txtIdHistorial.Text = dgvHistorial.CurrentRow.Cells[0].Value.ToString();
                dateTimePickerHistorial.Text = dgvHistorial.CurrentRow.Cells[1].Value.ToString();           
                cboRuta.SelectedValue = dgvHistorial.CurrentRow.Cells[2].Value;
                cboEstudiante.SelectedValue = dgvHistorial.CurrentRow.Cells[3].Value;
            }
        }

        private void Limpiar()
        {
            txtIdHistorial.Text = "";
            cboRuta.SelectedValue = "";
            cboEstudiante.SelectedValue = "";
        }

        private void EliminarHistorial()
        {
            historialVistaModelo = new HistorialVistaModelo();
            var IdHistorial = int.Parse(txtIdHistorial.Text == "" ? "0" : txtIdHistorial.Text);
            historialVistaModelo.Id_historial = IdHistorial;

            if (historialControlador.EliminarHistorial(historialVistaModelo) && IdHistorial > 0)
            {
                MessageBox.Show("Historial Dado de Baja!!");

                ListarHistoriales();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error. Historial No Dado de Baja!!");

            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar Historial?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                EliminarHistorial();
                Limpiar();
            }
        }
    }
}
