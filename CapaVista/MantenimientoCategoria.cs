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
            CargarCategorias();
        }

        private void BtnNuevoMCate_Click(object sender, EventArgs e)
        {
            RegistroCategoria objRegistroCategoria = new RegistroCategoria();
            objRegistroCategoria.ShowDialog();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            _categoriaLOG = new CategoriaLOG();

            dgvCategoria.DataSource = _categoriaLOG.ObtenerCategorias();
        }

        private void BtnAtrasMCate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
