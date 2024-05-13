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
    public partial class MantenimientoProductos : Form
    {
        ProductoLOG _productoLOG;
        FabricanteLOG _fabricanteLOG;
        CategoriaLOG _categoriaLOG;

        public MantenimientoProductos()
        {
            InitializeComponent();

            CargarProductos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RegistroProducto objRegistroProducto = new RegistroProducto();
            objRegistroProducto.ShowDialog();
            CargarProductos();
        }

        private void CargarProductos()
        {
            _productoLOG = new ProductoLOG();

            dgvProductos.DataSource = _productoLOG.ObtenerProductos();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvProductos.Rows[e.RowIndex].Cells["ProductoId"].Value.ToString());

                    if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        RegistroProducto objRegistroProducto = new RegistroProducto(id);
                        objRegistroProducto.ShowDialog();
                        CargarProductos();
                    }

                    else if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Tienda | Edicion Producto",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _productoLOG = new ProductoLOG();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("El producto no se eliminara", "Tienda | Edicion Productos",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _productoLOG.EliminarProducto(id);
                            CargarProductos();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Producto eliminado con exito.", "Tienda | Edicion de Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se logro eliminar el producto.", "Tienda | Edicion de Producto",
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

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _fabricanteLOG = new FabricanteLOG();
            _categoriaLOG = new CategoriaLOG();

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProductos.Columns["FabricanteId"].Index)
            {
                int idFabricante = Convert.ToInt32(e.Value);
                string NombreFabricante = _fabricanteLOG.EstraerNombreFabricante(idFabricante);
                e.Value = NombreFabricante;

                e.FormattingApplied = true;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProductos.Columns["CategoriaId"].Index)
            {
                int idCategoria = Convert.ToInt32(e.Value);
                string NombreCategoria = _categoriaLOG.ExtraerNombreCategoria(idCategoria);
                e.Value = NombreCategoria;

                e.FormattingApplied = true;
            }

        }

    }
}
