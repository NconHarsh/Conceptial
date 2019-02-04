using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceptial
{
    public partial class Login : Form
    {
        public ConceptialEntities dbentity = new ConceptialEntities();
        public Login()
        {
            
            InitializeComponent();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Username")
            {
                txtuser.Text = "";
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtuser.Text != null && txtpass.Text != null)
            {
                string username = txtuser.Text;
                string passwd = txtpass.Text;

                var checkvaliduser = dbentity.User_Tbl.Where(x => x.User_Name == username && x.Password == passwd).FirstOrDefault();
                if(checkvaliduser != null)
                {
                    Models.UserSessionModel.UserEmail = checkvaliduser.EmailID;
                    Models.UserSessionModel.UserId = Convert.ToInt32(checkvaliduser.User_ID);
                    Models.UserSessionModel.UserName = checkvaliduser.User_Name;
                    var checkrole = dbentity.User_Role_Tbl.Where(x => x.User_ID == checkvaliduser.User_ID).Select(x=>x.Role_ID).FirstOrDefault();
                    Models.UserSessionModel.UserRole = checkrole;               
                    LoadStatus loadStatuspage = new LoadStatus();
                    loadStatuspage.Show();
                   

                }
                else
                {
                    MessageBox.Show("Please Enter Valid Id and Password");
                }

            }
            else
            {
                MessageBox.Show("Please Enter Username And Password");
            }
        }
    }
}
