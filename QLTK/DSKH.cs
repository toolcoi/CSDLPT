using iTextSharp.text;
using iTextSharp.text.pdf;
using QLTK.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTK
{
    public partial class DSKH : Form
    {
        public DSKH()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DSKH_Load(object sender, EventArgs e)
        {
            loadDSKH();
            loadCN();
        }

        public void loadDSKH()
        {
            string query = "SELECT * FROM KHACHHANG";
            dataGridView_DSKH.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        

        public void loadCN()
        {
            if(getmaGDV().Rows.Count >1)
            {
                cb_Chinhanh.Text = "ADMIN";
            }
            else
            {
                cb_Chinhanh.Text = getmaGDV().Rows[0]["MACN"].ToString();
            }
            
                           
        }       

        public DataTable getmaGDV()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM GIAODICHVIEN ");
            return data;
        }

        public bool InsertKH(string hoten, string ngaycap, string cmnd, string diachi, string maCN)
        {
            string query = String.Format("INSERT INTO KHACHHANG (HOTEN,DIACHI,CMND,NGAYCAP,MACN) VALUES (N'{0}', N'{1}', '{2}', convert(datetime,'18-06-12 10:34:09 PM',5) ,'{4}')", hoten, diachi, cmnd, ngaycap, maCN);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        private void thoat_DSKH_btn_Click(object sender, EventArgs e)
        {
            MainFormAdmin main = new MainFormAdmin();
            this.Hide();
            main.Show();
        }

        private void Them_DSKH_btn_Click(object sender, EventArgs e)
        {
            string tenKH = ten_DSKH_tb.Text;
            string cmnd = cmnd_DSKH_tb.Text;
            string ngaycap = dateTimePicker_DSKH_ngaycap.Value.ToString();
            string diachi = diachi_DSKH_tb.Text;


            if (InsertKH(tenKH, ngaycap, cmnd, diachi, getmaGDV().Rows[0]["MACN"].ToString()))
            {
                MessageBox.Show("Thêm khách hàng thành công");
                loadDSKH();
                ten_DSKH_tb.Clear();
                cmnd_DSKH_tb.Clear();
                diachi_DSKH_tb.Clear();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thât bại");
            }
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            dataGridView_DSKH.SelectAll();
            DataObject copydata = dataGridView_DSKH.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWSheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlWSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlWSheet.Cells[1, 1];
            xlr.Select();

            xlWSheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
