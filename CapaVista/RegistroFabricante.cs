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
                this.Text = "Vapesney | Edición de Fabricante";
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

        private bool FabricanteExiste(string nombreFabricante)
        {

            List<Fabricante> fabricantes = _fabricanteLOG.ObtenerFabricantes();


            foreach (Fabricante fabricante in fabricantes)
            {
                if (string.Equals(fabricante.NombreFabricante, nombreFabricante, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
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

                if (string.IsNullOrEmpty(txtFabricante.Text))
                {
                    MessageBox.Show("Se requiere el nombre del Fabricante", "Tienda | Registro Fabricante",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFabricante.Focus();
                    txtFabricante.BackColor = Color.LightYellow;
                    return;
                }
                if (!chkEstadoFabri.Checked)
                {
                    var dialogo = MessageBox.Show("¿Estás seguro que deseas guardar el fabricante inactivo?", "Tienda | Registro Fabricante",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro estado como activo", "Tienda | Registro Fabricante",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }


                if (_id > 0)
                {

                    int codigo = (_id);

                    _fabricanteLOG = new FabricanteLOG();

                    var fabricante = _fabricanteLOG.ObtenerFabricantePorId(codigo);

                    var nombrefabri = _fabricanteLOG.EstraerNombreFabricante(codigo);

                    var EstadoFabri = _fabricanteLOG.ObtenerFabricantesPorEstadoSegunid(codigo);


                    if (nombrefabri != txtFabricante.Text)
                    {
                        MessageBox.Show("El nombre del fabricante ya existe. Por favor, elija otro nombre.", "Tienda | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFabricante.Focus();
                        txtFabricante.BackColor = Color.LightYellow;
                        return;
                    }
                }
                else
                {
                    int codigo = (_id);

                    _fabricanteLOG = new FabricanteLOG();
                    var EstadoFabri = _fabricanteLOG.ObtenerFabricantesPorEstadoSegunid(codigo);

                    if (FabricanteExiste(txtFabricante.Text))
                    {
                        MessageBox.Show("El nombre del fabricante ya existe. Por favor, elija otro nombre.", "Tienda | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFabricante.Focus();
                        txtFabricante.BackColor = Color.LightYellow;
                        return;
                    }
                    else if (EstadoFabri == false)
                    {
                        MessageBox.Show("El nombre del fabricante ya existe como inactivo. Por favor, elija otro nombre o active el fabricante existente.", "Tienda | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFabricante.Focus();
                        txtFabricante.BackColor = Color.LightYellow;
                        return;
                    }
                }

                int resultado;

                if (_id > 0)
                {
                    Fabricante fabricante;
                    fabricante = (Fabricante)FabricanteBindingSource.Current;
                    resultado = _fabricanteLOG.ActualizarFabricante(fabricante, _id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Fabricante actualizado con éxito", "Tienda | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logró actualizar el fabricante", "Tienda | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    FabricanteBindingSource.EndEdit();
                    Fabricante fabricante;
                    fabricante = (Fabricante)FabricanteBindingSource.Current;
                    resultado = _fabricanteLOG.GuardarFabricante(fabricante);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Fabricante agregado con éxito", "Tienda | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logró guardar el fabricante", "Tienda | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error", "Tienda | Registro Fabricante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
