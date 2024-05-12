using CapaLogica;
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
        ClienteLOG _clienteLOG;

        public MantenimientoCliente()
        {
            InitializeComponent();
            cargarCliente();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RegistroCliente objRegistroCliente = new RegistroCliente();
            objRegistroCliente.ShowDialog();
            cargarCliente();
        }

        private void cargarCliente()
        {
            _clienteLOG = new ClienteLOG();

            dgvClientes.DataSource = _clienteLOG.ObtenerClientes();

        }
    }
}
