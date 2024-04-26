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
    public partial class MantenimientoInventario : Form
    {
        public MantenimientoInventario()
        {
            InitializeComponent();
        }

        private void BtnAtrasInventario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevoInventario_Click(object sender, EventArgs e)
        {
            RegistroInventario objRegInv = new RegistroInventario();
            objRegInv.ShowDialog();
        }
    }
}
