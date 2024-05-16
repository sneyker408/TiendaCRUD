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
                this.Text = "Vapesney | Edición de Categorias";
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

        private bool CategoriaExiste(string nombreCategoria)
        {

            List<Categoria> categorias = _categoriaLOG.ObtenerCategoria();


            foreach (Categoria categoria in categorias)
            {
                if (string.Equals(categoria.NombreCategoria, nombreCategoria, StringComparison.OrdinalIgnoreCase))
                {
                    return true; 
                }
            }
            return false; 
        }

        private void GuardarCategoria()
        {
            try
            {
                _categoriaLOG = new CategoriaLOG();

                if (string.IsNullOrEmpty(txtCategoria.Text))
                {
                    MessageBox.Show("Se requiere el nombre de la Categoria", "Vapesney | Registro Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoria.Focus();
                    txtCategoria.BackColor = Color.LightYellow;
                    return;
                }
                if (!chkEstado.Checked)
                {
                    var dialogo = MessageBox.Show("¿Estás seguro que deseas guardar la marca inactiva?", "Vapesney | Registro Categoria",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro estado como activo", "Vapesney | Registro Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (_id > 0)
                {

                    int codigo = (_id);

                    _categoriaLOG = new CategoriaLOG();

                    var fabricante = _categoriaLOG.ObtenerFabricantePorId(codigo);

                    var nombrefabri = _categoriaLOG.ExtraerNombreCategoria(codigo);


                    if(_categoriaLOG.ExtrarNombreporEstado().Contains(txtCategoria.Text))
                    {
                        MessageBox.Show("El nombre de la categoria ya existe como inactivo. Por favor, elija otro nombre o active el fabricante existente.", "Tienda | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCategoria.Focus();
                        txtCategoria.BackColor = Color.LightYellow;
                        return;
                    }
                    if (nombrefabri != txtCategoria.Text && _categoriaLOG.ExtrarCategoria().Contains(txtCategoria.Text))
                    {
                        MessageBox.Show("El nombre de la categoria ya existe. Por favor, elija otro nombre.", "Tienda | Registro Categoria",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCategoria.Focus();
                        txtCategoria.BackColor = Color.LightYellow;
                        return;
                    }
                }
                else
                {

                    _categoriaLOG = new CategoriaLOG();
                    var Estadocate = _categoriaLOG.ObtenerFabricantesPorEstadoSegunNombre(txtCategoria.Text);
                    

                    if (_categoriaLOG.ExtrarCategoria().Contains(txtCategoria.Text) && Estadocate == true)
                    {
                        MessageBox.Show("El nombre de la Categoria ya existe. Por favor, elija otro nombre.", "Tienda | Registro Categoria",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCategoria.Focus();
                        txtCategoria.BackColor = Color.LightYellow;
                        return;
                    }
                    else if (!_categoriaLOG.ExtrarCategoria().Contains(txtCategoria.Text))
                    {

                    }
                    else if (Estadocate == false)
                    {
                        MessageBox.Show("El nombre de la categoria ya existe como inactivo. Por favor, elija otro nombre o active el fabricante existente.", "Tienda | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCategoria.Focus();
                        txtCategoria.BackColor = Color.LightYellow;
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
                        MessageBox.Show("Categoría actualizada con éxito", "Vapesney | Registro categorías",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logró actualizar la categoría", "Vapesney | Registro categorías",
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
                        MessageBox.Show("Categoría agregada con éxito", "Vapesney | Registro categorías",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logró guardar la categoría", "Vapesney | Registro categorías",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un Error", "Vapesney | Registro categorías",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
