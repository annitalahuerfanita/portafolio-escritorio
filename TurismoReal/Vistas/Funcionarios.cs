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
            PlaceHolder();
            rbActivo.Enabled = false;
            rbInactivo.Enabled = false;
            _apiPost = new ApiPost();
            _apiPut = new ApiPut();
        }
        public class Funcionario
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
            if (txtBuscar.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtFono.Text == "" || txtEdad.Text == "" || txtEmp.Text == "" || txtCorreo.Text == "" || txtCont.Text == "")
            {
                MessageBox.Show("Verifique los campos", "¡Error!");
            }
            else
            {
                ModificarFunc();
                LimpiarCampos();
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

        private void dgFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            dgFunc.Rows[e.RowIndex].Selected = true;
            txtBuscar.Text = dgFunc.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtBuscar.ForeColor = Color.Black;
            txtApellido.Text = dgFunc.Rows[e.RowIndex].Cells["last_name"].Value.ToString();
            txtCorreo.Text = dgFunc.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtEdad.Text = dgFunc.Rows[e.RowIndex].Cells["edad"].Value.ToString();
            txtEmp.Text = dgFunc.Rows[e.RowIndex].Cells["username"].Value.ToString();
            txtFono.Text = dgFunc.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            txtNombre.Text = dgFunc.Rows[e.RowIndex].Cells["first_name"].Value.ToString();
        }
        #endregion

        #region METODOS           
        private async void MostrarFunc(bool filtro)
        {
            var response = await RestHelper.MostrarFunc();
            var result = JsonConvert.DeserializeObject<List<Funcionario>>(response);
            dgFunc.DataSource = result;
            dgFunc.Columns["id"].HeaderText = "Id";
            dgFunc.Columns["id"].Width = 28;
            dgFunc.Columns["id"].DisplayIndex = 0;
            dgFunc.Columns["first_name"].HeaderText = "Nombre";
            dgFunc.Columns["first_name"].Width = 70;
            dgFunc.Columns["first_name"].DisplayIndex = 1;
            dgFunc.Columns["last_name"].HeaderText = "Apellido";
            dgFunc.Columns["last_name"].Width = 70;
            dgFunc.Columns["last_name"].DisplayIndex = 2;
            dgFunc.Columns["edad"].HeaderText = "Edad";
            dgFunc.Columns["edad"].Width = 40;
            dgFunc.Columns["edad"].DisplayIndex = 3;
            dgFunc.Columns["telefono"].HeaderText = "Teléfono";
            dgFunc.Columns["telefono"].Width = 80;
            dgFunc.Columns["telefono"].DisplayIndex = 4;
            dgFunc.Columns["email"].HeaderText = "Correo personal";
            dgFunc.Columns["email"].Width = 130;
            dgFunc.Columns["email"].DisplayIndex = 5;
            dgFunc.Columns["username"].HeaderText = "Correo empresarial";
            dgFunc.Columns["username"].Width = 140;

            dgFunc.Columns["username"].DisplayIndex = 6;
            //dgFunc.Columns["is_active"].HeaderText = "Activo";
            //dgFunc.Columns["is_active"].Width = 60;
            //dgFunc.Columns["is_active"].DisplayIndex = 7;
            dgFunc.Columns["is_staff"].Visible = false;
            dgFunc.Columns["password"].Visible = false;

            dgFunc.Columns["is_active"].Visible = false;
            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "Estado";
            dgFunc.Columns.Add(textColumn);
            dgFunc.Columns["Estado"].Width = 60;
            dgFunc.Columns["Estado"].DisplayIndex = 7;
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
            if (datos.is_active == false)
            {
                rbInactivo.Checked = true;
            }
            else if (datos.is_active == true)
            {
                rbActivo.Checked = true;
            }
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
            dynamic respuesta = _apiPost.Agregar("http://192.168.100.50/api/usuarios/", json);
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
                MessageBox.Show($"Para modificar el usuario se necesita cambiar la contraseña", "¡Error!");
            }
            else
            {
                string json = JsonConvert.SerializeObject(func);
                dynamic respuesta = _apiPut.Modificar($"http://192.168.100.50/api/usuarios/{txtBuscar.Text}/", json);
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
            this.rbActivo.Enabled = false;
            this.rbInactivo.Enabled = false;
            //this.rbActivo.Checked = true;
            //this.rbInactivo.Checked = false;
        }
        public void PlaceHolder()
        {
            txtBuscar.Tag = "Buscar por Id";
            txtBuscar.Text = txtBuscar.Tag.ToString();
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.GotFocus += new EventHandler(OnGetFocus);
            txtBuscar.LostFocus += new EventHandler(OnLostFocus);
        }
        #endregion
    }
}
