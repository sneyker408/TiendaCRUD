using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MatenimientoFabricante : Form
    {
        FabricanteLOG _fabricanteLOG;
        public MatenimientoFabricante()
        {
            InitializeComponent();
            CargarFabricante();
        }

        private void CargarFabricante()
        {
            _fabricanteLOG = new FabricanteLOG();

            dgvFabricante.DataSource = _fabricanteLOG.ObtenerFabricantes();
        }

        private void BtnNuevoMFabri_Click(object sender, EventArgs e)
        {
            RegistroFabricante objRegistroFabri = new RegistroFabricante();
            objRegistroFabri.ShowDialog();
        }

        private void BtnAtrasMFabri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
