using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.ControladoresAplicacion;
using UI.Windows.VistaModelo;

namespace UI.Windows.Formularios
{
    public partial class FrmEstudiante : Form
    {
        private EstudianteControladorAplicacion estudianteControlador;
        private EstudianteVistaModelo estudianteVistaModelo;
        public FrmEstudiante()
        {
            InitializeComponent();
            estudianteControlador = new EstudianteControladorAplicacion();
        }

        //VALIDAR CORREO
         private bool ValidarEmail(string email)
         {
             // Expresión regular para validar el formato de correo electrónico
             string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
             Regex regex = new Regex(pattern);

             return regex.IsMatch(email);


         }
                private void InsertarEstudiante()
        {
            estudianteVistaModelo = new EstudianteVistaModelo();
            estudianteVistaModelo.Nombre = txtNombre.Text;
            estudianteVistaModelo.Apellido = txtApellido.Text;
            estudianteVistaModelo.Cedula = txtCedula.Text;
            estudianteVistaModelo.Direccion = txtDireccion.Text;
            estudianteVistaModelo.Email = txtEmail.Text;
            estudianteVistaModelo.Celular = txtCelular.Text;

            // Validar la longitud de la cédula
            if (estudianteVistaModelo.Cedula.Length != 10)
      {
          MessageBox.Show("Por favor, ingrese una cédula válida de 10 dígitos.");
          return;
      }

      // Resto del código para validar el correo y otros campos...

      if (!ValidarEmail(estudianteVistaModelo.Email))
      {
          MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
          return;
      }

            if (chkEstado.Checked)
            {
                estudianteVistaModelo.Estado = true;
            }
            else
            {
                estudianteVistaModelo.Estado = false;
            }

            // Si el campo de ID no está vacío, significa que estás actualizando un estudiante existente
            if (txtIdEstudiante.Text.Length > 0)
            {
                int idEstudiante;
                if (!int.TryParse(txtIdEstudiante.Text, out idEstudiante))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para el ID del estudiante.");
                    return;
                }
                estudianteVistaModelo.Id_estudiante = idEstudiante;

                if (estudianteControlador.ActualizarEstudiante(estudianteVistaModelo))
                {
                    MessageBox.Show("Estudiante actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede actualizar Estudiante");
                }
            }
            else
            {
                if (estudianteControlador.InsertarEstudiante(estudianteVistaModelo))
                {
                    MessageBox.Show("Estudiante insertado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede insertar Estudiante");
                }
            }

            ListarEstudiantes();
        }



        private void ListarEstudiantes()
        {
            dgvListaEstudiante.DataSource = estudianteControlador.ListarEstudiante();
        }
        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            ListarEstudiantes();
        }

        

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            InsertarEstudiante();
        }

        private void dgvListaEstudiante_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvListaEstudiante.SelectedRows.Count > 0)
            {
                
                txtIdEstudiante.Text = dgvListaEstudiante.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvListaEstudiante.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvListaEstudiante.CurrentRow.Cells[2].Value.ToString();
                txtCedula.Text = dgvListaEstudiante.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvListaEstudiante.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvListaEstudiante.CurrentRow.Cells[5].Value.ToString();
                txtCelular.Text = dgvListaEstudiante.CurrentRow.Cells[6].Value.ToString();
                if (dgvListaEstudiante.CurrentRow.Cells[7].Value.ToString() == "True")
                {
                    chkEstado.Checked = true;
                }
                else 
                { 
                    chkEstado.Checked = false; 
                }
                //para utilizar en el combobox
                //cboEstudiante.SelectedValue = dgvListaEstudiante.CurrentRow.Cells[8].Value;
            }
        }
    }
}
