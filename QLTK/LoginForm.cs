using QLTK.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTK
{
    public partial class LoginForm : Form
    {
        public static string chinhanh;
        public static string uname;
        public static string passwd;

        public LoginForm()
        {
            InitializeComponent();
        }
       

        public void checklogin()
        {
            if (username.Text == "sa" && password.Text == "123456")
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CHINHANH");
                if (data.Rows.Count > 0)
                {
                    MainFormAdmin mainform = new MainFormAdmin();
                    this.Hide();
                    mainform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            else if (username.Text == "sa" && password.Text == "147258")
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CHINHANH");
                if (data.Rows.Count > 0)
                {
                    MainFormAdmin mainform = new MainFormAdmin();
                    this.Hide();
                    mainform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            else if (username.Text == "sa" && password.Text == "081099")
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CHINHANH");
                if (data.Rows.Count > 0)
                {
                    MainFormAdmin mainform = new MainFormAdmin();
                    this.Hide();
                    mainform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng đăng nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng đăng nhập lại!");
            }


        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình này?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            chinhanh = Login_chinhanh_cbb.SelectedItem.ToString();
            uname = username.Text;
            passwd = password.Text;

            checklogin();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
