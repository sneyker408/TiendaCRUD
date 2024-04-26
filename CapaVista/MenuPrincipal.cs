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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MnDProducto_Click_Click(object sender, EventArgs e)
        {
            MantenimientoPedido objMttPedido = new MantenimientoPedido();
            objMttPedido.ShowDialog();
        }

        private void MnCategoria_Click(object sender, EventArgs e)
        {
            MantenimientoCategoria objMnCat = new MantenimientoCategoria();
            objMnCat.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProducto objRtroPdto = new RegistroProducto();
            objRtroPdto.ShowDialog();
        }

        private void MnDInventario_Click(object sender, EventArgs e)
        {
            MantenimientoInventario objMnInv = new MantenimientoInventario();
            objMnInv.ShowDialog();
        }

        private void MnClientes_Click(object sender, EventArgs e)
        {
            MantenimientoCliente objMnClien = new MantenimientoCliente();
            objMnClien.ShowDialog();
        }

        private void MnProveedores_Click(object sender, EventArgs e)
        {
            MantenimientoProveedor objMnoProv = new MantenimientoProveedor();
            objMnoProv.ShowDialog();
        }

        private void MnPedido_Click(object sender, EventArgs e)
        {
            MantenimientoPedido objMnPdido = new MantenimientoPedido();
            objMnPdido.ShowDialog();
        }
    }
}
