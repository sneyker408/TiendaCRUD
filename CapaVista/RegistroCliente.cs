using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class RegistroCliente : Form
    {
        ClienteLOG _clienteLOG;
        int _id = 0;

        public RegistroCliente(int id = 0)
        {
            InitializeComponent();

            _id = id;

            if (_id > 0)
            {
                this.Text = "Vapesney | Edición de Cliente";
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

        private bool CorreoExiste(string correo)
        {

            List<Cliente> clientes = _clienteLOG.ObtenerClientes();


            foreach (Cliente cliente in clientes)
            {
                if (string.Equals(cliente.Nombre, correo, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void GuardarCliente()
        {
            try
            {
                _clienteLOG = new ClienteLOG();

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Se requiere el nombre del Cliente", "Vapesney | Registro Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    MessageBox.Show("Se requiere el apellido del Cliente", "Vapesney | Registro Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellido.Focus();
                    txtApellido.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("Se requiere el Correo del Cliente", "Vapesney | Registro Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    txtCorreo.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("Se requiere la dirección del Cliente", "Vapesney | Registro Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDireccion.Focus();
                    txtDireccion.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtNumero.Text) || Convert.ToDecimal(txtNumero.Text) == 0)
                {
                    MessageBox.Show("Se requiere el número del Cliente", "Vapesney | Registro Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Focus();
                    txtNumero.BackColor = Color.LightYellow;
                    return;
                }

                if (_id > 0)
                {
                    int codigo = _id;
                    _clienteLOG = new ClienteLOG();
                    var correoCliente = _clienteLOG.ExtraercorreoFabricante(codigo);
                    var numeroCliente = _clienteLOG.estrarnumeroclien(codigo);

                    if(correoCliente == txtCorreo.Text)
                    {

                    }

                    else if (!_clienteLOG.ObtenerCorreos().Contains(txtCorreo.Text))
                    {
                        
                    }
                    else if (_clienteLOG.ObtenerCorreos().Contains(txtCorreo.Text))
                    {
                        MessageBox.Show("El correo del cliente ya existe. Por favor, elija otro correo.", "Vapesney | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCorreo.Focus();
                        txtCorreo.BackColor = Color.LightYellow;
                        return;
                    }

                    if (numeroCliente != txtNumero.Text)
                    {
                        MessageBox.Show("El número del Cliente ya existe. Por favor, elija otro número.", "Vapesney | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNumero.Focus();
                        txtNumero.BackColor = Color.LightYellow;
                        return;
                    }
                }
                else
                {
                    _clienteLOG = new ClienteLOG();
                    var numeroCliente = _clienteLOG.estrarnumeroclien(_id);

                    if (CorreoExiste(txtCorreo.Text))
                    {
                        MessageBox.Show("El correo del cliente ya existe. Por favor, elija otro correo.", "Vapesney | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCorreo.Focus();
                        txtCorreo.BackColor = Color.LightYellow;
                        return;
                    }

                    if (numeroCliente == txtNumero.Text)
                    {
                        MessageBox.Show("El número del Clinete ya existe. Por favor, elija otro número.", "Vapesney | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNumero.Focus();
                        txtNumero.BackColor = Color.LightYellow;
                        return;
                    }
                }

                int resultado;

                if (_id > 0)
                {
                    Cliente cliente;
                    cliente = (Cliente)ClienteBindingSource.Current;
                    resultado = _clienteLOG.ActualizarCliente(cliente, _id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente actualizado con éxito", "Vapesney | Registro Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logró actualizar el cliente", "Vapesney | Registro Cliente",
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

        private bool ValidarNumeroTelefono(int numeroTelefono)
        {
            List<Cliente> clientes = _clienteLOG.NumeroTelefonoExiste();

            foreach (Cliente cliente in clientes)
            {
                if (cliente.NumeroTelefono == numeroTelefono)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnGuardarClien_Click(object sender, EventArgs e)
        {
            _clienteLOG = new ClienteLOG();

            if (ValidarCorreoElectronico(txtCorreo.Text))
            {
                // Intenta convertir el texto del cuadro de texto a un número entero
                if (int.TryParse(txtNumero.Text, out int numeroTelefono))
                {
                    if (ValidarNumeroTelefono(numeroTelefono) && btnGuardarClien.Text == "Guardar")
                    {
                        MessageBox.Show("El número de teléfono ya existe en la base de datos", "Tienda | Registro Cliente",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNumero.Focus();
                        txtNumero.BackColor = Color.LightYellow;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("El número de teléfono no es válido", "Tienda | Registro Cliente",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Focus();
                    txtNumero.BackColor = Color.LightYellow;
                    return;
                }

                if (!_clienteLOG.CorreoElectronicoExiste(txtCorreo.Text) || btnGuardarClien.Text == "Actualizar")
                {
                    GuardarCliente();
                }
                else
                {
                    MessageBox.Show("El correo electrónico ya existe en la base de datos", "Tienda | Registro Cliente",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    txtCorreo.BackColor = Color.LightYellow;
                }
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
