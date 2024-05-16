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
    public partial class MatenimientoFabricante : Form
    {
        FabricanteLOG _fabricanteLOG;
        private bool _esAdmin;
        public MatenimientoFabricante(bool esAdmin)
        {
            _esAdmin = esAdmin;
            InitializeComponent();
            // Desasociar el evento SelectedIndexChanged
            cbxNombreFabri.SelectedIndexChanged -= cbxNombreFabri_SelectedIndexChanged;

            CargarFabricante();
            MostrarFabricante();
            AjustarVisibilidadControles();

            // Volver a asociar el evento SelectedIndexChanged
            cbxNombreFabri.SelectedIndexChanged += cbxNombreFabri_SelectedIndexChanged;
        }

        private void AjustarVisibilidadControles()
        {
            // Ajustar la visibilidad de los botones y columnas según el origen
            if (!_esAdmin)
            {
                BtnNuevoMFabri.Visible = false;
                if (dgvFabricante.Columns["Editar"] != null)
                    dgvFabricante.Columns["Editar"].Visible = false;
                if (dgvFabricante.Columns["Eliminar"] != null)
                    dgvFabricante.Columns["Eliminar"].Visible = false;
            }
        }

        private void MostrarFabricante()
        {
            _fabricanteLOG = new FabricanteLOG();
            cbxNombreFabri.DataSource = _fabricanteLOG.ObtenerTodosFabricantes();
            cbxNombreFabri.DisplayMember = "NombreFabricante";
            cbxNombreFabri.ValueMember = "FabricanteId";
            cbxNombreFabri.SelectedIndex = -1;
        }

        private void CargarFabricante()
        {
            _fabricanteLOG = new FabricanteLOG();

            if (rdbActivos.Checked)
            {
                dgvFabricante.DataSource = _fabricanteLOG.ObtenerFabricantes();
            }
            else if (rdbInactivos.Checked)
            {
                dgvFabricante.DataSource = _fabricanteLOG.ObtenerFabricantes(true);
            }
        }

        private void CargarotroFabri()
        {
            _fabricanteLOG = new FabricanteLOG();

            dgvFabricante.DataSource = _fabricanteLOG.ObtenerFabricantes();
        }

        private void BtnNuevoMFabri_Click(object sender, EventArgs e)
        {
            RegistroFabricante objRegistroFabri = new RegistroFabricante();
            objRegistroFabri.ShowDialog();
            CargarFabricante();
        }

        private void BtnAtrasMFabri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgFabricante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvFabricante.Rows[e.RowIndex].Cells["FabricanteId"].Value.ToString());

                    if (dgvFabricante.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        RegistroFabricante objRegistroFabricante = new RegistroFabricante(id);
                        objRegistroFabricante.ShowDialog();
                        CargarotroFabri();
                    }

                    else if (dgvFabricante.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar el fabricante?", "Tienda | Edicion Fabricante",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _fabricanteLOG = new FabricanteLOG();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("El fabricante no se eliminará", "Tienda | Edicion Fabricante",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _fabricanteLOG.EliminarFabricante(id);
                            CargarFabricante();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Fabricante eliminado con éxito.", "Tienda | Edicion de Fabricante",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se logró eliminar el fabricante.", "Tienda | Edicion de Fabricante",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbActivos.Checked)
            {
                dgvFabricante.DataSource = _fabricanteLOG.ObtenerFabricantesPorEstado(true);
            }
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInactivos.Checked)
            {
                dgvFabricante.DataSource = _fabricanteLOG.ObtenerFabricantesPorEstado(false);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                int codigo = int.Parse(txtCodigo.Text);
                _fabricanteLOG = new FabricanteLOG();

                var fabricante = _fabricanteLOG.ObtenerFabricantePorId(codigo);
                var nombrefabri = _fabricanteLOG.EstraerNombreFabricante(codigo);

                if (fabricante != null)
                {
                    // Actualizar el estado del ComboBox y del DataGridView
                    if (fabricante.Estado == true)
                    {
                        cbxNombreFabri.Text = nombrefabri;
                        dgvFabricante.DataSource = new List<Fabricante> { fabricante };
                        rdbActivos.Checked = true;
                        rdbInactivos.Checked = false;
                    }
                    else
                    {
                        // Si el fabricante está inactivo, seleccionar el RadioButton inactivo y deseleccionar el activo
                        cbxNombreFabri.SelectedValue = fabricante.FabricanteId;
                        dgvFabricante.DataSource = new List<Fabricante> { fabricante };
                        rdbActivos.Checked = false;
                        rdbInactivos.Checked = true;

                    }
                }
                else
                {
                    // Limpiar los controles si no se encuentra el fabricante
                    cbxNombreFabri.Text = "-";
                    dgvFabricante.DataSource = null;
                }
            }
            else
            {
                // Limpiar los controles si el TextBox está vacío
                cbxNombreFabri.SelectedIndex = -1;
                cbxNombreFabri.Text = "";
                dgvFabricante.DataSource = _fabricanteLOG.ObtenerFabricantes();
                rdbActivos.Checked = true;
                rdbInactivos.Checked = false;
            }
        }

        private void cbxNombreFabri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNombreFabri.SelectedIndex != -1)
            {
                string nombreFabricante = cbxNombreFabri.Text;
                _fabricanteLOG = new FabricanteLOG();

                var fabricante = _fabricanteLOG.ObtenerFabricantePorNombre(nombreFabricante);

                if (fabricante != null)
                {
                    // Actualizar el estado del ComboBox y del DataGridView
                    if (fabricante.Estado == true)
                    {
                        txtCodigo.Text = fabricante.FabricanteId.ToString();
                        dgvFabricante.DataSource = new List<Fabricante> { fabricante };
                        rdbActivos.Checked = true;
                        rdbInactivos.Checked = false;
                    }
                    else
                    {
                        // Si el fabricante está inactivo, seleccionar el RadioButton inactivo y deseleccionar el activo
                        txtCodigo.Text = fabricante.FabricanteId.ToString();
                        dgvFabricante.DataSource = new List<Fabricante> { fabricante };
                        rdbActivos.Checked = false;
                        rdbInactivos.Checked = true;
                    }
                }
                else
                {
                    // Limpiar los controles si no se encuentra el fabricante
                    txtCodigo.Text = "";
                    dgvFabricante.DataSource = null;
                    rdbActivos.Checked = false;
                    rdbInactivos.Checked = false;
                }
            }
            else
            {
                // Limpiar los controles si no hay nada seleccionado en el ComboBox
                txtCodigo.Text = "";
                dgvFabricante.DataSource = _fabricanteLOG.ObtenerFabricantes();
                rdbActivos.Checked = true;
                rdbInactivos.Checked = false;
            }
        }

        private void cbxNombreFabri_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxNombreFabri.Text))
            {
                // Si el texto del ComboBox está vacío, limpiar el TextBox y actualizar el DataGridView
                txtCodigo.Text = "";
                dgvFabricante.DataSource = _fabricanteLOG.ObtenerFabricantes();
            }
        }

        
    }
}
