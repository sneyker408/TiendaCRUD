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
    public partial class MantenimientoCategoria : Form
    {

        CategoriaLOG _categoriaLOG;

        public MantenimientoCategoria()
        {
            InitializeComponent();

            _categoriaLOG = new CategoriaLOG();

            dgvCategoria.DataSource = _categoriaLOG.ObtenerCategoria();
        }

        private void BtnNuevoMCate_Click(object sender, EventArgs e)
        {
            RegistroCategoria objRegCat = new RegistroCategoria();
            objRegCat.ShowDialog();
        }

        private void BtnAtrasMCate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
