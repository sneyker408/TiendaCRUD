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
    public partial class RegistroCategoria : Form
    {
        CategoriaLOG _categoriaLOG;

        int _id = 0;
        
        public RegistroCategoria(int id = 0)
        {

            InitializeComponent();

            _id = id;

            if (_id > 0)
            {
                this.Text = "Tienda | Edición de Categorias";
                btnGuardarCategoria.Text = "Actualizar";

                CargarDatos(_id);
            }
            else
            {
                CategoriabindingSource.MoveLast();
                CategoriabindingSource.AddNew();
            }
        }

        private void CargarDatos(int id)
        {
            _categoriaLOG = new CategoriaLOG();

            CategoriabindingSource.DataSource = _categoriaLOG.ObtenerCategoriaPorId(id);
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarCategoria()
        {
            try
            {
                _categoriaLOG = new CategoriaLOG();

                //throw new Exception();
                if (string.IsNullOrEmpty(txtCategoria.Text))
                {
                    MessageBox.Show("Se requiere el nombre de la Categoria", "Tienda | Registro Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoria.Focus();
                    txtCategoria.BackColor = Color.LightYellow;
                    return;
                }
                if (!chkEstado.Checked)
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
                int resultado;

                if (_id > 0)
                {
                    Categoria categoria;

                    categoria = (Categoria)CategoriabindingSource.Current;

                    resultado = _categoriaLOG.ActualizarCategoria(categoria, _id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("categoria actualizado con exito", "Tienda | Registro categorias",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro acutalizar el categoria", "Tienda | Registro categorias",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    CategoriabindingSource.EndEdit();

                    Categoria categoria;
                    categoria = (Categoria)CategoriabindingSource.Current;

                    resultado = _categoriaLOG.GuardarCategoria(categoria);

                    if (resultado > 0)
                    {
                        MessageBox.Show("categoria agregado con exito", "Tienda | Registro categorias",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar el categoria", "Tienda | Registro categorias",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un Error", "Tienda | Registro categorias",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
