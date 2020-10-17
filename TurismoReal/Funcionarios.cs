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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            {
                var response = await RestHelper.MostrarFunc();
                rtbMostrar.Text = RestHelper.LectorJson(response);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.BuscarFunc(txtBuscar.Text);
            rtbMostrar.Text = RestHelper.LectorJson(response);
        }
    }
}
