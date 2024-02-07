using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Windows.Formularios
{
    public partial class FrmTransporteUIsrael : Form
    {
        //private int childFormNumber = 0;

        public FrmTransporteUIsrael()
        {
            InitializeComponent();
        }

        

        
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FrmTransporteUIsrael_Load(object sender, EventArgs e)
        {
           
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEstudiante();
        }

        private void CrearEstudiante()
        {
            FrmEstudiante nuevo = new FrmEstudiante();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearHistorial();
        }
        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearReserva();
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearRuta();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearVehiculo();
        }
        private void CrearHistorial()
        {
            FrmHistorial nuevo = new FrmHistorial();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void CrearReserva()
        {
            FrmReserva nuevo = new FrmReserva();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void CrearRuta()
        {
           FrmRuta nuevo = new FrmRuta();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void CrearVehiculo()
        {
            FrmVehiculo nuevo = new FrmVehiculo();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

       

        private void toolStripEstudiante_Click(object sender, EventArgs e)
        {
            CrearEstudiante();
        }

        private void toolStripHistorial_Click(object sender, EventArgs e)
        {
            CrearHistorial();
        }

        private void toolStripReserva_Click(object sender, EventArgs e)
        {
            CrearReserva();
        }

        private void toolStripRuta_Click(object sender, EventArgs e)
        {
            CrearRuta();
        }

        private void toolStripVehiculo_Click(object sender, EventArgs e)
        {
            CrearVehiculo();
        }
    }
}
