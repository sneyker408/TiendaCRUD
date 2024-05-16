using CapaEntidades;
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
            MostrarTelefonosyCorreo();
            LimpiarCamposTexto();
            cargarEmpleado();
            
        }

        private void MostrarTelefonosyCorreo()
        {
            _empleadoLOG = new EmpleadoLOG();
            cbxTelefono.DataSource = _empleadoLOG.ObtenerTodosTelefonos();
            cbxTelefono.DisplayMember = "Telefono";
            cbxTelefono.ValueMember = "EmpleadoId";
            cbxTelefono.SelectedIndex = -1;

            _empleadoLOG = new EmpleadoLOG();
            cbxCorreo.DataSource = _empleadoLOG.ObtenerTodosTelefonos();
            cbxCorreo.DisplayMember = "Correo";
            cbxCorreo.ValueMember = "EmpleadoId";
            cbxCorreo.SelectedIndex = -1;
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNombre.Text.ToLower()))
            {
                _empleadoLOG = new EmpleadoLOG();
                var clientesFiltrados = _empleadoLOG.ObtenerEmpleados().Where(c => c.Nombre.ToLower().Contains(txtNombre.Text)).ToList();

                dgvEmpleados.DataSource = clientesFiltrados;
            }
            else
            {
                cargarEmpleado();
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtApellido.Text.ToLower()))
            {
                _empleadoLOG = new EmpleadoLOG();
                var clientesFiltrados = _empleadoLOG.ObtenerEmpleados().Where(c => c.Apellido.ToLower().Contains(txtApellido.Text)).ToList();

                dgvEmpleados.DataSource = clientesFiltrados;
            }
            else
            {
                cargarEmpleado();
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDireccion.Text))
            {
                string direccionBusqueda = txtDireccion.Text.ToLower(); // Convertir a minúsculas

                _empleadoLOG = new EmpleadoLOG();
                var clientesFiltrados = _empleadoLOG.ObtenerEmpleados()
                    .Where(c => c.Direccion.ToLower().Contains(direccionBusqueda))
                    .ToList();

                dgvEmpleados.DataSource = clientesFiltrados;
            }
            else
            {
                cargarEmpleado();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposTexto();
        }

        private void LimpiarCamposTexto()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            cbxTelefono.SelectedIndex = -1;
            cbxCorreo.SelectedIndex = -1;
            cbxCorreo.Text = "";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                int codigo = int.Parse(txtCodigo.Text);
                _empleadoLOG = new EmpleadoLOG();

                var categoria = _empleadoLOG.ObtenerEmpleadoPorId(codigo);
                var correo = _empleadoLOG.ExtraercorreoEmpleado(codigo);

                if (categoria != null)
                {
                    cbxCorreo.Text = correo;
                    txtNombre.Text = categoria.Nombre;
                    txtApellido.Text = categoria.Apellido;
                    txtDireccion.Text = categoria.Direccion;
                    cbxTelefono.Text = categoria.Telefono.ToString();
                    dgvEmpleados.DataSource = new List<Empleado> { categoria };

                }
                else
                {
                    txtNombre.Text = "-";
                    txtApellido.Text = "-";
                    txtDireccion.Text = "-";
                    cbxTelefono.Text = "-";
                    cbxCorreo.Text = "-";
                    dgvEmpleados.DataSource = null;
                }
            }
            else
            {
                // Limpiar los controles si el TextBox está vacío
                cbxCorreo.SelectedIndex = -1;
                cbxCorreo.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                cbxTelefono.SelectedIndex = -1;
                dgvEmpleados.DataSource = _empleadoLOG.ObtenerEmpleados();
            }
        }

        private void cbxCorreo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCorreo.SelectedIndex != -1)
            {
                string nombrecorreo = cbxCorreo.Text;
                _empleadoLOG = new EmpleadoLOG();

                var cliente = _empleadoLOG.ObtenerCorreoPorNombre(nombrecorreo);

                if (cliente != null)
                {
                    // Mostrar el cliente seleccionado en el DataGridView
                    txtCodigo.Text = cliente.EmpleadoId.ToString();
                    dgvEmpleados.DataSource = new List<Empleado> { cliente };

                }
                else
                {
                    // Limpiar los controles si no se encuentra el cliente
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDireccion.Text = "";
                    cbxTelefono.SelectedIndex = -1;
                    dgvEmpleados.DataSource = null;
                }
            }
            else
            {
                // Limpiar los controles si no hay nada seleccionado en el ComboBox
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                cbxTelefono.SelectedIndex = -1;
                dgvEmpleados.DataSource = _empleadoLOG.ObtenerTodosCorreos();
            }
        }

        private void cbxCorreo_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxCorreo.Text))
            {
                // Si el texto del ComboBox está vacío, limpiar el TextBox y actualizar el DataGridView
                txtCodigo.Text = "";
                dgvEmpleados.DataSource = _empleadoLOG.ObtenerTodosCorreos();
            }
        }

        private void cbxTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTelefono.SelectedIndex != -1)
            {
                int numeroTelefono = Convert.ToInt32(cbxTelefono.Text);
                _empleadoLOG = new EmpleadoLOG();

                var empleado = _empleadoLOG.ObtenerClientePorTelefono(numeroTelefono);

                if (empleado != null)
                {
                    // Mostrar el cliente seleccionado en el DataGridView
                    txtCodigo.Text = empleado.EmpleadoId.ToString();
                    dgvEmpleados.DataSource = new List<Empleado> { empleado };
                }
                else
                {
                    // Limpiar los controles si no se encuentra el cliente
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDireccion.Text = "";
                    cbxTelefono.SelectedIndex = -1;
                    dgvEmpleados.DataSource = null;
                }
            }
            else
            {
                // Limpiar los controles si no hay nada seleccionado en el ComboBox
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDireccion.Text = "";
                cbxTelefono.SelectedIndex = -1;
                dgvEmpleados.DataSource = _empleadoLOG.ObtenerTodosTelefonos();
            }
        }

    }
}
