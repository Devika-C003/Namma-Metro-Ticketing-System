using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace New_metro_App.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
            string sqlquery = "select * from [dbo].[UserRegistration] where Username=@Username and Upassword=@Upassword";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlquery, conn);
            cmd.Parameters.AddWithValue("@Username", txtName.Text);
            cmd.Parameters.AddWithValue("@Upassword", txtPassword.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                label2.Visible = false;
                label3.Visible = false;
                txtName.Visible = false;
                txtPassword.Visible = false;
                btnLogin.Visible = false;

                lblU.Text = "Thank You " + txtName.Text + " for Logging In";
            }
            else
            {
                MessageBox.Show("Invalid Username & Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
