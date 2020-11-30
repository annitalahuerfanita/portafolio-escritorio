using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoReal.Vistas
{
    public partial class Disponible : Form
    {
        private ApiPut _apiPut;
        public Disponible()
        {
            InitializeComponent();
            MostrarDepto(false);
            DisableButtons();
            PlaceHolder();
            Colores();
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

        #region EVENTOS
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarDepto(false);
            LimpiarCampos();
            DisableButtons();
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
                EnableButtons();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (rbDisp.Checked)
            {
                MessageBox.Show("No se ha modificado nada, verifique los campos", "¡Error!");
            }
            else
            {
                ModificarDepto();
                LimpiarCampos();
            }
        }

        private void dgDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            dgDisponibles.Rows[e.RowIndex].Selected = true;
            txtBuscar.Text = dgDisponibles.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtBuscar.ForeColor = Color.Black;
            txtDireccion.Text = dgDisponibles.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
            txtBanos.Text = dgDisponibles.Rows[e.RowIndex].Cells["banos"].Value.ToString();
            txtDorm.Text = dgDisponibles.Rows[e.RowIndex].Cells["dormitorios"].Value.ToString();
            txtMetros.Text = dgDisponibles.Rows[e.RowIndex].Cells["metros_cuadrados"].Value.ToString();
            txtPrecio.Text = dgDisponibles.Rows[e.RowIndex].Cells["precio"].Value.ToString();
            cbZona.Text = dgDisponibles.Rows[e.RowIndex].Cells["zona"].Value.ToString();
            EnableButtons();
        }

        private void dgDisponibles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                InventarioDisp disponibles = new InventarioDisp();
                DataGridViewRow rellenar = dgDisponibles.Rows[e.RowIndex];
                disponibles.lbDepto.Text = rellenar.Cells["id"].Value.ToString();
                disponibles.txtDepto.Text = "Inventario de departamento " + rellenar.Cells["direccion"].Value.ToString();
                disponibles.Show();
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
            var response = await RestHelper.MostrarDisponible();
            var result = JsonConvert.DeserializeObject<List<Departamento>>(response);
            dgDisponibles.DataSource = result;
            dgDisponibles.Columns["id"].HeaderText = "Id";
            dgDisponibles.Columns["id"].Width = 28;
            dgDisponibles.Columns["id"].DisplayIndex = 0;
            dgDisponibles.Columns["direccion"].HeaderText = "Dirección";
            dgDisponibles.Columns["direccion"].Width = 156;
            dgDisponibles.Columns["direccion"].DisplayIndex = 1;
            dgDisponibles.Columns["zona"].HeaderText = "Zona";
            dgDisponibles.Columns["zona"].Width = 70;
            dgDisponibles.Columns["zona"].DisplayIndex = 2;
            dgDisponibles.Columns["metros_cuadrados"].HeaderText = "Metros²";
            dgDisponibles.Columns["metros_cuadrados"].Width = 60;
            dgDisponibles.Columns["metros_cuadrados"].DisplayIndex = 3;
            dgDisponibles.Columns["dormitorios"].HeaderText = "Dorms";
            dgDisponibles.Columns["dormitorios"].Width = 50;
            dgDisponibles.Columns["dormitorios"].DisplayIndex = 4;
            dgDisponibles.Columns["banos"].HeaderText = "Baños";
            dgDisponibles.Columns["banos"].Width = 50;
            dgDisponibles.Columns["banos"].DisplayIndex = 5;
            dgDisponibles.Columns["precio"].HeaderText = "Precio";
            dgDisponibles.Columns["precio"].Width = 60;
            dgDisponibles.Columns["precio"].DisplayIndex = 6;
            dgDisponibles.Columns["precio"].DefaultCellStyle.Format = "n0";
            dgDisponibles.Columns["estado_mantencion"].Visible = false;
            //---
            foreach (DataGridViewRow fila in dgDisponibles.Rows)
            {
                fila.Cells["Estado"].Value = "Disponible";
            }
            foreach (DataGridViewRow fila in dgDisponibles.Rows)
            {
                fila.Cells["Inventario"].Value = "       Ver";
            }
            //---

            if (filtro == true)
            {
                dgDisponibles.CurrentCell = null;
                foreach (DataGridViewRow fila in dgDisponibles.Rows)
                {
                    fila.Visible = fila.Cells["id"].Value.ToString().ToUpper().Equals(txtBuscar.Text.ToUpper());
                }
            }
            dgDisponibles.ClearSelection();
        }

        private async void BuscarDepto()
        {
            var response = await RestHelper.BuscarDisponible(txtBuscar.Text);
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
            if (rbMant.Checked)
            {
                depto.estado_mantencion = true;
            }
            string json = JsonConvert.SerializeObject(depto);
            dynamic respuesta = _apiPut.Modificar($"http://192.168.100.50/api/departamentos_disponibles/{txtBuscar.Text}/", json);
            MessageBox.Show($"Departamento {depto.direccion} modificado correctamente", "¡Éxito!");
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
            rbDisp.Enabled = false;
            rbMant.Enabled = false;
            PlaceHolder();
        }

        private void EnableButtons()
        {
            this.txtBanos.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtDorm.Enabled = false;
            this.txtMetros.Enabled = false;
            this.txtPrecio.Enabled = false;
            this.cbZona.Enabled = false;

            this.rbDisp.Enabled = true;
            this.rbMant.Enabled = true;

            this.btnEditar.Visible = true;
            this.lbEdd.Visible = false;
            this.pbDisableEdd.Visible = false;
        }
        private void DisableButtons()
        {
            this.txtBanos.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtDorm.Enabled = false;
            this.txtMetros.Enabled = false;
            this.txtPrecio.Enabled = false;
            this.cbZona.Enabled = false;

            this.rbDisp.Enabled = false;
            this.rbMant.Enabled = false;
            this.rbDisp.Checked = true;

            this.btnEditar.Visible = false;
            this.lbEdd.Visible = true;
            this.pbDisableEdd.Visible = true;
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
            dgDisponibles.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgDisponibles.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
        #endregion
    }
}
