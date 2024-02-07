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
    public partial class FrmRuta : Form
    {
        private RutaControladorAplicacion rutaControlador;
        private RutaVistaModelo rutaVistaModelo;
        public FrmRuta()
        {
            InitializeComponent();
            rutaControlador = new RutaControladorAplicacion();
        }

       
        private void InsertarRuta()
        {
            rutaVistaModelo = new RutaVistaModelo();
            rutaVistaModelo.Nombre_ruta = txtNombreRuta.Text;
            rutaVistaModelo.Origen = txtOrigen.Text;
            rutaVistaModelo.Destino = txtDestino.Text;
            rutaVistaModelo.Hora_salida = dateTimePickerSalida.Value.TimeOfDay;
            rutaVistaModelo.Hora_llegada = dateTimePickerLlegada.Value.TimeOfDay;
            rutaVistaModelo.Fecha_ruta = dateTimePickerFechaRuta.Value;

         
            rutaVistaModelo.Capacidad = txtCapacidad.Text;

            if (txtIdRuta.Text.Length > 0)
            {
                int idRuta;
                if (!int.TryParse(txtIdRuta.Text, out idRuta))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para el ID del ruta.");
                    return;
                }
                rutaVistaModelo.Id_ruta = idRuta;

                if (rutaControlador.ActualizarRuta(rutaVistaModelo))
                {
                    MessageBox.Show("Ruta actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede actualizar el Ruta");
                }
            }
            else
            {
                if (rutaControlador.InsertarRuta(rutaVistaModelo))
                {
                    MessageBox.Show("Ruta insertado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede insertar el ruta");
                }
            }

            ListarRutas();

        }

       

        private void ListarRutas()
        {

            dgvListarRutas.DataSource = rutaControlador.ListarRuta();
        }

        

        private void pbGuardarRuta_Click(object sender, EventArgs e)
        {           
                InsertarRuta();
                Limpiar();


        }

        private void FrmRuta_Load(object sender, EventArgs e)
        {

            ListarRutas();
        }

        private void dgvListarRutas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvListarRutas.SelectedRows.Count > 0)
            {

                txtIdRuta.Text = dgvListarRutas.CurrentRow.Cells[0].Value.ToString();
                txtNombreRuta.Text = dgvListarRutas.CurrentRow.Cells[1].Value.ToString();
                txtOrigen.Text = dgvListarRutas.CurrentRow.Cells[2].Value.ToString();
                txtDestino.Text = dgvListarRutas.CurrentRow.Cells[3].Value.ToString();
                dateTimePickerSalida.Text = dgvListarRutas.CurrentRow.Cells[4].Value.ToString();
                dateTimePickerLlegada.Text =dgvListarRutas.CurrentRow.Cells[5].Value.ToString();
                dateTimePickerFechaRuta.Text = dgvListarRutas.CurrentRow.Cells[6].Value.ToString();
                txtCapacidad.Text = dgvListarRutas.CurrentRow.Cells[7].Value.ToString();

            }
        }

        private void Limpiar()
        {
            txtIdRuta.Text = "";
            txtNombreRuta.Text = "";
            txtOrigen.Text = "";
            txtDestino.Text = "";
            dateTimePickerSalida.Text = "";
            dateTimePickerLlegada.Text = "";
            dateTimePickerFechaRuta.Text = "";
            txtCapacidad.Text = "";

        }

        private void EliminarRuta()
        {
            rutaVistaModelo = new RutaVistaModelo();
            var IdRuta = int.Parse(txtIdRuta.Text == "" ? "0" : txtIdRuta.Text);
            rutaVistaModelo.Id_ruta = IdRuta;

            if (rutaControlador.EliminarRuta(rutaVistaModelo) && IdRuta > 0)
            {
                MessageBox.Show("Ruta Dado de Baja!!");

                ListarRutas();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error. Ruta No Dado de Baja!!");

            }
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta Ruta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                EliminarRuta();
                Limpiar();
            }
        }
    }
}
