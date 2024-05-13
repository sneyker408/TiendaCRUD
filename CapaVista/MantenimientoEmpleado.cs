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
    public partial class MantenimientoEmpleado : Form
    {
        EmpleadoLOG _empleadoLOG;

        public MantenimientoEmpleado()
        {
            InitializeComponent();
            cargarEmpleado();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RegistroEmpleado objRegEmpleado = new RegistroEmpleado();
            objRegEmpleado.ShowDialog();
            cargarEmpleado();
        }

        private void cargarEmpleado()
        {
            _empleadoLOG = new EmpleadoLOG();

            dgvEmpleados.DataSource = _empleadoLOG.ObtenerEmpleados();

        }
    }
}
