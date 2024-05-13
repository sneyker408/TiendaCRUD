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

        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvClientes.Rows[e.RowIndex].Cells["ClienteId"].Value.ToString());

                    if (dgvClientes.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        RegistroCliente objRegistroCliente = new RegistroCliente(id);
                        objRegistroCliente.ShowDialog();
                        cargarCliente();
                    }

                    else if (dgvClientes.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar el empleado?", "Vapesney | Edicion Empleado",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _clienteLOG = new ClienteLOG();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("El empleado no se eliminara", "Vapesney | Edicion Empleados",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _clienteLOG.EliminarCliente(id);
                            cargarCliente();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Empleado eliminado con exito.", "Vapesney | Edicion de Empleado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se logro eliminar el empleado.", "Vapesney | Edicion de Empleado",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }
    }
}
