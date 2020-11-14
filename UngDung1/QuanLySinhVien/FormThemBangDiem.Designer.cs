namespace QuanLySinhVien
{
    partial class FormThemBangDiem
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
            this.dgvBangDiem = new System.Windows.Forms.DataGridView();
            this.cbbSinhVien = new System.Windows.Forms.ComboBox();
            this.cbbLopHoc = new System.Windows.Forms.ComboBox();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLy = new System.Windows.Forms.TextBox();
            this.txtHoa = new System.Windows.Forms.TextBox();
            this.btnLuuBangDiem = new System.Windows.Forms.Button();
            this.btnXoaBangDiem = new System.Windows.Forms.Button();
            this.btnThoatBangDiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBangDiem
            // 
            this.dgvBangDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiem.Location = new System.Drawing.Point(12, 193);
            this.dgvBangDiem.Name = "dgvBangDiem";
            this.dgvBangDiem.Size = new System.Drawing.Size(468, 339);
            this.dgvBangDiem.TabIndex = 0;
            this.dgvBangDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangDiem_CellContentClick);
            // 
            // cbbSinhVien
            // 
            this.cbbSinhVien.FormattingEnabled = true;
            this.cbbSinhVien.Location = new System.Drawing.Point(32, 32);
            this.cbbSinhVien.Name = "cbbSinhVien";
            this.cbbSinhVien.Size = new System.Drawing.Size(196, 21);
            this.cbbSinhVien.TabIndex = 1;
            // 
            // cbbLopHoc
            // 
            this.cbbLopHoc.FormattingEnabled = true;
            this.cbbLopHoc.Location = new System.Drawing.Point(32, 85);
            this.cbbLopHoc.Name = "cbbLopHoc";
            this.cbbLopHoc.Size = new System.Drawing.Size(196, 21);
            this.cbbLopHoc.TabIndex = 2;
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(272, 63);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(57, 20);
            this.txtToan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lớp Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lý";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hóa";
            // 
            // txtLy
            // 
            this.txtLy.Location = new System.Drawing.Point(335, 63);
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(57, 20);
            this.txtLy.TabIndex = 11;
            // 
            // txtHoa
            // 
            this.txtHoa.Location = new System.Drawing.Point(398, 63);
            this.txtHoa.Name = "txtHoa";
            this.txtHoa.Size = new System.Drawing.Size(57, 20);
            this.txtHoa.TabIndex = 12;
            // 
            // btnLuuBangDiem
            // 
            this.btnLuuBangDiem.Location = new System.Drawing.Point(36, 146);
            this.btnLuuBangDiem.Name = "btnLuuBangDiem";
            this.btnLuuBangDiem.Size = new System.Drawing.Size(75, 23);
            this.btnLuuBangDiem.TabIndex = 13;
            this.btnLuuBangDiem.Text = "Lưu";
            this.btnLuuBangDiem.UseVisualStyleBackColor = true;
            this.btnLuuBangDiem.Click += new System.EventHandler(this.btnLuuBangDiem_Click);
            // 
            // btnXoaBangDiem
            // 
            this.btnXoaBangDiem.Location = new System.Drawing.Point(153, 146);
            this.btnXoaBangDiem.Name = "btnXoaBangDiem";
            this.btnXoaBangDiem.Size = new System.Drawing.Size(75, 23);
            this.btnXoaBangDiem.TabIndex = 15;
            this.btnXoaBangDiem.Text = "Xóa";
            this.btnXoaBangDiem.UseVisualStyleBackColor = true;
            this.btnXoaBangDiem.Click += new System.EventHandler(this.btnXoaBangDiem_Click);
            // 
            // btnThoatBangDiem
            // 
            this.btnThoatBangDiem.Location = new System.Drawing.Point(380, 146);
            this.btnThoatBangDiem.Name = "btnThoatBangDiem";
            this.btnThoatBangDiem.Size = new System.Drawing.Size(75, 23);
            this.btnThoatBangDiem.TabIndex = 16;
            this.btnThoatBangDiem.Text = "Thoát";
            this.btnThoatBangDiem.UseVisualStyleBackColor = true;
            this.btnThoatBangDiem.Click += new System.EventHandler(this.btnThoatBangDiem_Click);
            // 
            // FormThemBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 544);
            this.Controls.Add(this.btnThoatBangDiem);
            this.Controls.Add(this.btnXoaBangDiem);
            this.Controls.Add(this.btnLuuBangDiem);
            this.Controls.Add(this.txtHoa);
            this.Controls.Add(this.txtLy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.cbbLopHoc);
            this.Controls.Add(this.cbbSinhVien);
            this.Controls.Add(this.dgvBangDiem);
            this.Name = "FormThemBangDiem";
            this.Text = "BẢNG ĐIỂM";
            this.Load += new System.EventHandler(this.FormThemBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBangDiem;
        private System.Windows.Forms.ComboBox cbbSinhVien;
        private System.Windows.Forms.ComboBox cbbLopHoc;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLy;
        private System.Windows.Forms.TextBox txtHoa;
        private System.Windows.Forms.Button btnLuuBangDiem;
        private System.Windows.Forms.Button btnXoaBangDiem;
        private System.Windows.Forms.Button btnThoatBangDiem;
    }
}