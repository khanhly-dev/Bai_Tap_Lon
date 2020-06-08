using Bai_Tap_Lon.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Lon
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OK_BTN_Click(object sender, EventArgs e)
        {
            string userName = UserName_TBX.Text;
            string password = Password_TBX.Text;
            if(Login(userName, password))
            {
                SellForm sellFormShow = new SellForm();
                this.Hide();
                sellFormShow.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("tên đăng nhập hoặc mật khẩu sai!");
            }
        }

        public bool Login(string userName, string password)
        {
            return AccountDAO.instance.Login(userName, password);
        }

        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
