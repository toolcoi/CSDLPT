
namespace QLTK
{
    partial class MainFormAdmin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_PhieuGuiTien = new System.Windows.Forms.Button();
            this.btn_PhieuRutTien = new System.Windows.Forms.Button();
            this.btn_DSKH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_mainform_btn = new System.Windows.Forms.Button();
            this.lb_account = new System.Windows.Forms.Label();
            this.label_account = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Report);
            this.groupBox1.Controls.Add(this.btn_PhieuGuiTien);
            this.groupBox1.Controls.Add(this.btn_PhieuRutTien);
            this.groupBox1.Controls.Add(this.btn_DSKH);
            this.groupBox1.Location = new System.Drawing.Point(43, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(888, 460);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_Report
            // 
            this.btn_Report.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.Location = new System.Drawing.Point(459, 232);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(328, 182);
            this.btn_Report.TabIndex = 3;
            this.btn_Report.Text = "Phiếu Báo Cáo";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_PhieuGuiTien
            // 
            this.btn_PhieuGuiTien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhieuGuiTien.Location = new System.Drawing.Point(459, 29);
            this.btn_PhieuGuiTien.Margin = new System.Windows.Forms.Padding(1);
            this.btn_PhieuGuiTien.Name = "btn_PhieuGuiTien";
            this.btn_PhieuGuiTien.Size = new System.Drawing.Size(328, 182);
            this.btn_PhieuGuiTien.TabIndex = 2;
            this.btn_PhieuGuiTien.Text = "Phiếu Gửi Tiền";
            this.btn_PhieuGuiTien.UseVisualStyleBackColor = true;
            this.btn_PhieuGuiTien.Click += new System.EventHandler(this.btn_PhieuGuiTien_Click);
            // 
            // btn_PhieuRutTien
            // 
            this.btn_PhieuRutTien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhieuRutTien.Location = new System.Drawing.Point(94, 232);
            this.btn_PhieuRutTien.Margin = new System.Windows.Forms.Padding(1);
            this.btn_PhieuRutTien.Name = "btn_PhieuRutTien";
            this.btn_PhieuRutTien.Size = new System.Drawing.Size(328, 182);
            this.btn_PhieuRutTien.TabIndex = 1;
            this.btn_PhieuRutTien.Text = "Phiếu Rút Tiền";
            this.btn_PhieuRutTien.UseVisualStyleBackColor = true;
            this.btn_PhieuRutTien.Click += new System.EventHandler(this.btn_PhieuRutTien_Click);
            // 
            // btn_DSKH
            // 
            this.btn_DSKH.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DSKH.Location = new System.Drawing.Point(94, 29);
            this.btn_DSKH.Margin = new System.Windows.Forms.Padding(1);
            this.btn_DSKH.Name = "btn_DSKH";
            this.btn_DSKH.Size = new System.Drawing.Size(328, 182);
            this.btn_DSKH.TabIndex = 0;
            this.btn_DSKH.Text = "DSKH";
            this.btn_DSKH.UseVisualStyleBackColor = true;
            this.btn_DSKH.Click += new System.EventHandler(this.btn_DSKH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản Lí Tài Khoản";
            // 
            // Exit_mainform_btn
            // 
            this.Exit_mainform_btn.Location = new System.Drawing.Point(843, 34);
            this.Exit_mainform_btn.Margin = new System.Windows.Forms.Padding(1);
            this.Exit_mainform_btn.Name = "Exit_mainform_btn";
            this.Exit_mainform_btn.Size = new System.Drawing.Size(88, 36);
            this.Exit_mainform_btn.TabIndex = 4;
            this.Exit_mainform_btn.Text = "Đăng Xuất";
            this.Exit_mainform_btn.UseVisualStyleBackColor = true;
            this.Exit_mainform_btn.Click += new System.EventHandler(this.Exit_mainform_btn_Click);
            // 
            // lb_account
            // 
            this.lb_account.AutoSize = true;
            this.lb_account.Location = new System.Drawing.Point(767, 44);
            this.lb_account.Name = "lb_account";
            this.lb_account.Size = new System.Drawing.Size(0, 17);
            this.lb_account.TabIndex = 6;
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_account.Location = new System.Drawing.Point(766, 42);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(36, 19);
            this.label_account.TabIndex = 7;
            this.label_account.Text = "test";
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 651);
            this.Controls.Add(this.label_account);
            this.Controls.Add(this.lb_account);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_mainform_btn);
            this.Name = "MainFormAdmin";
            this.Text = "MainFormAdmin";
            this.Load += new System.EventHandler(this.MainFormAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_PhieuGuiTien;
        private System.Windows.Forms.Button btn_PhieuRutTien;
        private System.Windows.Forms.Button btn_DSKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_mainform_btn;
        private System.Windows.Forms.Label lb_account;
        private System.Windows.Forms.Label label_account;
    }
}