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
    public partial class RegistroEmpleado : Form
    {
        EmpleadoLOG _empleadoLOG;
        int _id = 0;

        public RegistroEmpleado(int id = 0)
        {
            InitializeComponent();

            _id = id;

            if (_id > 0)
            {
                this.Text = "Vapesney | Edición de Empleado";
                btnGuardarEmple.Text = "Actualizar";

                CargarDatos(_id);
            }
            else
            {
                EmpleadoBindingSource.MoveLast();
                EmpleadoBindingSource.AddNew();
            }
        }

        private void CargarDatos(int id)
        {
            _empleadoLOG = new EmpleadoLOG();
            EmpleadoBindingSource.DataSource = _empleadoLOG.ObtenerEmpleadoPorId(id);
        }

        private void btnCancelarEmple_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarEmpleado()
        {
            try
            {
                _empleadoLOG = new EmpleadoLOG();

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Se requiere el nombre del Empleado", "Vapesney | Registro Empleado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    MessageBox.Show("Se requiere el apellido del Empleado", "Vapesney | Registro Empleado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellido.Focus();
                    txtApellido.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("Se requiere el Correo del Empleado", "Vapesney | Registro Empleado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    txtCorreo.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("Se requiere la dirección del Empleado", "Vapesney | Registro Empleado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDireccion.Focus();
                    txtDireccion.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtNumero.Text) || Convert.ToDecimal(txtNumero.Text) == 0)
                {
                    MessageBox.Show("Se requiere el número del Empleado", "Vapesney | Registro Empleado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Focus();
                    txtNumero.BackColor = Color.LightYellow;
                    return;
                }

                int resultado;

                if (_id > 0)
                {
                    Empleado empleado;
                    empleado = (Empleado)EmpleadoBindingSource.Current;
                    resultado = _empleadoLOG.ActualizarEmpleado(empleado, _id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Empleado actualizado con éxito", "Vapesney | Registro Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logró actualizar el empleado", "Vapesney | Registro Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    EmpleadoBindingSource.EndEdit();

                    Empleado empleado;
                    empleado = (Empleado)EmpleadoBindingSource.Current;

                    resultado = _empleadoLOG.GuardarEmpleado(empleado);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Empleado agregado con éxito", "Vapesney | Registro Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logró guardar el empleado", "Vapesney | Registro Empleado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error", "Vapesney | Registro Empleado",
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
            List<Empleado> empleados = _empleadoLOG.NumeroTelefonoExiste();

            foreach (Empleado empleado in empleados)
            {
                if (empleado.Telefono == numeroTelefono)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnGuardarEmple_Click(object sender, EventArgs e)
        {
            _empleadoLOG = new EmpleadoLOG();

            if (ValidarCorreoElectronico(txtCorreo.Text))
            {
                // Intenta convertir el texto del cuadro de texto a un número entero
                if (int.TryParse(txtNumero.Text, out int numeroTelefono))
                {
                    if (ValidarNumeroTelefono(numeroTelefono) && btnGuardarEmple.Text == "Guardar")
                    {
                        MessageBox.Show("El número de teléfono ya existe en la base de datos", "Vapesney | Registro Empleado",
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

                if (!_empleadoLOG.CorreoElectronicoExiste(txtCorreo.Text) || btnGuardarEmple.Text == "Actualizar")
                {
                    GuardarEmpleado();
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
