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
    public partial class MantenimientoCategoria : Form
    {
        public MantenimientoCategoria()
        {
            InitializeComponent();
        }

        private void BtnNuevoMCate_Click(object sender, EventArgs e)
        {
            RegistroCategoria objRegCat = new RegistroCategoria();
            objRegCat.ShowDialog();
        }

        private void BtnAtrasMCate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
