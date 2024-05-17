using CapaEntidades;
using CapaLogica;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CapaVista
{
    public partial class RegistroVenta : Form
    {
        VentaLOG _ventaLOG;
        ProductoLOG _productoLOG;
        DataTable detalleVenta;
        EmpleadoLOG _empleadoLOG;
        private bool isUpdating = false;

        public RegistroVenta()
        {
            InitializeComponent();

            CargarProductos();
            MostrarEmpleados();
            LimpiarProducto();

            detalleVenta = new DataTable();
            detalleVenta.Columns.Add("Codigo", typeof(int));
            detalleVenta.Columns.Add("Nombre", typeof(string));
            detalleVenta.Columns.Add("Precio", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));

            dgvDetalleVenta.DataSource = detalleVenta;
        }

        private void CargarProductos()
        {
            _productoLOG = new ProductoLOG();
            productoBindingSource.DataSource = _productoLOG.ObtenerProductos();
        }

        private void MostrarEmpleados()
        {
            _empleadoLOG = new EmpleadoLOG();
            cbxNombreEmple.DataSource = _empleadoLOG.ObtenerTodosTelefonos();
            cbxNombreEmple.DisplayMember = "Empleado";
            cbxNombreEmple.ValueMember = "EmpleadoId";
            cbxNombreEmple.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                int existencia = int.Parse(txtExistencias.Text);

                var producto = (Producto)productoBindingSource.Current;


                if (txtExistencias == null && txtCodigo != null)
                {
                    MessageBox.Show("El producto seleccionado no existe o esta desactivado, seleccione un producto distinto para continuar", "Vapeney | Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    txtCantidad.BackColor = Color.LightYellow;
                    return;
                }
                else if (txtCodigo == null)
                {
                    MessageBox.Show("No a seleccionado un producto para agregar, seleccione un producto para continuar", "Vapeney | Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    txtCantidad.BackColor = Color.LightYellow;
                    return;
                }
                else if (cantidad == 0)
                {
                    MessageBox.Show("No se pueden agregar 0 productos, seleccione una cantidad mayor", "Vapeney | Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    txtCantidad.BackColor = Color.LightYellow;
                    return;
                }
                else if (cantidad > existencia)
                {
                    MessageBox.Show("La cantidad es mayor a las existencias, seleccione una cantidad menor", "Vapeney | Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    txtCantidad.BackColor = Color.LightYellow;
                    return;
                }

                if (producto != null)
                {
                    detalleVenta.Rows.Add(codigo, producto.Nombre, producto.PrecioUnitario, cantidad, (cantidad * producto.PrecioUnitario));
                    dgvDetalleVenta.DataSource = detalleVenta;
                    CalcularMontoTotal();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un Error el producto esta desactivado o no existe", "Vapeney | Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoEmpleado.Text))
            {
                int codigoemple = int.Parse(txtCodigoEmpleado.Text);

                if (_empleadoLOG.ObtenerTodosLosEmpleadoIds().Contains(codigoemple))
                {
                    try
                    {
                        _ventaLOG = new VentaLOG();
                        Venta venta = new Venta
                        {
                            Fecha = DateTime.Now,
                            Total = decimal.Parse(txtMonto.Text),
                            EmpleadoId = int.Parse(txtCodigoEmpleado.Text)
                        };

                        foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                        {
                            var detalle = new DetalleVenta
                            {
                                ProductoId = int.Parse(row.Cells["Codigo"].Value.ToString()),
                                Precio = decimal.Parse(row.Cells["Precio"].Value.ToString()),
                                Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString())
                            };
                            venta.Detalles.Add(detalle);
                        }

                        int resultado = _ventaLOG.GuardarVenta(venta);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Venta Guardada con Éxito", "Vapesney | Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Limpiar los campos
                            txtCodigo.Text = "";
                            txtCantidad.Text = "";
                            txtMonto.Text = "";

                            // Limpiar el DataTable y actualizar el DataGridView
                            detalleVenta.Clear();
                            dgvDetalleVenta.DataSource = detalleVenta;
                            CargarProductos();
                        }
                        else
                        {
                            MessageBox.Show("No se logró guardar la venta", "Vapeney | Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un Error", "Vapeney | Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El empleado seleccionado no existe, por favor seleccione otro empleado", "Vapeney | Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoEmpleado.Focus();
                    txtCodigoEmpleado.BackColor = Color.LightYellow;
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún empleado", "Vapeney | Venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoEmpleado.Focus();
                txtCodigoEmpleado.BackColor = Color.LightYellow;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodigoEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

            if (isUpdating) return;

            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                _productoLOG = new ProductoLOG();

                if (int.TryParse(txtCodigo.Text, out int codigo))
                {
                    var producto = _productoLOG.ObtenerProductoSegunId(codigo);
                    var nombreproduc = _productoLOG.ExtraerNombreProducto(codigo);
                    var existencias = _productoLOG.ExtraerExistenciasProduc(codigo);
                    var precio = _productoLOG.ExtraerPrecioProduc(codigo);

                    if (producto != null && producto.Estado == true)
                    {
                        isUpdating = true;
                        cbxNombreProd.Text = nombreproduc;
                        txtExistencias.Text = existencias;
                        txtPrecio.Text = precio;
                        isUpdating = false;
                    }
                    else
                    {
                        txtExistencias.Text = "";
                        txtPrecio.Text = "";
                        cbxNombreProd.Text = "";
                    }
                }
                else
                {
                    txtExistencias.Text = "";
                    txtPrecio.Text = "";
                    cbxNombreProd.Text = "";
                }
            }
            else
            {
                cbxNombreProd.Text = "";
                txtExistencias.Text = "";
                txtPrecio.Text = "";
            }
        }

        private void cbxNombreProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            if (cbxNombreProd.SelectedIndex != -1)
            {
                isUpdating = true;

                var producto = (Producto)cbxNombreProd.SelectedItem;
                if (producto != null)
                {
                    txtCodigo.Text = producto.ProductoId.ToString();
                }

                isUpdating = false;
            }
        }

        private void cbxNombremple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            if (cbxNombreEmple.SelectedIndex != -1)
            {
                isUpdating = true;

                var empleado = (Empleado)cbxNombreEmple.SelectedItem;
                if (empleado != null)
                {
                    txtCodigoEmpleado.Text = empleado.EmpleadoId.ToString();
                }

                isUpdating = false;
            }
        }
        private int count = 0;
        private void txtCodigoEmple_TextChanged(object sender, EventArgs e)
        {
            if (count == 0)
            {
                txtCodigoEmpleado.Text = "";
                count++;
            }

            if (isUpdating) return;

            if (!string.IsNullOrEmpty(txtCodigoEmpleado.Text))
            {
                _empleadoLOG = new EmpleadoLOG();

                if (int.TryParse(txtCodigoEmpleado.Text, out int codigo))
                {
                    var empleado = _empleadoLOG.ObtenerEmpleadoPorId(codigo);

                    if (empleado != null)
                    {
                        isUpdating = true;
                        cbxNombreEmple.Text = empleado.Nombre;
                        isUpdating = false;
                    }
                    else
                    {
                        cbxNombreEmple.Text = "";
                    }
                }
                else
                {
                    cbxNombreEmple.Text = "";
                }
            }
            else
            {
                LimpiarEmpleado();
            }
        }

        private void dgvDetalleVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    bool precioValido = decimal.TryParse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Precio"].Value.ToString(), out decimal precio);
                    int cantidad = int.Parse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());

                    if (precioValido && cantidad > 0)
                    {
                        decimal SubTotal = precio * cantidad;
                        dgvDetalleVenta.Rows[e.RowIndex].Cells["SubTotal"].Value = SubTotal;

                        CalcularMontoTotal();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un precio válido");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void CalcularMontoTotal()
        {
            decimal montoTotal = 0;

            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
            }

            txtMonto.Text = montoTotal.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarProducto()
        {
            isUpdating = true;
            cbxNombreProd.SelectedIndex = -1;
            txtCodigo.Text = "";
            txtExistencias.Text = "";
            txtPrecio.Text = "";
            isUpdating = false;
        }

        private void LimpiarEmpleado()
        {
            isUpdating = true;
            cbxNombreEmple.SelectedIndex = -1;
            txtCodigoEmpleado.Text = "";
            isUpdating = false;
        }
    }
}
