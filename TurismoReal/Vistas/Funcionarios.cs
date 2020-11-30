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
            EnableButtons();
            PlaceHolder();
            Colores();
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
            LimpiarCampos();
            EnableButtons();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar por Id")
            {
                MessageBox.Show("Ingrese un Id para buscar", "¡Error!");
            }
            else
            {
                BuscarFunc();
                DisableButtons();
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

        private void dgFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            dgFuncionario.Rows[e.RowIndex].Selected = true;
            txtBuscar.Text = dgFuncionario.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtBuscar.ForeColor = Color.Black;
            txtApellido.Text = dgFuncionario.Rows[e.RowIndex].Cells["last_name"].Value.ToString();
            txtNombre.Text = dgFuncionario.Rows[e.RowIndex].Cells["first_name"].Value.ToString();
            txtEdad.Text = dgFuncionario.Rows[e.RowIndex].Cells["edad"].Value.ToString();
            txtFono.Text = dgFuncionario.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            txtCorreo.Text = dgFuncionario.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtEmp.Text = dgFuncionario.Rows[e.RowIndex].Cells["username"].Value.ToString();
            if (dgFuncionario.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "Inactivo")
            {
                rbInactivo.Checked = true;
            }
            else if (dgFuncionario.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "Activo")
            {
                rbActivo.Checked = true;
            }
            DisableButtons();
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
        //-----------
        //INVENTARIO

        //private void dgFuncionario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    string valor = e.Value as string;

        //    if (this.dgFuncionario.Columns[e.ColumnIndex].Name == "Estado")
        //    {
        //        if (valor == "Activo")
        //            e.CellStyle.BackColor = Color.LightGreen;
        //        else if (valor == "Inactivo")
        //            e.CellStyle.BackColor = Color.LightSalmon;
        //    }
        //}
        //-----------
        #endregion

        #region METODOS           
        private async void MostrarFunc(bool filtro)
        {
            var response = await RestHelper.MostrarFuncionario();
            var result = JsonConvert.DeserializeObject<List<Funcionario>>(response);
            dgFuncionario.DataSource = result;
            dgFuncionario.Columns["id"].HeaderText = "Id";
            dgFuncionario.Columns["id"].Width = 28;
            dgFuncionario.Columns["id"].DisplayIndex = 0;
            dgFuncionario.Columns["first_name"].HeaderText = "Nombre";
            dgFuncionario.Columns["first_name"].Width = 70;
            dgFuncionario.Columns["first_name"].DisplayIndex = 1;
            dgFuncionario.Columns["last_name"].HeaderText = "Apellido";
            dgFuncionario.Columns["last_name"].Width = 70;
            dgFuncionario.Columns["last_name"].DisplayIndex = 2;
            dgFuncionario.Columns["edad"].HeaderText = "Edad";
            dgFuncionario.Columns["edad"].Width = 40;
            dgFuncionario.Columns["edad"].DisplayIndex = 3;
            dgFuncionario.Columns["telefono"].HeaderText = "Teléfono";
            dgFuncionario.Columns["telefono"].Width = 80;
            dgFuncionario.Columns["telefono"].DisplayIndex = 4;
            dgFuncionario.Columns["email"].HeaderText = "Correo personal";
            dgFuncionario.Columns["email"].Width = 130;
            dgFuncionario.Columns["email"].DisplayIndex = 5;
            dgFuncionario.Columns["username"].HeaderText = "Correo empresarial";
            dgFuncionario.Columns["username"].Width = 140;
            dgFuncionario.Columns["username"].DisplayIndex = 6;
            dgFuncionario.Columns["is_staff"].Visible = false;
            dgFuncionario.Columns["password"].Visible = false;
            dgFuncionario.Columns["is_active"].Visible = false;
            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "Estado";
            dgFuncionario.Columns.Add(textColumn);
            dgFuncionario.Columns["Estado"].Width = 60;
            dgFuncionario.Columns["Estado"].DisplayIndex = 7;
            foreach (DataGridViewRow fila in dgFuncionario.Rows.Cast<DataGridViewRow>())
            {
                fila.Cells["Estado"].Value = (bool)fila.Cells["is_active"].Value ? "Activo" : "Inactivo";
            }

            if (filtro == true)
            {
                dgFuncionario.CurrentCell = null;
                foreach (DataGridViewRow fila in dgFuncionario.Rows)
                {
                    fila.Visible = fila.Cells["id"].Value.ToString().ToUpper().Equals(txtBuscar.Text.ToUpper());
                }
            }
        }

        private async void BuscarFunc()
        {
            var response = await RestHelper.BuscarFuncionario(txtBuscar.Text);
            var datos = JsonConvert.DeserializeObject<Funcionario>(response);
            this.txtNombre.Text = datos.first_name;
            this.txtApellido.Text = datos.last_name;
            this.txtEdad.Text = datos.edad.ToString();
            this.txtFono.Text = datos.telefono.ToString();
            this.txtCorreo.Text = datos.email;
            this.txtEmp.Text = datos.username;
            this.txtCont.Text ="";
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
            var response = await RestHelper.BuscarFuncionario(txtBuscar.Text);
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
            this.rbActivo.Checked = true;
        }

        private void EnableButtons()
        {
            this.rbActivo.Enabled = false;
            this.rbInactivo.Enabled = false;
            this.rbActivo.Checked = true;

            this.btnAgregar.Visible = true;
            this.lbAgg.Visible = false;
            this.pbDisableAgg.Visible = false;

            this.btnEditar.Visible = false;
            this.lbEdd.Visible = true;
            this.pbDisableEdd.Visible = true;
        }
        private void DisableButtons()
        {
            this.rbActivo.Enabled = true;
            this.rbInactivo.Enabled = true;

            this.btnAgregar.Visible = false;
            this.lbAgg.Visible = true;
            this.pbDisableAgg.Visible = true;

            this.btnEditar.Visible = true;
            this.lbEdd.Visible = false;
            this.pbDisableEdd.Visible = false;
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
            dgFuncionario.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dgFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
        #endregion
    }
}
