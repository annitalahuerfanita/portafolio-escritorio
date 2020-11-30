using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoReal.Vistas
{
    public partial class InventarioMant : Form
    {
        private ApiPost _apiPost;
        private ApiPut _apiPut;
        #region CONSTRUCTOR
        public InventarioMant()
        {
            InitializeComponent();
            MostrarInv();
            EnableButtons();
            Colores();
            Titulo();
            _apiPost = new ApiPost();
            _apiPut = new ApiPut();
        }

        public class Inventario
        {
            public int id { get; set; }
            public int departamento { get; set; }
            public string nombre { get; set; }
            public string estado { get; set; }
            public int precio { get; set; }
        }
        #endregion

        #region EVENTOS
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEstado_Click(object sender, EventArgs e)
        {
            CambiarEstado();
            MostrarInv();
            EnableButtons();
            LimpiarCampos();

            //dgInventario.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(136, 208, 228);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Seleccione un departamento para eliminar", "¡Error!");
            }
            else
            {
                EliminarInv();
                EnableButtons();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Verifique los campos", "¡Error!");
            }
            else
            {
                AgregarInv();
                LimpiarCampos();
                MostrarInv();
            }
        }

        private void pbDisableAgg_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            EnableButtons();
        }

        private void lbAgg_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            EnableButtons();
        }

        private void dgInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            dgInventario.Rows[e.RowIndex].Selected = true;
            txtNombre.Text = dgInventario.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txtPrecio.Text = dgInventario.Rows[e.RowIndex].Cells["precio"].Value.ToString();
            lbObjeto.Text = dgInventario.Rows[e.RowIndex].Cells["id"].Value.ToString();
            lbEstado.Text = dgInventario.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            DisableButtons();
        }
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region METODOS
        private async void MostrarInv()
        {
            var response = await RestHelper.MostrarInventario();
            var result = JsonConvert.DeserializeObject<List<Inventario>>(response);
            dgInventario.DataSource = result;
            dgInventario.Columns["id"].HeaderText = "Id";
            dgInventario.Columns["id"].Width = 30;
            dgInventario.Columns["id"].DisplayIndex = 0;
            dgInventario.Columns["nombre"].HeaderText = "Nombre";
            dgInventario.Columns["nombre"].Width = 156;
            dgInventario.Columns["nombre"].DisplayIndex = 1;
            dgInventario.Columns["precio"].HeaderText = "Precio";
            dgInventario.Columns["precio"].Width = 80;
            dgInventario.Columns["precio"].DisplayIndex = 2;
            dgInventario.Columns["precio"].DefaultCellStyle.Format = "n0";
            dgInventario.Columns["estado"].HeaderText = "Estado";
            dgInventario.Columns["estado"].Width = 84;
            dgInventario.Columns["estado"].DisplayIndex = 3;
            dgInventario.Columns["departamento"].Visible = false;
            foreach (DataGridViewRow r in dgInventario.Rows)
            {
                if ((r.Cells["departamento"].Value).ToString().ToUpper().Equals(lbDepto.Text.ToUpper()))
                {
                    dgInventario.Rows[r.Index].Visible = true;
                    dgInventario.Rows[r.Index].Selected = true;
                }
                else
                {
                    dgInventario.CurrentCell = null;
                    dgInventario.Rows[r.Index].Visible = false;
                }
            }
            dgInventario.ClearSelection();
        }

        private void AgregarInv()
        {
            Inventario inv = new Inventario
            {
                departamento = int.Parse(lbDepto.Text),
                estado = "Buen estado",
                nombre = txtNombre.Text,
                precio = int.Parse(txtPrecio.Text)
            };
            string json = JsonConvert.SerializeObject(inv);
            dynamic respuesta = _apiPost.Agregar("http://192.168.100.50/api/inventario/", json);
            MessageBox.Show($"Objeto {inv.nombre} agregado correctamente", "¡Éxito!");
        }

        private void CambiarEstado()
        {
            Inventario inv = new Inventario
            {
                departamento = int.Parse(lbDepto.Text),
                estado = lbEstado.Text,
                nombre = txtNombre.Text,
                precio = int.Parse(txtPrecio.Text)
            };
            if (lbEstado.Text == "Buen estado")
            {
                inv.estado = "Mal estado";
            }
            else 
            {
                inv.estado = "Buen estado";
            }
            string json = JsonConvert.SerializeObject(inv);
            dynamic respuesta = _apiPut.Modificar($"http://192.168.100.50/api/inventario/{lbObjeto.Text}/", json);
            MessageBox.Show($"Objeto {inv.nombre} modificado correctamente", "¡Éxito!");
            MostrarInv();
        }

        private async Task<string> Eliminar(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("http://192.168.100.50/api/inventario/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show($"Objeto {txtNombre.Text} eliminado correctamente", "¡Éxito!");
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
        public async void EliminarInv()
        {
            var response = await Eliminar(lbObjeto.Text);
            LimpiarCampos();
            MostrarInv();
        }

        public void LimpiarCampos()
        {
            this.txtNombre.Text = "";
            this.txtPrecio.Text = "";
        }

        private void EnableButtons()
        {
            this.txtNombre.Enabled = true;
            this.txtPrecio.Enabled = true;

            this.btnAgregar.Visible = true;
            this.lbAgg.Visible = false;
            this.pbDisableAgg.Visible = false;

            this.btnEstado.Visible = false;
            this.pbDisableEss.Visible = true;

            this.btnEliminar.Visible = false;
            this.pbDisableEll.Visible = true;
        }
        private void DisableButtons()
        {
            this.txtNombre.Enabled = false;
            this.txtPrecio.Enabled = false;

            this.btnAgregar.Visible = false;
            this.lbAgg.Visible = true;
            this.pbDisableAgg.Visible = true;

            this.btnEstado.Visible = true;
            this.pbDisableEss.Visible = false;

            this.btnEliminar.Visible = true;
            this.pbDisableEll.Visible = false;
        }

        private void Colores()
        {
            dgInventario.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgInventario.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void Titulo()
        {
            txtDepto.BorderStyle = BorderStyle.None;
            this.txtDepto.ReadOnly = true;
            //this.txtDepto.BackColor = Color.FromArgb(248, 249, 250);
            //this.txtDepto.ForeColor = Color.Black;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        #endregion
    }
}
