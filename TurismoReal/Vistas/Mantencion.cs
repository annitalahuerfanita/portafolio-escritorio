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
using TurismoReal.Vistas;

namespace TurismoReal
{
    public partial class Mantencion : Form
    {
        private ApiPost _apiPost;
        private ApiPut _apiPut;

        #region CONSTRUCTOR
        public Mantencion()
        {
            InitializeComponent();
            MostrarDepto(false);
            EnableButtons();
            PlaceHolder();
            Colores();
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
            LimpiarCampos();
            EnableButtons();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar por Id")
            {
                MessageBox.Show("Ingrese un Id para buscar", "¡Error!");
            }
            else
            {
                BuscarDepto();
                DisableButtons();
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
                EnableButtons();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Seleccione un departamento para eliminar", "¡Error!");
            }
            else
            {
                EliminarDepto();
                EnableButtons();
            }
        }

        private void cbZona_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgDeptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            dgMantencion.Rows[e.RowIndex].Selected = true;
            txtBuscar.Text = dgMantencion.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtBuscar.ForeColor = Color.Black;
            txtDireccion.Text = dgMantencion.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
            txtBanos.Text = dgMantencion.Rows[e.RowIndex].Cells["banos"].Value.ToString();
            txtDorm.Text = dgMantencion.Rows[e.RowIndex].Cells["dormitorios"].Value.ToString();
            txtMetros.Text = dgMantencion.Rows[e.RowIndex].Cells["metros_cuadrados"].Value.ToString();
            txtPrecio.Text = dgMantencion.Rows[e.RowIndex].Cells["precio"].Value.ToString();
            cbZona.Text = dgMantencion.Rows[e.RowIndex].Cells["zona"].Value.ToString();            
            DisableButtons();
        }

        private void dgDeptos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                InventarioMant mantencion = new InventarioMant();
                DataGridViewRow rellenar = dgMantencion.Rows[e.RowIndex];
                mantencion.lbDepto.Text = rellenar.Cells["id"].Value.ToString();
                mantencion.txtDepto.Text = "Inventario de departamento " + rellenar.Cells["direccion"].Value.ToString();
                mantencion.Show();
            }
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
        #endregion

        #region METODOS
        private async void MostrarDepto(bool filtro)
        {
            var response = await RestHelper.MostrarMantencion();
            var result = JsonConvert.DeserializeObject<List<Departamento>>(response);
            dgMantencion.DataSource = result;
            dgMantencion.Columns["id"].HeaderText = "Id";
            dgMantencion.Columns["id"].Width = 28;
            dgMantencion.Columns["id"].DisplayIndex = 0;
            dgMantencion.Columns["direccion"].HeaderText = "Dirección";
            dgMantencion.Columns["direccion"].Width = 156;
            dgMantencion.Columns["direccion"].DisplayIndex = 1;
            dgMantencion.Columns["zona"].HeaderText = "Zona";
            dgMantencion.Columns["zona"].Width = 70;
            dgMantencion.Columns["zona"].DisplayIndex = 2;
            dgMantencion.Columns["metros_cuadrados"].HeaderText = "Metros²";
            dgMantencion.Columns["metros_cuadrados"].Width = 60;
            dgMantencion.Columns["metros_cuadrados"].DisplayIndex = 3;
            dgMantencion.Columns["dormitorios"].HeaderText = "Dorms";
            dgMantencion.Columns["dormitorios"].Width = 50;
            dgMantencion.Columns["dormitorios"].DisplayIndex = 4;
            dgMantencion.Columns["banos"].HeaderText = "Baños";
            dgMantencion.Columns["banos"].Width = 50;
            dgMantencion.Columns["banos"].DisplayIndex = 5;
            dgMantencion.Columns["precio"].HeaderText = "Precio";
            dgMantencion.Columns["precio"].Width = 60;
            dgMantencion.Columns["precio"].DisplayIndex = 6;
            dgMantencion.Columns["precio"].DefaultCellStyle.Format = "n0";
            dgMantencion.Columns["estado_mantencion"].Visible = false;

            //---
            foreach (DataGridViewRow fila in dgMantencion.Rows)
            {
                fila.Cells["Estado"].Value = "En mantención";
            }
            foreach (DataGridViewRow fila in dgMantencion.Rows)
            {
                fila.Cells["Inventario"].Value = "       Ver";
            }
            //---

            if (filtro == true)
            {
                dgMantencion.CurrentCell = null;
                foreach (DataGridViewRow fila in dgMantencion.Rows)
                {
                    fila.Visible = fila.Cells["id"].Value.ToString().ToUpper().Equals(txtBuscar.Text.ToUpper());
                }
            }
            dgMantencion.ClearSelection();
        }

        private async void BuscarDepto()
        {
            var response = await RestHelper.BuscarMantencion(txtBuscar.Text);
            var datos = JsonConvert.DeserializeObject<Departamento>(response);
            this.txtBanos.Text = datos.banos.ToString();
            this.txtDireccion.Text = datos.direccion;
            this.txtDorm.Text = datos.dormitorios.ToString();
            this.txtMetros.Text = datos.metros_cuadrados.ToString();
            this.txtPrecio.Text = datos.precio.ToString();
            this.cbZona.Text = datos.zona;
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
            dynamic respuesta = _apiPost.Agregar("http://192.168.100.50/api/departamentos_mantencion/", json);
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
            if (rbDisp.Checked)
            {
                depto.estado_mantencion = false;
                MostrarDepto(false);
            }
            else
            {
                MostrarDepto(true);
            }
            string json = JsonConvert.SerializeObject(depto);
            dynamic respuesta = _apiPut.Modificar($"http://192.168.100.50/api/departamentos_mantencion/{txtBuscar.Text}/", json);
            MessageBox.Show($"Departamento {depto.direccion} modificado correctamente", "¡Éxito!");
        }
           
        private async Task<string> Eliminar(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("http://192.168.100.50/api/departamentos_mantencion/" + id))
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
            this.txtBanos.Text = "";
            this.txtDireccion.Text = "";
            this.txtDorm.Text = "";
            this.txtMetros.Text = "";
            this.txtPrecio.Text = "";
            this.cbZona.Text = "Seleccionar zona";
            this.rbDisp.Enabled = false;
            this.rbMant.Enabled = false;
            this.rbMant.Checked = true;
            PlaceHolder();
        }
                
        private void EnableButtons()
        {
            this.rbDisp.Enabled = false;
            this.rbMant.Enabled = false;
            this.rbMant.Checked = true;

            this.btnAgregar.Visible = true;
            this.lbAgg.Visible = false;
            this.pbDisableAgg.Visible = false;

            this.btnEditar.Visible = false;
            this.pbDisableEdd.Visible = true;

            this.btnEliminar.Visible = false;
            this.pbDisableEll.Visible = true;
        }
        private void DisableButtons()
        {
            rbDisp.Enabled = true;
            rbMant.Enabled = true;

            this.btnAgregar.Visible = false;
            this.lbAgg.Visible = true;
            this.pbDisableAgg.Visible = true;

            this.btnEditar.Visible = true;
            this.pbDisableEdd.Visible = false;

            this.btnEliminar.Visible = true;
            this.pbDisableEll.Visible = false;
        }

        public void PlaceHolder()
        {
            txtBuscar.Tag = "Buscar por Id";
            txtBuscar.Text = txtBuscar.Tag.ToString();
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.GotFocus += new EventHandler(OnGetFocus);
            txtBuscar.LostFocus += new EventHandler(OnLostFocus);
        }

        private void Colores()
        {
            dgMantencion.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgMantencion.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
        #endregion
    }
}
