using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTK.DAO;

namespace QLTK
{
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        //private void MainFormAdmin_Load(object sender, EventArgs e)
        //{          
        //    lb_account.Text = getmaGDV().Rows[0]["MACN"].ToString();
        //}

        private void Exit_mainform_btn_Click(object sender, EventArgs e)
        {
            LoginForm lgf = new LoginForm();
            this.Hide();
            lgf.Show();
        }

        private void btn_DSKH_Click(object sender, EventArgs e)
        {
            DSKH dshk = new DSKH();
            this.Hide();
            dshk.Show();
        }

        private void btn_PhieuGuiTien_Click(object sender, EventArgs e)
        {
            PhieuGuiTien pgt = new PhieuGuiTien();
            this.Hide();
            pgt.Show();
        }

        private void btn_PhieuRutTien_Click(object sender, EventArgs e)
        {
            PhieuRutTien prt = new PhieuRutTien();
            this.Hide();
            prt.Show();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            ReportForm rp = new ReportForm();
            this.Hide();
            rp.Show();
        }

        

        public DataTable getmaGDV()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM GIAODICHVIEN ");
            return data;
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            loadCN();
        }

        public void loadCN()
        {
            if (getmaGDV().Rows.Count > 1)
            {
                label_account.Text = "ADMIN";
            }
            else
            {
                label_account.Text = getmaGDV().Rows[0]["MACN"].ToString();
            }
        }
    }
}
