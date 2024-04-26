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
    public partial class MantenimientoCliente : Form
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private void BtnAtrasClie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevoClie_Click(object sender, EventArgs e)
        {
            RegistroCliente objRegClient = new RegistroCliente();
            objRegClient.ShowDialog();
        }
    }
}
