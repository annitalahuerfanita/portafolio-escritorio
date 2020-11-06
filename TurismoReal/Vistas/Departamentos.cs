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
            PlaceHolder();
            rbDisp.Enabled = false;
            rbMant.Enabled = false;
            _apiPost = new ApiPost();
            _apiPut = new ApiPut();
        }
        public class Departamento
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
            if (txtBuscar.Text == "" || txtDireccion.Text == "" || txtMetros.Text == "" || txtDorm.Text == "" || txtBanos.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Verifique los campos", "¡Error!");
            }
            else
            {
                ModificarDepto();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDepto();
        }

        public void OnGetFocus(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Contains(txtBuscar.Tag.ToString()))
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        public void OnLostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar por Id";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void dgDeptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            dgDeptos.Rows[e.RowIndex].Selected = true;
            txtBuscar.Text = dgDeptos.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtBuscar.ForeColor = Color.Black;
            txtDireccion.Text = dgDeptos.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
            txtBanos.Text = dgDeptos.Rows[e.RowIndex].Cells["banos"].Value.ToString();
            txtDorm.Text = dgDeptos.Rows[e.RowIndex].Cells["dormitorios"].Value.ToString();
            txtMetros.Text = dgDeptos.Rows[e.RowIndex].Cells["metros_cuadrados"].Value.ToString();
            txtPrecio.Text = dgDeptos.Rows[e.RowIndex].Cells["precio"].Value.ToString();
            cbZona.Text = dgDeptos.Rows[e.RowIndex].Cells["zona"].Value.ToString();
        }
        #endregion

        #region METODOS
        private async void MostrarDepto(bool filtro)
        {
            var response = await RestHelper.MostrarDepto();
            var result = JsonConvert.DeserializeObject<List<Departamento>>(response);
            dgDeptos.DataSource = result;
            dgDeptos.Columns["id"].HeaderText = "Id";
            dgDeptos.Columns["id"].Width = 28;
            dgDeptos.Columns["id"].DisplayIndex = 0;
            dgDeptos.Columns["direccion"].HeaderText = "Dirección";
            dgDeptos.Columns["direccion"].Width = 156;
            dgDeptos.Columns["direccion"].DisplayIndex = 1;
            dgDeptos.Columns["zona"].HeaderText = "Zona";
            dgDeptos.Columns["zona"].Width = 70;
            dgDeptos.Columns["zona"].DisplayIndex = 2;
            dgDeptos.Columns["metros_cuadrados"].HeaderText = "Metros²";
            dgDeptos.Columns["metros_cuadrados"].Width = 60;
            dgDeptos.Columns["metros_cuadrados"].DisplayIndex = 3;
            dgDeptos.Columns["dormitorios"].HeaderText = "Dorms";
            dgDeptos.Columns["dormitorios"].Width = 50;
            dgDeptos.Columns["dormitorios"].DisplayIndex = 4;
            dgDeptos.Columns["banos"].HeaderText = "Baños";
            dgDeptos.Columns["banos"].Width = 50;
            dgDeptos.Columns["banos"].DisplayIndex = 5;
            dgDeptos.Columns["precio"].HeaderText = "Precio";
            dgDeptos.Columns["precio"].Width = 60;
            dgDeptos.Columns["precio"].DisplayIndex = 6;
            dgDeptos.Columns["precio"].DefaultCellStyle.Format = "n0";
            dgDeptos.Columns["estado_mantencion"].Visible = false;

            //---
            DataGridViewTextBoxColumn Estado = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Inventario = new DataGridViewTextBoxColumn();
            Estado.Name = "Estado";
            Inventario.Name = "Inventario";
            dgDeptos.Columns.Add(Estado);
            dgDeptos.Columns.Add(Inventario);
            foreach (DataGridViewRow fila in dgDeptos.Rows)
            {
                fila.Cells["Estado"].Value = "En mantención";
            }
            dgDeptos.Columns["Estado"].Width = 80;
            dgDeptos.Columns["Estado"].DisplayIndex = 7;
            foreach (DataGridViewRow fila in dgDeptos.Rows)
            {
                fila.Cells["Inventario"].Value = "       Ver";
            }
            dgDeptos.Columns["Inventario"].Width = 80;
            dgDeptos.Columns["Inventario"].DisplayIndex = 8;
            //---

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
            var datos = JsonConvert.DeserializeObject<Departamento>(response);
            this.txtBanos.Text = datos.banos.ToString();
            this.txtDireccion.Text = datos.direccion;
            this.txtDorm.Text = datos.dormitorios.ToString();
            this.txtMetros.Text = datos.metros_cuadrados.ToString();
            this.txtPrecio.Text = datos.precio.ToString();
            this.cbZona.Text = datos.zona;
            this.rbMant.Enabled = true;
            this.rbDisp.Enabled = true;
            if (datos.estado_mantencion == false)
            {
                rbDisp.Checked = true;
            }
            else if (datos.estado_mantencion == true)
            {
                rbMant.Checked = true;
            }
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
            dynamic respuesta = _apiPost.Agregar("http://192.168.100.50/api/departamentos/", json);
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
            dynamic respuesta = _apiPut.Modificar($"http://192.168.100.50/api/departamentos/{txtBuscar.Text}/", json);
            MessageBox.Show($"Departamento{depto.direccion} modificado correctamente", "¡Éxito!");
        }
           
        private async Task<string> Eliminar(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("http://192.168.100.50/api/departamentos/" + id))
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

        public void PlaceHolder()
        {
            txtBuscar.Tag = "Buscar por Id";
            txtBuscar.Text = txtBuscar.Tag.ToString();
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.GotFocus += new EventHandler(OnGetFocus);
            txtBuscar.LostFocus += new EventHandler(OnLostFocus);
        }
        private void cbZona_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion
    }
}
