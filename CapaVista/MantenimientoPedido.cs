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
    public partial class MantenimientoPedido : Form
    {
        public MantenimientoPedido()
        {
            InitializeComponent();
        }

        private void DetalleProductos_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            RegistroProducto objRtroProdducto = new RegistroProducto();
            objRtroProdducto.ShowDialog();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
