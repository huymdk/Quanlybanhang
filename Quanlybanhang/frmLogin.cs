using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlybanhang.Class;
using System.Data.SqlClient;
using System.Web.Caching;
namespace Quanlybanhang
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            // Kiểm tra kết nối cơ sở dữ liệu
            Functions.Connect();

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra đăng nhập
            if (Functions.Login(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Hiển thị form chính
                frmMain frm = new frmMain();
                frm.Show();

                // Đóng form hiện tại (form login)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
