using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tbx_uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_uname.Text = "";
            txt_pass.Clear();
            txt_uname.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //To Do: Check login username & password
            SqlConnection con = Connection.GetConnection(); 
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
  FROM [dbo].[Login] where UserName='" + txt_uname.Text + "' and Password='" + txt_pass.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Dashboard main = new Dashboard();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1_Click(sender, e);//clear the values in tbx & return it.
            }

        }

        private void txt_uname_Enter(object sender, EventArgs e)
        {
            if(txt_uname.Text== "username")
            {
                txt_uname.Text = "";
                txt_uname.ForeColor = Color.White;
            }
        }

        private void txt_uname_Leave(object sender, EventArgs e)
        {
            if (txt_uname.Text == "")
            {
                txt_uname.Text = "username";
                txt_uname.ForeColor = Color.DimGray;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Password")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.White;
                txt_pass.UseSystemPasswordChar = false;
                
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.UseSystemPasswordChar = true;
                txt_pass.Text = "Password";
                txt_pass.ForeColor = Color.DimGray;
            }
        }
    }
}
