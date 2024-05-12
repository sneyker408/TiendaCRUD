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
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }
    }
}
