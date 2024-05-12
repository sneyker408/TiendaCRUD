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
            
        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCategoria objMnCat = new MantenimientoCategoria();
            objMnCat.ShowDialog();
        }

        private void mantenimientoFabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatenimientoFabricante objMantenimientoFabri = new MatenimientoFabricante();
            objMantenimientoFabri.ShowDialog();
        }

        private void mantenimientoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCliente objmantenimientoCliente = new MantenimientoCliente();
            objmantenimientoCliente.ShowDialog();
        }

        private void nuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCategoria objRegistroCate = new RegistroCategoria();
            objRegistroCate.ShowDialog();
        }

        private void nuevoFabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroFabricante objRegistroFabricante = new RegistroFabricante();
            objRegistroFabricante.ShowDialog();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCliente objRegistroClien = new RegistroCliente();
            objRegistroClien.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidacionEmpleado ObjValidacionEmpleado = new ValidacionEmpleado();
            ObjValidacionEmpleado.ShowDialog();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProducto objRegistroProducto = new RegistroProducto();
            objRegistroProducto.ShowDialog();
        }
    }
}
