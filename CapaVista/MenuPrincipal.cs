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
            RegistroCategoria objRtroCat = new RegistroCategoria();
            objRtroCat.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProducto objRtroPdto = new RegistroProducto();
            objRtroPdto.ShowDialog();
        }

        private void MnDInventario_Click(object sender, EventArgs e)
        {
            RegistroInventario objRtroInv = new RegistroInventario();
            objRtroInv.ShowDialog();
        }

        private void MnClientes_Click(object sender, EventArgs e)
        {
            RegistroCliente objRtroClien = new RegistroCliente();
            objRtroClien.ShowDialog();
        }

        private void MnProveedores_Click(object sender, EventArgs e)
        {
            RegistroProveedor objRtroProv = new RegistroProveedor();
            objRtroProv.ShowDialog();
        }

        private void MnPedido_Click(object sender, EventArgs e)
        {
            RegistroPedido objRtroPdido = new RegistroPedido();
            objRtroPdido.ShowDialog();
        }
    }
}
