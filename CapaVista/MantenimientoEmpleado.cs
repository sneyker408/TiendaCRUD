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

        private void dgEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvEmpleados.Rows[e.RowIndex].Cells["EmpleadoId"].Value.ToString());

                    if (dgvEmpleados.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        RegistroEmpleado objRegistroEmpleado = new RegistroEmpleado(id);
                        objRegistroEmpleado.ShowDialog();
                        cargarEmpleado();
                    }

                    else if (dgvEmpleados.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar el empleado?", "Vapesney | Edicion Empleado",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _empleadoLOG = new EmpleadoLOG();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("El empleado no se eliminara", "Vapesney | Edicion Empleados",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _empleadoLOG.EliminarEmpleado(id);
                            cargarEmpleado();

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
