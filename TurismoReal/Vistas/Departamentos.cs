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
        private ApiPut _apiPut;

        #region CONSTRUCTOR
        public Departamentos()
        {
            InitializeComponent();
            MostrarDepto(false);
            _apiPost = new ApiPost();
            _apiPut = new ApiPut();
        }
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
        public class Departamentoget
        {
            public int id { get; set; }
            public string direccion { get; set; }
            public string zona { get; set; }
            public int banos { get; set; }
            public int dormitorios { get; set; }
            public bool estado_mantencion { get; set; }
            public int precio { get; set; }
            public int metros_cuadrados { get; set; }
        }
        #endregion

        #region EVENTOS
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarDepto(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Ingrese un Id para buscar", "¡Error!");
            }
            else
            {
                BuscarDepto();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "" || txtMetros.Text == "" || txtDorm.Text == "" || txtBanos.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Verifique los campos", "¡Error!");
            }
            else
            {
                AgregarDepto();
                LimpiarCampos();
                MostrarDepto(false);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {            
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Ingrese un Id para editar", "¡Error!");
            }
            else
            {
                ModificarDepto();
                BuscarDepto();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDepto();
        }
        #endregion

        #region METODOS
        private async void MostrarDepto(bool filtro)
        {
            var response = await RestHelper.MostrarDepto();
            var result = JsonConvert.DeserializeObject<List<Departamentoget>>(response);
            dgDeptos.DataSource = result;
            dgDeptos.Columns[0].HeaderText = "id";
            dgDeptos.Columns[0].Width = 30;
            dgDeptos.Columns[1].HeaderText = "Dirección";
            dgDeptos.Columns[1].Width = 150;
            dgDeptos.Columns[2].HeaderText = "Zona";
            dgDeptos.Columns[2].Width = 70;
            dgDeptos.Columns[3].HeaderText = "Baños";
            dgDeptos.Columns[3].Width = 70;
            dgDeptos.Columns[4].HeaderText = "Dormitorios";
            dgDeptos.Columns[4].Width = 70;
            dgDeptos.Columns[5].Visible = false;
            dgDeptos.Columns[6].HeaderText = "Precio";
            dgDeptos.Columns[6].Width = 70;
            if (filtro == true)
            {
                dgDeptos.CurrentCell = null;
                foreach (DataGridViewRow fila in dgDeptos.Rows)
                {
                    fila.Visible = fila.Cells["id"].Value.ToString().ToUpper().Equals(txtBuscar.Text.ToUpper());
                }
            }
        }

        private async void BuscarDepto()
        {
            var response = await RestHelper.BuscarDepto(txtBuscar.Text);
            //rtbMostrar.Text = RestHelper.LectorJson(response);
            var datos = JsonConvert.DeserializeObject<Departamento>(response);
            this.txtBanos.Text = datos.banos.ToString();
            this.txtDireccion.Text = datos.direccion;
            this.txtDorm.Text = datos.dormitorios.ToString();
            this.txtMetros.Text = datos.metros_cuadrados.ToString();
            this.txtPrecio.Text = datos.precio.ToString();
            this.cbZona.Text = datos.zona;
            MostrarDepto(true);
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
            MessageBox.Show($"Departamento {depto.direccion} agregado correctamente", "¡Éxito!");
        }

        private void ModificarDepto()
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
            dynamic respuesta = _apiPut.Modificar($"https://departamentos.pythonanywhere.com/api/departamentos/{txtBuscar.Text}/", json);
            MessageBox.Show($"Departamento{depto.direccion} modificado correctamente", "¡Éxito!");
        }
           
        private async Task<string> Eliminar(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("https://departamentos.pythonanywhere.com/api/departamentos/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show($"Departamento {txtDireccion.Text} eliminado correctamente", "¡Éxito!");
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

        public async void EliminarDepto()
        {
            var response = await Eliminar(txtBuscar.Text);
            LimpiarCampos();
            MostrarDepto(false);
        }

        public void LimpiarCampos()
        {
            this.txtBuscar.Text = "";
            this.txtBanos.Text = "";
            this.txtDireccion.Text = "";
            this.txtDorm.Text = "";
            this.txtMetros.Text = "";
            this.txtPrecio.Text = "";
            this.cbZona.Text = "Seleccionar zona";
        }
        #endregion
    }
}
