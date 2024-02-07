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
    public partial class FrmReserva : Form
    {
        private ReservaControladorAplicacion reservaControlador;
        private ReservaVistaModelo reservaVistaModelo;
        private RutaControladorAplicacion rutaControladorAplicacion;
        private EstudianteControladorAplicacion estudianteControladorAplicacion;
        private VehiculoControladorAplicacion vehiculoControladorAplicacion;
        public FrmReserva()
        {
            InitializeComponent();
            reservaControlador = new ReservaControladorAplicacion();
            rutaControladorAplicacion = new RutaControladorAplicacion();
            estudianteControladorAplicacion = new EstudianteControladorAplicacion();
            vehiculoControladorAplicacion = new VehiculoControladorAplicacion();
        }

        private void InsertarReserva()
        {
               
                reservaVistaModelo = new ReservaVistaModelo();
                reservaVistaModelo.Hora_reserva= dateTimePickerHoraReserva.Value.TimeOfDay;
                reservaVistaModelo.Fecha_reserva = dateTimePickerFechaReserva.Value;
                
                reservaVistaModelo.Id_ruta = int.Parse(cboReservaRuta.SelectedValue.ToString()); 
                reservaVistaModelo.Id_estudiante = int.Parse(cboReservaEstudiante.SelectedValue.ToString());
                reservaVistaModelo.Id_vehiculo = int.Parse(cboReservaVehiculo.SelectedValue.ToString());

            if (chkEstadoReserva.Checked)

                reservaVistaModelo.Estado = true;
            else
                reservaVistaModelo.Estado = false;

            
            // Si el campo de ID no está vacío, significa que estás actualizando un historial existente
            if (txtIdReserva.Text.Length > 0)
            {
                int idReserva;
                if (!int.TryParse(txtIdReserva.Text, out idReserva))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para el ID del reserva.");
                    return;
                }
                reservaVistaModelo.Id_reserva = idReserva;

                if (reservaControlador.ActualizarReserva(reservaVistaModelo))
                {
                    MessageBox.Show("Reserva actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede actualizar reserva");
                }
            }
            else
            {
                if (reservaControlador.InsertarReserva(reservaVistaModelo))
                {
                    MessageBox.Show("Reserva insertado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede insertar el reserva");
                }
            }

            ListarReservas();

        }

        private void ListarResRutasEstudiantes()
        {
            cboReservaRuta.DataSource = rutaControladorAplicacion.ListarRuta();
            cboReservaRuta.DisplayMember = "nombre_ruta";
            cboReservaRuta.ValueMember = "id_ruta";


            cboReservaEstudiante.DataSource = estudianteControladorAplicacion.ListarEstudiante();
            cboReservaEstudiante.DisplayMember = "nombre";
            cboReservaEstudiante.ValueMember = "id_estudiante";

            cboReservaVehiculo.DataSource = vehiculoControladorAplicacion.ListarVehiculo();
            cboReservaVehiculo.DisplayMember = "placa";
            cboReservaVehiculo.ValueMember = "id_vehiculo";

        }

        private void ListarReservas()
        {
            dgvListarReserva.DataSource = reservaControlador.ListarReserva();
        }
        private void FrmReserva_Load(object sender, EventArgs e)
        {
                    
            ListarReservas();
            ListarResRutasEstudiantes();
        }


        private void dgvListarReserva_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvListarReserva.SelectedRows.Count > 0)
            {

                txtIdReserva.Text = dgvListarReserva.CurrentRow.Cells[0].Value.ToString();
                cboReservaEstudiante.SelectedValue = dgvListarReserva.CurrentRow.Cells[1].Value;
                cboReservaRuta.SelectedValue = dgvListarReserva.CurrentRow.Cells[2].Value;
                
                dateTimePickerFechaReserva.Text = dgvListarReserva.CurrentRow.Cells[3].Value.ToString();
                dateTimePickerHoraReserva.Text = dgvListarReserva.CurrentRow.Cells[4].Value.ToString();
                

                if (dgvListarReserva.CurrentRow.Cells[5].Value.ToString() == "True")
                {
                    chkEstadoReserva.Checked = true;
                }
                else
                {
                    chkEstadoReserva.Checked = false;
                }

                cboReservaVehiculo.SelectedValue = dgvListarReserva.CurrentRow.Cells[6].Value;
            }
        }


        private void pbGuardarReserva_Click(object sender, EventArgs e)
        {
            InsertarReserva();
            Limpiar();
        }

        private void Limpiar()
        {
            txtIdReserva.Text = "";
            dateTimePickerFechaReserva.Text = "";
            dateTimePickerHoraReserva.Text = "";
            cboReservaEstudiante.SelectedValue = ""; 
            cboReservaRuta.SelectedValue = ""; 
            cboReservaVehiculo.SelectedValue = "";
            chkEstadoReserva.Checked = false;
        }

        private void EliminarReserva()
        {
            reservaVistaModelo = new ReservaVistaModelo();
            var IdReserva = int.Parse(txtIdReserva.Text == "" ? "0" : txtIdReserva.Text);
            reservaVistaModelo.Id_reserva = IdReserva;

            if (reservaControlador.EliminarReserva(reservaVistaModelo) && IdReserva > 0)
            {
                MessageBox.Show("Reserva Dado de Baja!!");

                ListarReservas();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error. Reserva No Dado de Baja!!");

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta Reserva?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                EliminarReserva();
                Limpiar();
            }
        }
    }
}
