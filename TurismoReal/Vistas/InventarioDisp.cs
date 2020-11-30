using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoReal.Vistas
{
    public partial class InventarioDisp : Form
    {
        #region CONSTRUCTOR
        public InventarioDisp()
        {
            InitializeComponent();
            MostrarInv();
            Colores();
            Bordetxt();
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

        private void Colores()
        {
            dgInventario.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgInventario.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void Bordetxt()
        {
            txtDepto.BorderStyle = BorderStyle.None;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        #endregion
    }
}
