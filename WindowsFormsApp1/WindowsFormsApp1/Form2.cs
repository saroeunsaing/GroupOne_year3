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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form

    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ROTH\\MSSQLSERVER01;Initial Catalog=spi_year3;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into tbl_users values(@id,@username,@Password,@role)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
            cmd.Parameters.AddWithValue("@username", txtuser.Text);
            cmd.Parameters.AddWithValue("@Password", txtpass.Text);
            cmd.Parameters.AddWithValue("@role", txtro.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("data send");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ROTH\\MSSQLSERVER01;Initial Catalog=spi_year3;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update tbl_users set username = @username,Password = @Password,role = @role where id = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
            cmd.Parameters.AddWithValue("@username", txtuser.Text);
            cmd.Parameters.AddWithValue("@Password", txtpass.Text);
            cmd.Parameters.AddWithValue("@role", txtro.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update successfaul");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ROTH\\MSSQLSERVER01;Initial Catalog=spi_year3;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from tbl_users where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
            cmd.Parameters.AddWithValue("@username", txtuser.Text);
            cmd.Parameters.AddWithValue("@Password", txtpass.Text);
            cmd.Parameters.AddWithValue("@role", txtro.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted");
        }

        
    }
}

        
