using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventsRegisterInterface
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BTN_IniciarSesion_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtCode.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Favor de ingresar usuario y contraseña", "Error");
                return;
            }
            Dictionary<string, string> data = new Dictionary<string, string>()
                                            {
                                                {"code", txtCode.Text},
                                                {"password", txtPass.Text}
                                            };
            RestHandler.restResponse response = RestHandler.RESTData("login", "POST", data);
            if (!response.response)
            {
                MessageBox.Show(response.message, "Error al iniciar sesión");
                return;
            }
            User user = new User(response.data.user);
            string token = response.data.token;
            //MessageBox.Show("Bienvenido " + user.name, "Inicio de sesión exitoso");
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem item = new ToolStripMenuItem("Main menu");
            menuStrip.Items.Add(item);

            this.Hide();
            frmListUser listUser = new frmListUser(menuStrip);
            listUser.ShowDialog();

        }

    }
}

/*
{
    {  
        "response": "true",  
        "data": {    
            "user": {      
                "id": "17452ea3-38d6-4f5f-a534-6215e3ecb43b",      
                "name": "Alexis Gutierrez",      
                "email": "alexis@mail.com",    
                "code": "211664946",      
                "phoneNumber": "",      
                "status": true    },   
            "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkYXRhIjp7Il9pZCI6IjE3NDUyZWEzLTM4ZDYtNGY1Zi1hNTM0LTYyMTVlM2VjYjQzYiJ9LCJpYXQiOjE1NjIyNzA2NDMsImV4cCI6MTU2MjM1NzA0M30.5wnkzrIUYwSMzmLXp-LdOVSTqnKQ_WtIlgP_7kQC-Ts"  }, 
        "message": "",  
        "devMessage": ""
    }
}
*/
