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
    public partial class Ventas_DetalleVentas : Form
    {
        VentaLOG _ventasLOG;
        public Ventas_DetalleVentas()
        {
            InitializeComponent();
            CargarVentas();
            CargarDetalleVentas();
        }

        private void CargarVentas()
        {
            _ventasLOG = new VentaLOG();
            dgvVenta.DataSource = _ventasLOG.ObtenerVentas();
        }

        private void CargarDetalleVentas()
        {
            _ventasLOG = new VentaLOG();
            dgvDetalleVenta.DataSource = _ventasLOG.ObtenerDetalleVentas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _ventasLOG = new VentaLOG();

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvVenta.Columns["NombreEmple"].Index)
            {
                int idEmpleado = Convert.ToInt32(e.Value);
                string NombrEmpleado = _ventasLOG.ExtraerNombreEmpleado(idEmpleado);
                e.Value = NombrEmpleado;

                e.FormattingApplied = true;
            }
        }

        private void dgvDetalleVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _ventasLOG = new VentaLOG();

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDetalleVenta.Columns["ProductoNombre"].Index)
            {
                int idProducto = Convert.ToInt32(e.Value);
                string NombrProducto = _ventasLOG.ExtraerNombreProducto(idProducto);
                e.Value = NombrProducto;

                e.FormattingApplied = true;
            }
        }
    }
}
