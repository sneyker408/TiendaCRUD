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
    public partial class MantenimientoProducto : Form
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }

        private void BtnAtrasProduc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevoProduc_Click(object sender, EventArgs e)
        {
            RegistroProducto objRegPro = new RegistroProducto();
            objRegPro.ShowDialog();
        }
    }
}
