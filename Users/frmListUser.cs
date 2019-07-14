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
    public partial class frmListUser : Form
    {
        public frmListUser(MenuStrip menuStrip)
        {
            InitializeComponent();
            
            //this.IsMdiContainer = true;
            this.Controls.Add(menuStrip);

            dtgridUsers.ColumnCount = 4;
            dtgridUsers.Columns[0].Name = "ID";
            dtgridUsers.Columns[0].Visible = false;
            dtgridUsers.Columns[1].Name = "Nombre";
            dtgridUsers.Columns[1].Width = 220;
            dtgridUsers.Columns[2].Name = "Código";
            dtgridUsers.Columns[2].Width = 100;
            dtgridUsers.Columns[3].Name = "Tipo de Usuario";
            dtgridUsers.Columns[3].Width = 120;
            dtgridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            getUsers();
        }

        private void getUsers()
        {
            RestHandler.restResponse response = RestHandler.RESTGETData("users/?offset=0&limit=8", "GET");
            if (response.response)
            {
                int totalRows = response.data.count;
                
                for (int i = 0; i < totalRows; i++)
                {
                    
                    User user = new User(response.data.rows[i]);
                    string[] row = new string[] { user.id, user.name, user.code, user.userType.description };
                    dtgridUsers.Rows.Add(row);
                }
            }
            //MessageBox.Show("Hola", "Hola");
        }
    }
}
