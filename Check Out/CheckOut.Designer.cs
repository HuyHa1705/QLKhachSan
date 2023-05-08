namespace Check_OUt
{
    partial class CheckOut
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.HOADON = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DICHVU = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Tong = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HOADON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DICHVU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(208, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check Out form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HOADON
            // 
            this.HOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HOADON.Location = new System.Drawing.Point(5, 254);
            this.HOADON.Name = "HOADON";
            this.HOADON.RowHeadersWidth = 51;
            this.HOADON.RowTemplate.Height = 29;
            this.HOADON.Size = new System.Drawing.Size(438, 184);
            this.HOADON.TabIndex = 2;
            this.HOADON.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "MaHK";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Phòng";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(121, 149);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(322, 27);
            this.txtKhachHang.TabIndex = 5;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(121, 182);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(322, 27);
            this.txtSoPhong.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dịch vụ đã sử dụng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DICHVU
            // 
            this.DICHVU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DICHVU.Location = new System.Drawing.Point(466, 140);
            this.DICHVU.Name = "DICHVU";
            this.DICHVU.RowHeadersWidth = 51;
            this.DICHVU.RowTemplate.Height = 29;
            this.DICHVU.Size = new System.Drawing.Size(322, 80);
            this.DICHVU.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng Giá";
            // 
            // Tong
            // 
            this.Tong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tong.Location = new System.Drawing.Point(466, 284);
            this.Tong.Name = "Tong";
            this.Tong.RowHeadersWidth = 51;
            this.Tong.RowTemplate.Height = 29;
            this.Tong.Size = new System.Drawing.Size(312, 53);
            this.Tong.TabIndex = 11;
            this.Tong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "In Hóa Đơn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Thanh Toán Bằng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(466, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 28);
            this.comboBox1.TabIndex = 14;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(121, 215);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(98, 26);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(466, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 32);
            this.button4.TabIndex = 16;
            this.button4.Text = "Tính Tổng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DICHVU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HOADON);
            this.Controls.Add(this.label1);
            this.Name = "CheckOut";
            this.Text = "Check Out";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOADON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DICHVU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView HOADON;
        private Label label2;
        private Label label3;
        private TextBox txtKhachHang;
        private TextBox txtSoPhong;
        private Button button1;
        private Label label4;
        private DataGridView DICHVU;
        private Label label5;
        private DataGridView Tong;
        private Button button2;
        private Label label6;
        private ComboBox comboBox1;
        private Button btnTim;
        private Button button4;
    }
}