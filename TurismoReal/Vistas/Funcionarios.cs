using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoReal
{
    public partial class Funcionarios : Form
    {
        private ApiPost _apiPost;
        private ApiPut _apiPut;

        #region CONSTRUCTOR
        public Funcionarios()
        {
            InitializeComponent();
            MostrarFunc(false);
            rbActivo.Enabled = false;
            rbInactivo.Enabled = false;
            _apiPost = new ApiPost();
            _apiPut = new ApiPut();
        }
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
        public class Funcionarioget
        {
            public int id { get; set; }
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
        #endregion

        #region EVENTOS
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarFunc(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Ingrese un Id para buscar", "¡Error!");
            }
            else
            {
                BuscarFunc();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtFono.Text == "" || txtEdad.Text == "" || txtEmp.Text == "" || txtCorreo.Text == "" || txtCont.Text == "")
            {
                MessageBox.Show("Verifique los campos", "¡Error!");
            }
            else
            {
                AgregarFunc();
                LimpiarCampos();
                MostrarFunc(false);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Ingrese un Id para editar", "¡Error!");
            }
            else
            {
                ModificarFunc();
                LimpiarCampos();
            }
        }
        #endregion

        #region METODOS 

    
        private async void MostrarFunc(bool filtro)
        {
            var response = await RestHelper.MostrarFunc();
            var result = JsonConvert.DeserializeObject<List<Funcionarioget>>(response);
            dgFunc.DataSource = result;
            dgFunc.Columns[0].HeaderText = "id";
            dgFunc.Columns[0].Width = 30;
            dgFunc.Columns[1].HeaderText = "Nombre";
            dgFunc.Columns[1].Width = 100;
            dgFunc.Columns[2].HeaderText = "Apellido";
            dgFunc.Columns[2].Width = 100;
            dgFunc.Columns[3].HeaderText = "Estado";
            dgFunc.Columns[3].Width = 50;
            dgFunc.Columns[4].Visible = false;
            dgFunc.Columns[5].HeaderText = "Teléfono";
            dgFunc.Columns[5].Width = 80;
            dgFunc.Columns[6].HeaderText = "Edad";
            dgFunc.Columns[6].Width = 50;
            dgFunc.Columns[7].HeaderText = "Correo personal";
            dgFunc.Columns[7].Width = 100;
            dgFunc.Columns[8].HeaderText = "Correo empresarial";
            dgFunc.Columns[8].Width = 100;
            dgFunc.Columns[9].HeaderText = "Contraseña";
            dgFunc.Columns[9].Width = 80;
            foreach (DataGridViewRow fila in dgFunc.Rows)
            {
                fila.Cells["password"].Value = "********";
            }
            dgFunc.Columns["is_active"].Visible = false;
            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "Estado";
            dgFunc.Columns.Add(textColumn);
            dgFunc.Columns["Estado"].DisplayIndex = 3;
            foreach (DataGridViewRow fila in dgFunc.Rows.Cast<DataGridViewRow>())
            {
                fila.Cells["Estado"].Value = (bool)fila.Cells["is_active"].Value ? "Activo" : "Inactivo";
            }
            if (filtro == true)
            {
                dgFunc.CurrentCell = null;
                foreach (DataGridViewRow fila in dgFunc.Rows)
                {
                    fila.Visible = fila.Cells["id"].Value.ToString().ToUpper().Equals(txtBuscar.Text.ToUpper());
                }
            }
        }

        private async void BuscarFunc()
        {
            var response = await RestHelper.BuscarFunc(txtBuscar.Text);
            var datos = JsonConvert.DeserializeObject<Funcionario>(response);
            this.txtNombre.Text = datos.first_name;
            this.txtApellido.Text = datos.last_name;
            this.txtEdad.Text = datos.edad.ToString();
            this.txtFono.Text = datos.telefono.ToString();
            this.txtCorreo.Text = datos.email;
            this.txtEmp.Text = datos.username;
            this.txtCont.Text ="";
            this.rbActivo.Enabled = true;
            this.rbInactivo.Enabled = true;
            MostrarFunc(true);
        }

        private void AgregarFunc()
        {
            Funcionario func = new Funcionario
            {
                first_name = txtNombre.Text,
                last_name = txtApellido.Text,
                is_active = true,
                is_staff = true,
                telefono = int.Parse(txtFono.Text),
                edad = int.Parse(txtEdad.Text),
                username = txtEmp.Text,
                email = txtCorreo.Text,
                password = txtCont.Text
            };
            string json = JsonConvert.SerializeObject(func);
            dynamic respuesta = _apiPost.Agregar("https://departamentos.pythonanywhere.com/api/usuarios/", json);
            MessageBox.Show($"Usuario {func.first_name + " " + func.last_name} agregado correctamente", "¡Éxito!");
        }

        private async void ModificarFunc()
        {
            Funcionario func = new Funcionario
            {
                first_name = txtNombre.Text,
                last_name = txtApellido.Text,
                is_active = true,
                is_staff = true,
                telefono = int.Parse(txtFono.Text),
                edad = int.Parse(txtEdad.Text),
                username = txtEmp.Text,
                email = txtCorreo.Text,
                password = txtCont.Text,
            };
            if(rbInactivo.Checked)
            {
                func.is_active = false;
            }

            var response = await RestHelper.BuscarFunc(txtBuscar.Text);
            var datos = JsonConvert.DeserializeObject<Funcionario>(response);
            if (func.password == "")
            {
                MessageBox.Show($"Para modificar el usuario se necesita cambiar la clave", "¡Error!");
            }
            else
            {
                string json = JsonConvert.SerializeObject(func);
                dynamic respuesta = _apiPut.Modificar($"https://departamentos.pythonanywhere.com/api/usuarios/{txtBuscar.Text}/", json);
                MessageBox.Show($"Usuario {func.first_name + " " + func.last_name} modificado correctamente", "¡Éxito!");
                MostrarFunc(true);
            }
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
            this.rbActivo.Checked = true;
            this.rbInactivo.Checked = false;
        }
        #endregion
    }
}
