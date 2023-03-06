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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
            string sqlquery = "SELECT * FROM [dbo].[UserRegistration]";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery,conn);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);

            dataG.DataSource = dt;
        }
    }
}
