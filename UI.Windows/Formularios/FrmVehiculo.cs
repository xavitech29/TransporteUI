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
    public partial class FrmVehiculo : Form
    {
        private VehiculoControladorAplicacion vehiculoControlador;
        private VehiculoVistaModelo vehiculoVistaModelo;
        public FrmVehiculo()
        {
            InitializeComponent();
            vehiculoControlador = new VehiculoControladorAplicacion();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            ListarVehiculos();

        }

        private void ListarVehiculos()
        {
            dgvListarVehiculos.DataSource = vehiculoControlador.ListarVehiculo();
        }
        private void InsertarVehiculo()
        {
            
            vehiculoVistaModelo = new VehiculoVistaModelo();
            vehiculoVistaModelo.Placa = txtPlaca.Text;
            vehiculoVistaModelo.Marca = txtMarca.Text;
            vehiculoVistaModelo.Motor = txtMotor.Text;
            vehiculoVistaModelo.Modelo = txtModelo.Text;
            vehiculoVistaModelo.Anio = int.Parse(txtAnio.Text);
            vehiculoVistaModelo.Chasis = txtChasis.Text;
            vehiculoVistaModelo.Numero_pasajeros = int.Parse(txtPasajeros.Text);


            if (chkEstadoVehiculo.Checked)

                vehiculoVistaModelo.Estado = true;
            else
                vehiculoVistaModelo.Estado = false;

            // Si el campo de ID no está vacío, significa que estás actualizando un estudiante existente
            if (txtIdVehiculo.Text.Length > 0)
            {
                int idVehiculo;
                if (!int.TryParse(txtIdVehiculo.Text, out idVehiculo))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para el ID del vehiculo.");
                    return;
                }
                vehiculoVistaModelo.Id_vehiculo = idVehiculo;

                if (vehiculoControlador.ActualizarVehiculo(vehiculoVistaModelo))
                {
                    MessageBox.Show("Vehiculo actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede actualizar Vehiculo");
                }
            }
            else
            {
                if (vehiculoControlador.InsertarVehiculo(vehiculoVistaModelo))
                {
                    MessageBox.Show("Vehiculo insertado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede insertar Vehiculo");
                }
            }

            ListarVehiculos();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarVehiculo();
        }

        private void pbGuardarVehiculo_Click(object sender, EventArgs e)
        {
            InsertarVehiculo();
        }

        private void dgvListarVehiculos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvListarVehiculos.SelectedRows.Count > 0)
            {

                txtIdVehiculo.Text = dgvListarVehiculos.CurrentRow.Cells[0].Value.ToString();
                txtPlaca.Text = dgvListarVehiculos.CurrentRow.Cells[1].Value.ToString();
                txtMarca.Text = dgvListarVehiculos.CurrentRow.Cells[2].Value.ToString();
                txtMotor.Text = dgvListarVehiculos.CurrentRow.Cells[3].Value.ToString();
                txtModelo.Text = dgvListarVehiculos.CurrentRow.Cells[4].Value.ToString();
                txtAnio.Text = dgvListarVehiculos.CurrentRow.Cells[5].Value.ToString();
                txtChasis.Text = dgvListarVehiculos.CurrentRow.Cells[6].Value.ToString();
                txtPasajeros.Text = dgvListarVehiculos.CurrentRow.Cells[7].Value.ToString();
                if (dgvListarVehiculos.CurrentRow.Cells[8].Value.ToString() == "True")
                {
                    chkEstadoVehiculo.Checked = true;
                }
                else
                {
                    chkEstadoVehiculo.Checked = false;
                }
                //para utilizar en el combobox
                //cboEstudiante.SelectedValue = dgvListaEstudiante.CurrentRow.Cells[8].Value;
            }
        }
    }
}
