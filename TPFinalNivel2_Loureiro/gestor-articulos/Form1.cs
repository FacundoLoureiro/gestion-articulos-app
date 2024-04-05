
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using datos;
using System.Drawing.Text;


namespace gestor_articulos
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
            btnMinimizarApp.Click += btnMinimizarApp_Click;
            btnMaximizarApp.Click += btnMaximizarApp_Click;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }
        private void cargarImagen (string imagen)
        {
            try
            {
                pcbArticulos.Load(imagen);
            }
            catch (Exception)
            {

                pcbArticulos.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void cargar()
        {
            ArticulosDatos datos = new ArticulosDatos();
            try
            {
                listaArticulos = datos.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizarApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cbxCampo.Items.Add("Precio");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripcion");
            cargar();
        }
        private void ocultarColumnas()
        {
            if (dgvArticulos != null)
            {
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formAgregar alta = new formAgregar();
            alta.ShowDialog();
            ocultarColumnas();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            formAgregar modificar = new formAgregar(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosDatos datos = new ArticulosDatos();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Se eliminara el articulo seleccionado", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;                  
                    datos.borrar(seleccionado.Id);
                    cargar();
                    MessageBox.Show("Se ha eliminado correctamente");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private bool validarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el campo para seguir");
                return true;
            }
            if (cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el criterio para seguir");
                return true;
            }
            if (cbxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Cargar el filtro para numerico");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo numeros");
                    return true;
                }
            }
            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text;
            try
            {
                if (filtro != "")
                {
                    listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaFiltrada = listaArticulos;
                }

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            ArticulosDatos datos = new ArticulosDatos();          
            try
            {
                if (validarFiltro())
                    return;
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;              
                dgvArticulos.DataSource = datos.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Igual a");
                cbxCriterio.Items.Add("Menor a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }

        }

       
    }
}
