using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class RegistroCliente : Form
    {
        ClienteLOG _clienteLOG;
        int _id = 0;

        public RegistroCliente()
        {
            InitializeComponent();

            if (_id > 0)
            {
                this.Text = "Tienda | Edición de Productos";
                btnGuardarClien.Text = "Actualizar";

                CargarDatos(_id);
            }
            else
            {
                ClienteBindingSource.MoveLast();
                ClienteBindingSource.AddNew();
            }
        }

        private void CargarDatos(int id)
        {
            _clienteLOG = new ClienteLOG();
            ClienteBindingSource.DataSource = _clienteLOG.ObtenerClientePorId(id);
            
        }

        private void btnCancelarFabri_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void GuardarCliente()
        {
            try
            {
                _clienteLOG = new ClienteLOG();

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Se requiere el nombre del Cliente", "Tienda | Registro Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    MessageBox.Show("Se requiere el apellido del Cliente", "Tienda | Registro Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellido.Focus();
                    txtApellido.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("Se requiere el Correo del Cliente", "Tienda | Registro Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    txtCorreo.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("Se requiere la dirección del Cliente", "Tienda | Registro Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDireccion.Focus();
                    txtDireccion.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtNumero.Text) || Convert.ToDecimal(txtNumero.Text) == 0)
                {
                    MessageBox.Show("Se requiere el número del Cliente", "Tienda | Registro Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Focus();
                    txtNumero.BackColor = Color.LightYellow;
                    return;
                }

                int resultado;

                if (_id > 0)
                {
                    Cliente cliente;
                    cliente = (Cliente)ClienteBindingSource.Current;
                    resultado = _clienteLOG.ActualizarCliente(cliente, _id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente actualizado con éxito", "Tienda | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logró actualizar el cliente", "Tienda | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ClienteBindingSource.EndEdit();

                    Cliente cliente;
                    cliente = (Cliente)ClienteBindingSource.Current;

                    resultado = _clienteLOG.GuardarCliente(cliente);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente agregado con éxito", "Tienda | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logró guardar el cliente", "Tienda | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error", "Tienda | Registro Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCorreoElectronico(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }

        private void btnGuardarClien_Click(object sender, EventArgs e)
        {
            if (ValidarCorreoElectronico(txtCorreo.Text))
            {
                GuardarCliente();
            }
            else
            {
                MessageBox.Show("El formato del correo electrónico no es válido", "Tienda | Registro Cliente",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                txtCorreo.BackColor = Color.LightYellow;
            }
        }
    }
}
