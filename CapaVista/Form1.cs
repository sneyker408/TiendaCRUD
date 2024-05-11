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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MnMttmProductos_Click(object sender, EventArgs e)
        {
            MantenimientoProductos objMttProducto = new MantenimientoProductos();
            objMttProducto.ShowDialog();
        }

        private void MnRegistroVentas_Click(object sender, EventArgs e)
        {
            RegistroVenta objRegistroVenta = new RegistroVenta();
            objRegistroVenta.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCategoria objMnCat = new MantenimientoCategoria();
            objMnCat.ShowDialog();
        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatenimientoFabricante objMantenimientoFabri = new MatenimientoFabricante();
            objMantenimientoFabri.ShowDialog();
        }
    }
}
