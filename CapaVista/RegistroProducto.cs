using CapaEntidades;
using CapaLogica;
using System;
using System.CodeDom;
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
    public partial class RegistroProducto : Form
    {
        ProductoLOG _productoLOG;
        CategoriaLOG _categoriaLOG;
        FabricanteLOG _fabricanteLOG;

        int _id = 0;

        public RegistroProducto(int id = 0)
        {
            InitializeComponent();

            _id = id;

            if (_id > 0)
            {
                this.Text = "Vapes | Edición de Producto";
                btnGuardar.Text = "Actualizar";

                CargarDatos(_id);
            }
            else
            {
                MostrarFabricanteYCategorias();
                productoBindingSource.MoveLast();
                productoBindingSource.AddNew();
            }            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarProducto()
        {
            try
            {
                _productoLOG = new ProductoLOG();

                //throw new Exception();
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Se requiere el nombre del producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                    return;
                }

                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Se requiere la descripción del producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtPrecioUnitario.Text) || Convert.ToDecimal(txtPrecioUnitario.Text) == 0)
                {
                    MessageBox.Show("Se requiere el precio del producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtExistencias.Text) || Convert.ToDecimal(txtExistencias.Text) == 0)
                {
                    MessageBox.Show("Se requiere agregar existencias del producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!chkEstado.Checked)
                {
                    var dialogo = MessageBox.Show("¿Esta seguro que desea guardar el producto inactivo","Tienda | Registro Productos",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro Estado como activo", "Tienda | Registro Productos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (_id > 0)
                {
                    int codigo = _id;
                    _productoLOG = new ProductoLOG();
                    var nombreProduc = _productoLOG.ExtraerNombreProduc(codigo);

                    if (nombreProduc == txtNombre.Text)
                    {

                    }

                    else if (!_productoLOG.ObtenerNombre().Contains(txtNombre.Text))
                    {

                    }
                    else if (_productoLOG.ObtenerNombre().Contains(txtNombre.Text))
                    {
                        MessageBox.Show("El Nombre del producto ya existe. Por favor, elija otro nombre.", "Vapesney | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNombre.Focus();
                        txtNombre.BackColor = Color.LightYellow;
                        return;
                    }

                }
                else
                {
                    _productoLOG = new ProductoLOG();

                    if (NombreExiste(txtNombre.Text))
                    {
                        MessageBox.Show("El Nombre del producto ya existe. Por favor, elija otro nombre.", "Vapesney | Registro Fabricante",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNombre.Focus();
                        txtNombre.BackColor = Color.LightYellow;
                        return;
                    }

                }

                int resultado;

                if (_id > 0)
                {
                    Producto producto;

                    producto = (Producto)productoBindingSource.Current;

                    resultado = _productoLOG.ActualizarProducto(producto, _id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto actualizado con exito", "Tienda | Registro Productos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro acutalizar el producto", "Tienda | Registro Productos",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    productoBindingSource.EndEdit();

                    Producto producto;
                    producto = (Producto)productoBindingSource.Current;

                    resultado = _productoLOG.GuardarProducto(producto);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto agregado con exito", "Tienda | Registro Productos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar el producto", "Tienda | Registro Productos",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un Error","Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool NombreExiste(string text)
        {
            List<Producto> productos = _productoLOG.ObtenerProductos();


            foreach (Producto producto in productos)
            {
                if (string.Equals(producto.Nombre, text, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void CargarDatos(int id)
        {
            _productoLOG = new ProductoLOG();
            productoBindingSource.DataSource = _productoLOG.ObtenerProductoPorId(id);
            MostrarFabricanteYCategorias();
        }

        private void MostrarFabricanteYCategorias()
        {
            _categoriaLOG = new CategoriaLOG();
            cmbCategorias.DataSource = _categoriaLOG.ObtenerTodasCategorias();
            cmbCategorias.DisplayMember = "NombreCategoria";
            cmbCategorias.ValueMember = "CategoriaId";
            cmbCategorias.SelectedIndex = -1;

            _fabricanteLOG = new FabricanteLOG();
            cmbFabricante.DataSource = _fabricanteLOG.ObtenerTodosFabricantes();
            cmbFabricante.DisplayMember = "NombreFabricante";
            cmbFabricante.ValueMember = "FabricanteId";
            cmbFabricante.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroFabricante objRegistroFabri = new RegistroFabricante();
            objRegistroFabri.ShowDialog();
            MostrarFabricanteYCategorias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroCategoria objRegistroCate = new RegistroCategoria();
            objRegistroCate.ShowDialog();
            MostrarFabricanteYCategorias();
        }
    }
}
