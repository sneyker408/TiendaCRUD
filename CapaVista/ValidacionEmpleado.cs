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
    public partial class ValidacionEmpleado : Form
    {

        public ValidacionEmpleado()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ValidarContraseña();
            this.Close();
        }

        private void ValidarContraseña()
        {
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Se requiere la contraseña", "Tienda | Validación de Contraseña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                txtContraseña.BackColor = Color.LightYellow;
                return;
            }
            else if (txtContraseña.Text.Equals("admin123"))
            {
                MantenimientoEmpleado objmantenimientoEmpleado = new MantenimientoEmpleado();
                objmantenimientoEmpleado.ShowDialog();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Tienda | Validación de Contraseña",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                txtContraseña.BackColor = Color.LightYellow;
            }
        }


    }
}
