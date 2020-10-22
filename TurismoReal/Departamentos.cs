using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoReal
{
    public partial class Departamentos : Form
    {
        private ApiPost _apiPost;
        public Departamentos()
        {
            InitializeComponent();
            _apiPost = new ApiPost();
        }

        #region EVENTOS
        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.MostrarDepto();
            rtbMostrar.Text = RestHelper.LectorJson(response);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.BuscarDepto(txtBuscar.Text);
            rtbMostrar.Text = RestHelper.LectorJson(response);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDepto();
            LimpiarCampos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var response = await EliminarDepto(txtBuscar.Text);
            rtbMostrar.Text = response;
        }
        #endregion

        #region METODOS
        public class Departamento
        {
            public string direccion { get; set; }
            public string zona { get; set; }
            public int banos { get; set; }
            public int dormitorios { get; set; }
            public bool estado_mantencion { get; set; }
            public int precio { get; set; }
            public int metros_cuadrados { get; set; }
        }
        private void AgregarDepto()
        {
            Departamento depto = new Departamento
            {
                direccion = txtDireccion.Text,
                zona = cbZona.Text,
                banos = int.Parse(txtBanos.Text),
                dormitorios = int.Parse(txtDorm.Text),
                estado_mantencion = true,
                precio = int.Parse(txtPrecio.Text),
                metros_cuadrados = int.Parse(txtMetros.Text)
            };

            string json = JsonConvert.SerializeObject(depto);

            dynamic respuesta = _apiPost.Agregar("https://departamentos.pythonanywhere.com/api/departamentos/", json);

            MessageBox.Show("Departamento agregado correctamente", "Felicidades");
        }

        private async Task<string> EliminarDepto(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("https://departamentos.pythonanywhere.com/api/departamentos/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show("Departamento eliminado correctamente", "Felicidades");
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public void LimpiarCampos ()
        {
            this.txtBanos.Text = "";
            this.txtDireccion.Text = "";
            this.txtDorm.Text = "";
            this.txtMetros.Text = "";
            this.txtPrecio.Text = "";
            this.cbZona.Text = " Seleccionar zona";
        }
        #endregion
    }
}
