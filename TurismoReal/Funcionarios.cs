using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoReal
{
    public partial class Funcionarios : Form
    {
        private ApiPost _apiPost;
        public Funcionarios()
        {
            InitializeComponent();
            _apiPost = new ApiPost();
        }

        #region EVENTOS
        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.MostrarFunc();
            rtbMostrar.Text = RestHelper.LectorJson(response);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.BuscarFunc(txtBuscar.Text);
            rtbMostrar.Text = RestHelper.LectorJson(response);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarFunc();
            LimpiarCampos();
        }
        #endregion

        #region METODOS
        public class Funcionario
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
            public bool is_active { get; set; }
            public bool is_staff { get; set; }
            public int telefono { get; set; }
            public int edad { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public string password { get; set; }
        }

        private void AgregarFunc()
        {
            Funcionario func = new Funcionario
            {
                first_name = txtNombre.Text,
                last_name = txtApellido.Text,
                is_active =true, 
                is_staff = true,
                telefono = int.Parse(txtFono.Text),
                edad = int.Parse(txtEdad.Text),
                username = txtEmp.Text,
                email = txtCorreo.Text,
                password = txtCont.Text
            };

            string json = JsonConvert.SerializeObject(func);

            dynamic respuesta = _apiPost.Agregar("https://departamentos.pythonanywhere.com/api/usuarios/", json);

            MessageBox.Show("Funcionario agregado correctamente", "Felicidades");
        }

        public void LimpiarCampos()
        {
            this.txtApellido.Text = "";
            this.txtCont.Text = "";
            this.txtCorreo.Text = "";
            this.txtEdad.Text = "";
            this.txtEmp.Text = "";
            this.txtFono.Text = "";
            this.txtNombre.Text = "";
        }
        #endregion
    }
}
