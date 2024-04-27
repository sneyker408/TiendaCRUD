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
    public partial class RegistroCategoria : Form
    {

        

        public RegistroCategoria()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }

        CategoriaLOG _categoriaLOG;

        private void GuardarCategoria()
        {
            try
            {
                _categoriaLOG = new CategoriaLOG();

                //throw new Exception();
                if (string.IsNullOrEmpty(txtCategoria.Text))
                {
                    MessageBox.Show("Se requiere el nombre del Categoria", "Vapesney | Registro Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoria.Focus();
                    txtCategoria.BackColor = Color.AntiqueWhite;
                    return;
                }

                categoriabindingSource.EndEdit();

                Categoria categoria;
                categoria = (Categoria)categoriabindingSource.Current;

                int resultado = _categoriaLOG.GuardarCategoria(categoria);

                if (resultado > 0)
                {
                    MessageBox.Show("Categoria Agregada con Exito", "Vapesney | Registro Categorias",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se agrego la categoria", "Vapesney | Registro Categorias",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error", "Vapesney | Registro Categorias",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void categoriabindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
