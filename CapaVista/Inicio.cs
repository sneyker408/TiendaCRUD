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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void MnRegistroVentas_Click(object sender, EventArgs e)
        {
            RegistroVenta objRegistroVenta = new RegistroVenta();
            objRegistroVenta.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoProductos objMttProducto = new MantenimientoProductos(false);
            objMttProducto.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCategoria mantenimientoCategoria = new MantenimientoCategoria(false);
            mantenimientoCategoria.ShowDialog();
        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatenimientoFabricante objMantenimientoFabri = new MatenimientoFabricante(false);
            objMantenimientoFabri.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCliente objmantenimientoCliente = new MantenimientoCliente(false);
            objmantenimientoCliente.ShowDialog();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidacionContra objContra = new ValidacionContra();
            objContra.ShowDialog();
        }
    }
}
