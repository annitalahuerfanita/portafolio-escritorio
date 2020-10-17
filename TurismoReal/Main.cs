using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
        #endregion

        #region EVENTOS
        private void btnDeptos_Click(object sender, EventArgs e)
        {
            btnDeptos.BackColor = Color.FromArgb(23, 162, 184);
            OpenForm(new Departamentos(), sender);
        }

        private void btnDeptos_Leave(object sender, EventArgs e)
        {
            btnDeptos.BackColor = Color.FromArgb(33, 37, 41);
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            btnFunc.BackColor = Color.FromArgb(23, 162, 184);
            OpenForm(new Funcionarios(), sender);
        }

        private void btnFunc_Leave(object sender, EventArgs e)
        {
            btnFunc.BackColor = Color.FromArgb(33, 37, 41);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            lbTitulo.Text = childForm.Text;

        }

        #endregion
    }
}
