using System;
using CapaLogica;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;

namespace CapaVista
{
    public partial class MantenimientoCategoria : Form
    {
        CategoriaLOG _categoriaLOG;

        public MantenimientoCategoria()
        {
            InitializeComponent();
            // Desasociar el evento SelectedIndexChanged
            cbxNombreCate.SelectedIndexChanged -= cbxNombreCate_SelectedIndexChanged;

            CargarCategoria();
            MostrarCategoria();

            // Volver a asociar el evento SelectedIndexChanged
            cbxNombreCate.SelectedIndexChanged += cbxNombreCate_SelectedIndexChanged;
        }

        private void MostrarCategoria()
        {
            _categoriaLOG = new CategoriaLOG();
            cbxNombreCate.DataSource = _categoriaLOG.ObtenerTodasCategorias();
            cbxNombreCate.DisplayMember = "NombreCategoria";
            cbxNombreCate.ValueMember = "CategoriaId";
            cbxNombreCate.SelectedIndex = -1;
        }

        private void BtnNuevoMCate_Click(object sender, EventArgs e)
        {
            RegistroCategoria objRegistroCategoria = new RegistroCategoria();
            objRegistroCategoria.ShowDialog();
            CargarCategoria();
        }

        private void CargarCategoria()
        {
            _categoriaLOG = new CategoriaLOG();

            if (rdbActivos.Checked)
            {
                dgvCategoria.DataSource = _categoriaLOG.ObtenerCategorias();
            }
            else if (rdbInactivos.Checked)
            {

                dgvCategoria.DataSource = _categoriaLOG.ObtenerCategorias(true);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnAtrasMCate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvCategoria.Rows[e.RowIndex].Cells["CategoriaId"].Value.ToString());

                    if (dgvCategoria.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        RegistroCategoria objRegistroCategoria = new RegistroCategoria(id);
                        objRegistroCategoria.ShowDialog();
                        CargarOtraCategoria();
                    }

                    else if (dgvCategoria.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar el categoria?", "Tienda | Edicion Categoria",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _categoriaLOG = new CategoriaLOG();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("El categoria no se eliminara", "Tienda | Edicion Categorias",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _categoriaLOG.EliminarCategoria(id);
                            CargarCategoria();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Categoria eliminado con exito.", "Tienda | Edicion de Categoria",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se logro eliminar el categoria.", "Tienda | Edicion de Categoria",
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

        private void CargarOtraCategoria()
        {
            _categoriaLOG = new CategoriaLOG();

            dgvCategoria.DataSource = _categoriaLOG.ObtenerCategoria();
        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbActivos.Checked)
            {
                dgvCategoria.DataSource = _categoriaLOG.ObtenerFabricantesPorEstado(true);
            }
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInactivos.Checked)
            {
                dgvCategoria.DataSource = _categoriaLOG.ObtenerFabricantesPorEstado(false);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                int codigo = int.Parse(txtCodigo.Text);
                _categoriaLOG = new CategoriaLOG();

                var categoria = _categoriaLOG.ObtenerFabricantePorId(codigo);

                if (categoria != null)
                {
                    // Actualizar el estado del ComboBox y del DataGridView
                    if (categoria.Estado == true)
                    {
                        cbxNombreCate.SelectedValue = categoria.CategoriaId;
                        dgvCategoria.DataSource = new List<Categoria> {categoria};
                        rdbActivos.Checked = true;
                        rdbInactivos.Checked = false;
                    }
                    else
                    {
                        // Si el fabricante está inactivo, seleccionar el RadioButton inactivo y deseleccionar el activo
                        cbxNombreCate.SelectedValue = categoria.CategoriaId;
                        dgvCategoria.DataSource = new List<Categoria>{categoria};
                        rdbActivos.Checked = false;
                        rdbInactivos.Checked = true;

                    }
                }
                else
                {
                    // Limpiar los controles si no se encuentra el fabricante
                    cbxNombreCate.SelectedIndex = -1;
                    dgvCategoria.DataSource = null;
                    rdbActivos.Checked = false;
                    rdbInactivos.Checked = false;
                }
            }
            else
            {
                // Limpiar los controles si el TextBox está vacío
                cbxNombreCate.SelectedIndex = -1;
                cbxNombreCate.Text = "";
                dgvCategoria.DataSource = _categoriaLOG.ObtenerCategoria();
                rdbActivos.Checked = false;
                rdbInactivos.Checked = false;
            }
        }

        private void cbxNombreCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNombreCate.SelectedIndex != -1)
            {
                string nombreCategoria = cbxNombreCate.Text;
                _categoriaLOG = new CategoriaLOG();

                var categoria = _categoriaLOG.ObtenerCategoriaPorNombre(nombreCategoria);

                if (categoria != null)
                {
                    // Actualizar el estado del ComboBox y del DataGridView
                    if (categoria.Estado == true)
                    {
                        txtCodigo.Text = categoria.CategoriaId.ToString();
                        dgvCategoria.DataSource = new List<Categoria> { categoria };
                        rdbActivos.Checked = true;
                        rdbInactivos.Checked = false;
                    }
                    else
                    {
                        // Si el fabricante está inactivo, seleccionar el RadioButton inactivo y deseleccionar el activo
                        txtCodigo.Text = categoria.CategoriaId.ToString();
                        dgvCategoria.DataSource = new List<Categoria> { categoria };
                        rdbActivos.Checked = false;
                        rdbInactivos.Checked = true;
                    }
                }
                else
                {
                    // Limpiar los controles si no se encuentra el fabricante
                    txtCodigo.Text = "";
                    dgvCategoria.DataSource = null;
                    rdbActivos.Checked = false;
                    rdbInactivos.Checked = false;
                }
            }
            else
            {
                // Limpiar los controles si no hay nada seleccionado en el ComboBox
                txtCodigo.Text = "";
                dgvCategoria.DataSource = _categoriaLOG.ObtenerCategoria();
                rdbActivos.Checked = false;
                rdbInactivos.Checked = false;
            }
        }

        private void cbxNombreCate_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxNombreCate.Text))
            {
                // Si el texto del ComboBox está vacío, limpiar el TextBox y actualizar el DataGridView
                txtCodigo.Text = "";
                dgvCategoria.DataSource = _categoriaLOG.ObtenerCategoria();
            }
        }
    }
}
