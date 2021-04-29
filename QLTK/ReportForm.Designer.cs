
namespace QLTK
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_report = new System.Windows.Forms.DataGridView();
            this.MAPHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYGUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAISUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTIEN_GUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDENHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGDV_LPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYRUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENLAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGDV_LPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Inpdf = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_report
            // 
            this.dataGridView_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHIEU,
            this.CMND,
            this.MADV,
            this.NGAYGUI,
            this.LAISUAT,
            this.SOTIEN_GUI,
            this.NGAYDENHAN,
            this.MAGDV_LPG,
            this.NGAYRUT,
            this.TIENLAI,
            this.MAGDV_LPR});
            this.dataGridView_report.Location = new System.Drawing.Point(8, 161);
            this.dataGridView_report.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView_report.Name = "dataGridView_report";
            this.dataGridView_report.RowHeadersWidth = 123;
            this.dataGridView_report.RowTemplate.Height = 46;
            this.dataGridView_report.Size = new System.Drawing.Size(1094, 499);
            this.dataGridView_report.TabIndex = 3;
            // 
            // MAPHIEU
            // 
            this.MAPHIEU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAPHIEU.DataPropertyName = "MAPHIEU";
            this.MAPHIEU.HeaderText = "Mã Phiếu";
            this.MAPHIEU.MinimumWidth = 15;
            this.MAPHIEU.Name = "MAPHIEU";
            this.MAPHIEU.ReadOnly = true;
            this.MAPHIEU.Width = 89;
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 15;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            this.CMND.Width = 77;
            // 
            // MADV
            // 
            this.MADV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MADV.DataPropertyName = "MADV";
            this.MADV.HeaderText = "Mã DV";
            this.MADV.MinimumWidth = 15;
            this.MADV.Name = "MADV";
            this.MADV.ReadOnly = true;
            this.MADV.Width = 56;
            // 
            // NGAYGUI
            // 
            this.NGAYGUI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NGAYGUI.DataPropertyName = "NGAYGUI";
            this.NGAYGUI.HeaderText = "Ngày Gửi";
            this.NGAYGUI.MinimumWidth = 15;
            this.NGAYGUI.Name = "NGAYGUI";
            this.NGAYGUI.ReadOnly = true;
            this.NGAYGUI.Width = 89;
            // 
            // LAISUAT
            // 
            this.LAISUAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LAISUAT.DataPropertyName = "LAISUAT";
            this.LAISUAT.HeaderText = "Lãi Suất";
            this.LAISUAT.MinimumWidth = 15;
            this.LAISUAT.Name = "LAISUAT";
            this.LAISUAT.ReadOnly = true;
            this.LAISUAT.Width = 82;
            // 
            // SOTIEN_GUI
            // 
            this.SOTIEN_GUI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SOTIEN_GUI.DataPropertyName = "SOTIEN_GUI";
            this.SOTIEN_GUI.HeaderText = "Số Tiền Gửi";
            this.SOTIEN_GUI.MinimumWidth = 15;
            this.SOTIEN_GUI.Name = "SOTIEN_GUI";
            this.SOTIEN_GUI.Width = 103;
            // 
            // NGAYDENHAN
            // 
            this.NGAYDENHAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NGAYDENHAN.DataPropertyName = "NGAYDENHAN";
            this.NGAYDENHAN.HeaderText = "Ngày Đến Hạn";
            this.NGAYDENHAN.MinimumWidth = 15;
            this.NGAYDENHAN.Name = "NGAYDENHAN";
            this.NGAYDENHAN.ReadOnly = true;
            this.NGAYDENHAN.Width = 96;
            // 
            // MAGDV_LPG
            // 
            this.MAGDV_LPG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAGDV_LPG.DataPropertyName = "MAGDV_LPG";
            this.MAGDV_LPG.HeaderText = "Mã GDV Lập Phiếu Gửi";
            this.MAGDV_LPG.MinimumWidth = 15;
            this.MAGDV_LPG.Name = "MAGDV_LPG";
            this.MAGDV_LPG.ReadOnly = true;
            this.MAGDV_LPG.Width = 148;
            // 
            // NGAYRUT
            // 
            this.NGAYRUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NGAYRUT.DataPropertyName = "NGAYRUT";
            this.NGAYRUT.HeaderText = "Ngày Rút Tiền";
            this.NGAYRUT.MinimumWidth = 15;
            this.NGAYRUT.Name = "NGAYRUT";
            this.NGAYRUT.ReadOnly = true;
            this.NGAYRUT.Width = 92;
            // 
            // TIENLAI
            // 
            this.TIENLAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TIENLAI.DataPropertyName = "TIENLAI";
            this.TIENLAI.HeaderText = "Tiền Lãi";
            this.TIENLAI.MinimumWidth = 15;
            this.TIENLAI.Name = "TIENLAI";
            this.TIENLAI.ReadOnly = true;
            this.TIENLAI.Width = 82;
            // 
            // MAGDV_LPR
            // 
            this.MAGDV_LPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAGDV_LPR.DataPropertyName = "MAGDV_LPR";
            this.MAGDV_LPR.HeaderText = "Mã GDV Lập Phiếu Rút";
            this.MAGDV_LPR.MinimumWidth = 15;
            this.MAGDV_LPR.Name = "MAGDV_LPR";
            this.MAGDV_LPR.ReadOnly = true;
            this.MAGDV_LPR.Width = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "REPORT";
            // 
            // btn_Inpdf
            // 
            this.btn_Inpdf.Location = new System.Drawing.Point(974, 115);
            this.btn_Inpdf.Name = "btn_Inpdf";
            this.btn_Inpdf.Size = new System.Drawing.Size(126, 42);
            this.btn_Inpdf.TabIndex = 4;
            this.btn_Inpdf.Text = "Export to Excel";
            this.btn_Inpdf.UseVisualStyleBackColor = true;
            this.btn_Inpdf.Click += new System.EventHandler(this.btn_Inpdf_Click);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Location = new System.Drawing.Point(28, 115);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(94, 42);
            this.btn_quaylai.TabIndex = 5;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 699);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.btn_Inpdf);
            this.Controls.Add(this.dataGridView_report);
            this.Controls.Add(this.label1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_report;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYGUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAISUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTIEN_GUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDENHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGDV_LPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYRUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENLAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGDV_LPR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Inpdf;
        private System.Windows.Forms.Button btn_quaylai;
    }
}