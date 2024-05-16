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
using System.Xml.Serialization;

namespace CapaVista
{
    public partial class MantenimientoCliente : Form
    {
        ClienteLOG _clienteLOG;
        private bool _esAdmin;

        public MantenimientoCliente(bool esAdmin)
        {
            _esAdmin = esAdmin;
            InitializeComponent();
            MostrarCorreo();
            MostrarTelefonos();
            LimpiarCamposTexto();
            cargarCliente();
            AjustarVisibilidadControles();

        }

        private void AjustarVisibilidadControles()
        {
            // Ajustar la visibilidad de los botones y columnas según el origen
            if (!_esAdmin)
            {
                btnNuevo.Visible = false;
                if (dgvClientes.Columns["Editar"] != null)
                    dgvClientes.Columns["Editar"].Visible = false;
                if (dgvClientes.Columns["Eliminar"] != null)
                    dgvClientes.Columns["Eliminar"].Visible = false;
            }
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

        private void MostrarTelefonos()
        {
            _clienteLOG = new ClienteLOG();
            cbxTelefono.DataSource = _clienteLOG.ObtenerTodosTelefonos();
            cbxTelefono.DisplayMember = "Telefono";
            cbxTelefono.ValueMember = "ClienteId";
            cbxTelefono.SelectedIndex = -1;
        }

        private void MostrarCorreo()
        {
            _clienteLOG = new ClienteLOG();
            cbxCorreo.DataSource = _clienteLOG.ObtenerTodosCorreos();
            cbxCorreo.DisplayMember = "Correo";
            cbxCorreo.ValueMember = "ClienteId";
            cbxCorreo.SelectedIndex = -1;
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
                _clienteLOG = new ClienteLOG();

                var categoria = _clienteLOG.ObtenerClientePorId(codigo);
                var correo = _clienteLOG.ExtraercorreoFabricante(codigo);

                if (categoria != null)
                {
                    cbxCorreo.Text = correo;
                    txtNombre.Text = categoria.Nombre;
                    txtApellido.Text = categoria.Apellido;
                    txtDireccion.Text = categoria.Direccion;
                    cbxTelefono.Text = categoria.NumeroTelefono.ToString();
                    dgvClientes.DataSource = new List<Cliente> { categoria };
      
                }
                else
                {   
                    txtNombre.Text = "-";
                    txtApellido.Text = "-";
                    txtDireccion.Text = "-";
                    cbxTelefono.Text = "-";
                    cbxCorreo.Text = "-";
                    dgvClientes.DataSource = null;
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
                dgvClientes.DataSource = _clienteLOG.ObtenerClientes();
            }
        }

        private void cbxCorreo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCorreo.SelectedIndex != -1)
            {
                string nombrecorreo = cbxCorreo.Text;
                _clienteLOG = new ClienteLOG();

                var cliente = _clienteLOG.ObtenerCorreoPorNombre(nombrecorreo);

                if (cliente != null)
                {
                    // Mostrar el cliente seleccionado en el DataGridView
                    txtCodigo.Text = cliente.ClienteId.ToString();
                    dgvClientes.DataSource = new List<Cliente> { cliente };

                }
                else
                {
                    // Limpiar los controles si no se encuentra el cliente
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDireccion.Text = "";
                    cbxTelefono.SelectedIndex = -1;
                    dgvClientes.DataSource = null;
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
                dgvClientes.DataSource = _clienteLOG.ObtenerTodosCorreos();
            }
        }

        private void cbxCorreo_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxCorreo.Text))
            {
                // Si el texto del ComboBox está vacío, limpiar el TextBox y actualizar el DataGridView
                txtCodigo.Text = "";
                dgvClientes.DataSource = _clienteLOG.ObtenerTodosCorreos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposTexto();
        }

        private void cbxTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTelefono.SelectedIndex != -1)
            {
                int numeroTelefono = Convert.ToInt32(cbxTelefono.Text);
                _clienteLOG = new ClienteLOG();

                var cliente = _clienteLOG.ObtenerClientePorTelefono(numeroTelefono);

                if (cliente != null)
                {
                    // Mostrar el cliente seleccionado en el DataGridView
                    txtCodigo.Text = cliente.ClienteId.ToString();
                    dgvClientes.DataSource = new List<Cliente> { cliente };
                }
                else
                {
                    // Limpiar los controles si no se encuentra el cliente
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtDireccion.Text = "";
                    cbxTelefono.SelectedIndex = -1;
                    dgvClientes.DataSource = null;
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
                dgvClientes.DataSource = _clienteLOG.ObtenerTodosTelefonos();
            }
        }

        private void cbxTelefono_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxTelefono.Text))
            {
                // Si el texto del ComboBox está vacío, limpiar el TextBox y actualizar el DataGridView
                txtCodigo.Text = "";
                dgvClientes.DataSource = _clienteLOG.ObtenerTodosTelefonos();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNombre.Text.ToLower()))
            {
                _clienteLOG = new ClienteLOG();
                var clientesFiltrados = _clienteLOG.ObtenerClientes().Where(c => c.Nombre.ToLower().Contains(txtNombre.Text)).ToList();

                dgvClientes.DataSource = clientesFiltrados;
            }
            else
            {
                cargarCliente();
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtApellido.Text.ToLower()))
            {
                _clienteLOG = new ClienteLOG();
                var clientesFiltrados = _clienteLOG.ObtenerClientes().Where(c => c.Apellido.ToLower().Contains(txtApellido.Text)).ToList();

                dgvClientes.DataSource = clientesFiltrados;
            }
            else
            {
                cargarCliente();
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDireccion.Text))
            {
                string direccionBusqueda = txtDireccion.Text.ToLower(); // Convertir a minúsculas

                _clienteLOG = new ClienteLOG();
                var clientesFiltrados = _clienteLOG.ObtenerClientes()
                    .Where(c => c.Direccion.ToLower().Contains(direccionBusqueda))
                    .ToList();

                dgvClientes.DataSource = clientesFiltrados;
            }
            else
            {
                cargarCliente();
            }
        }

    }
}
