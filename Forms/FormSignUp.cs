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
using System.Configuration;

namespace New_metro_App.Forms
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
            linkLogin.Visible = false;
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconSignup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
            string sqlquery = "insert into dbo.UserRegistration values (@Username, @Gender, @Email, @Upassword, @Urepassword)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlquery, conn);
            string gender = radMale.Checked ? "M" : "F";
            cmd.Parameters.AddWithValue("@Username", txtName.Text);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Upassword", txtPwd.Text);
            cmd.Parameters.AddWithValue("@Urepassword", txtRepwd.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User "+ txtName.Text + " is Successfully Registered", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            linkLogin.Visible = true;
            conn.Close();
        }

        private void txtRepwd_Leave(object sender, EventArgs e)
        {
            if(txtRepwd.Text != txtPwd.Text)
            {
                MessageBox.Show("Password is not matching");
                txtRepwd.Focus();
                return;
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.OpenChildForm(new Forms.FormLogin());
        }
    }
}
