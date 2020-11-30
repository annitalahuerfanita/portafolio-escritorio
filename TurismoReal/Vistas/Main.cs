using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TurismoReal.Vistas;

namespace TurismoReal
{
    public partial class Main : Form
    {
        #region CAMPOS
        private Form activeForm;
        #endregion

        #region CONSTRUCTOR
        public Main()
        {
            InitializeComponent();
            lbTitulo.Visible = true;
        }
        #endregion

        #region EVENTOS
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            btnFunc.BackColor = Color.FromArgb(23, 162, 184);
            colorFunc.Visible = true;
            colorDeptos.Visible = false;
            colorMant.Visible = false;
            colorDisp.Visible = false;
            panelSubmenu.Visible = false;
            lbDeptos.Visible = false;
            lbFunc.Visible = true;
            lbTitulo.Visible = false;
            OpenForm(new Funcionarios(), sender);
        }

        private void btnDeptos_Click(object sender, EventArgs e)
        {
            btnDeptos.BackColor = Color.FromArgb(23, 162, 184);
            colorFunc.Visible = false;
            colorDeptos.Visible = true;
            colorMant.Visible = false;
            colorDisp.Visible = false;
            lbDeptos.Visible = true;
            lbFunc.Visible = false;
            lbTitulo.Visible = false;
            if(panelSubmenu.Visible == true)
            {
                panelSubmenu.Visible = false;
            }
            else if (panelSubmenu.Visible == false)
            {
                panelSubmenu.Visible = true;
            }
        }
        private void btnMantencion_Click(object sender, EventArgs e)
        {
            btnMantencion.BackColor = Color.FromArgb(23, 162, 184);
            colorFunc.Visible = false;
            colorDeptos.Visible = true;
            colorMant.Visible = true;
            colorDisp.Visible = false;
            OpenForm(new Mantencion(), sender);
        }

        private void btnDisponibles_Click(object sender, EventArgs e)
        {
            btnDisponibles.BackColor = Color.FromArgb(23, 162, 184);
            colorFunc.Visible = false;
            colorDeptos.Visible = true;
            colorMant.Visible = false;
            colorDisp.Visible = true;
            OpenForm(new Disponible(), sender);
        }

        private void btnFunc_Leave(object sender, EventArgs e)
        {
            btnFunc.BackColor = Color.FromArgb(33, 37, 41);
        }

        private void btnDeptos_Leave(object sender, EventArgs e)
        {
            btnDeptos.BackColor = Color.FromArgb(33, 37, 41);
        }

        private void btnMantencion_Leave(object sender, EventArgs e)
        {
            btnMantencion.BackColor = Color.FromArgb(33, 37, 41);
        }

        private void btnDisponibles_Leave(object sender, EventArgs e)
        {
            btnDisponibles.BackColor = Color.FromArgb(33, 37, 41);
        }
        #endregion

        #region METODOS
        private void OpenForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelCentral.Controls.Add(childForm);
            this.panelCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            InventarioDisp dips = new InventarioDisp();
            dips.Show();
        }
    }
}
