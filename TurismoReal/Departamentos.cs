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
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
        }

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
    }
}
