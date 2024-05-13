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

namespace CapaVista
{
    public partial class MantenimientoCategoria : Form
    {
        CategoriaLOG _categoriaLOG;

        public MantenimientoCategoria()
        {
            InitializeComponent();
            CargarCategoria();
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

            dgvCategoria.DataSource = _categoriaLOG.ObtenerCategorias();
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
                        CargarCategoria();
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
    }
}
