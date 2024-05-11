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

    public partial class RegistroFabricante : Form
    {
        FabricanteLOG _fabricanteLOG;
        int _id = 0;

        public RegistroFabricante(int id = 0)
        {
            InitializeComponent();

            _id = id;

            if (_id > 0)
            {
                this.Text = "Tienda | Edición de Categorias";
                btnGuardarFabri.Text = "Actualizar";

                CargarDatos(_id);
            }
            else
            {
                FabricanteBindingSource.MoveLast();
                FabricanteBindingSource.AddNew();
            }
        }

        private void CargarDatos(int id)
        {
            _fabricanteLOG = new FabricanteLOG();

            FabricanteBindingSource.DataSource = _fabricanteLOG.ObtenerFabricantePorId(id);
        }

        private void btnGuardarFabri_Click(object sender, EventArgs e)
        {
            GuardarFabricante();
        }

        private void btnCancelarFabri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarFabricante()
        {
            try
            {
                _fabricanteLOG = new FabricanteLOG();

                //throw new Exception();
                if (string.IsNullOrEmpty(txtFabricante.Text))
                {
                    MessageBox.Show("Se requiere el nombre de la Fabricante", "Tienda | Registro Fabricante",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFabricante.Focus();
                    txtFabricante.BackColor = Color.LightYellow;
                    return;
                }
                if (!chkEstadoFabri.Checked)
                {
                    var dialogo = MessageBox.Show("Estas seguro que desea guardar la marca inactiva?", "Tienda | Registro Marca",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro estado como activo", "Tienda | Registro Marca",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (_id > 0)
                {
                    Fabricante fabricante;
                    fabricante = (Fabricante)FabricanteBindingSource.Current;
                    int resultado = _fabricanteLOG.GuardarFabricante(fabricante);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Fabricante Editado con Exito", "Tienda | Edicion Fabricantes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro editar el fabricante", "Tienda | Edicion Fabricantes",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // En caso de ser nuevo fabricante.
                else
                {
                    Fabricante fabricante;
                    fabricante = (Fabricante)FabricanteBindingSource.Current;
                    int resultado = _fabricanteLOG.GuardarFabricante(fabricante);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Fabricante Agregado con Exito", "Tienda | Registro Fabricantes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro agregagr el fabricante", "Tienda | Registro Fabricantes",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un Error", "Tienda | Registro Fabricantes",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
