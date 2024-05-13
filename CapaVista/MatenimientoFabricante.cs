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
        public MatenimientoFabricante()
        {
            InitializeComponent();
            CargarFabricante();
        }

        private void CargarFabricante()
        {
            _fabricanteLOG = new FabricanteLOG();

            dgvFabricante.DataSource = _fabricanteLOG.ObtenerFabricantes();
        }

        private void BtnNuevoMFabri_Click(object sender, EventArgs e)
        {
            RegistroFabricante objRegistroFabri = new RegistroFabricante();
            objRegistroFabri.ShowDialog();
        }

        private void BtnAtrasMFabri_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        CargarFabricante();
                    }

                    else if (dgvFabricante.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar el categoria?", "Tienda | Edicion Categoria",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _fabricanteLOG = new FabricanteLOG();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("El categoria no se eliminara", "Tienda | Edicion Categorias",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _fabricanteLOG.EliminarFabricante(id);
                            CargarFabricante();

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
