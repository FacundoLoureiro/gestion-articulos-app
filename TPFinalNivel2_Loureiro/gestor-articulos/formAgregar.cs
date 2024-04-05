using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Windows.Forms;
using dominio;
using datos;

namespace gestor_articulos
{
    public partial class formAgregar : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public formAgregar()
        {
            InitializeComponent();
            btnMinimizarAlta.Click += btnMinimizarAlta_Click;
        }
        public formAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;   

        }

        private void btnCerrarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticulosDatos datosArticulos = new ArticulosDatos();
            try
            {
                if(articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marcas)cbxMarca.SelectedItem;
                articulo.Categoria = (Categorias)cbxCategoria.SelectedItem;

                if(articulo.Id != 0)
                {
                    datosArticulos.modificar(articulo);
                    MessageBox.Show("Articulo modificado correctamente");
                }
                else
                {
                    datosArticulos.agregar(articulo);
                    MessageBox.Show("Articulo agregado correctamente");
                }
                if (archivo != null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["imagen-local"] + archivo.SafeFileName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Close();
            
        }

        private void formAgregar_Load(object sender, EventArgs e)
        {   
            CategoriaDatos datosCategoria = new CategoriaDatos();
            MarcaDatos datosMarca = new MarcaDatos();
            try
            {
                cbxMarca.DataSource = datosMarca.listar();
                cbxMarca.ValueMember = "id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = datosCategoria.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
            { 
              try
               {
                  pictureBoxAgregar.Load(imagen);

               }
              catch (Exception)
               {

                  pictureBoxAgregar.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg"); ;
               }
            }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImagenLocal_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            try
            {
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    txtImagenUrl.Text = archivo.FileName;
                    cargarImagen(archivo.FileName);

                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["imagen-local"] + archivo.SafeFileName);
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }      
         }

        private void btnMinimizarAlta_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

