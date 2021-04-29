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
    public partial class PhieuRutTien : Form
    {
        public PhieuRutTien()
        {
            InitializeComponent();
        }

        private void PhieuRutTien_Load(object sender, EventArgs e)
        {

        }

        private void thoat_PRT_btn_Click(object sender, EventArgs e)
        {
            MainFormAdmin main = new MainFormAdmin();
            this.Hide();
            main.Show();
        }
    }
}
