namespace DOANQUANLISINHVIEN
{
    partial class FRMSINHVIEN
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
            this.dgvSinhvien = new System.Windows.Forms.DataGridView();
            this.Colmasv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colchuyenganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhvien
            // 
            this.dgvSinhvien.AllowUserToAddRows = false;
            this.dgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colmasv,
            this.Colhoten,
            this.Colngaysinh,
            this.Colgioitinh,
            this.ColLop,
            this.Colchuyenganh,
            this.Coldienthoai,
            this.Colemail});
            this.dgvSinhvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSinhvien.Location = new System.Drawing.Point(0, 191);
            this.dgvSinhvien.Name = "dgvSinhvien";
            this.dgvSinhvien.RowHeadersWidth = 51;
            this.dgvSinhvien.RowTemplate.Height = 24;
            this.dgvSinhvien.Size = new System.Drawing.Size(1486, 404);
            this.dgvSinhvien.TabIndex = 0;
            this.dgvSinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhvien_CellContentClick);
            // 
            // Colmasv
            // 
            this.Colmasv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colmasv.HeaderText = "MSSV";
            this.Colmasv.MinimumWidth = 6;
            this.Colmasv.Name = "Colmasv";
            // 
            // Colhoten
            // 
            this.Colhoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colhoten.HeaderText = "Họ Tên";
            this.Colhoten.MinimumWidth = 6;
            this.Colhoten.Name = "Colhoten";
            // 
            // Colngaysinh
            // 
            this.Colngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colngaysinh.HeaderText = "NgaySinh";
            this.Colngaysinh.MinimumWidth = 6;
            this.Colngaysinh.Name = "Colngaysinh";
            // 
            // Colgioitinh
            // 
            this.Colgioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colgioitinh.HeaderText = "Giới Tính";
            this.Colgioitinh.MinimumWidth = 6;
            this.Colgioitinh.Name = "Colgioitinh";
            // 
            // ColLop
            // 
            this.ColLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColLop.HeaderText = "Lớp";
            this.ColLop.MinimumWidth = 6;
            this.ColLop.Name = "ColLop";
            // 
            // Colchuyenganh
            // 
            this.Colchuyenganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colchuyenganh.HeaderText = "Chuyên Ngành";
            this.Colchuyenganh.MinimumWidth = 6;
            this.Colchuyenganh.Name = "Colchuyenganh";
            // 
            // Coldienthoai
            // 
            this.Coldienthoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Coldienthoai.HeaderText = "Điện Thoại";
            this.Coldienthoai.MinimumWidth = 6;
            this.Coldienthoai.Name = "Coldienthoai";
            // 
            // Colemail
            // 
            this.Colemail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colemail.HeaderText = "Email";
            this.Colemail.MinimumWidth = 6;
            this.Colemail.Name = "Colemail";
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.AutoSize = true;
            this.btnthemmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemmoi.Location = new System.Drawing.Point(1004, 58);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(113, 30);
            this.btnthemmoi.TabIndex = 1;
            this.btnthemmoi.Text = "Thêm Mới";
            this.btnthemmoi.UseVisualStyleBackColor = true;
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // btnTim
            // 
            this.btnTim.AutoSize = true;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(870, 58);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(113, 30);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.AutoSize = true;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(1149, 57);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 30);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(637, 63);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(212, 22);
            this.txttimkiem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ Khóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thông Tin Sinh Viên";
            // 
            // FRMSINHVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1486, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnthemmoi);
            this.Controls.Add(this.dgvSinhvien);
            this.Name = "FRMSINHVIEN";
            this.Text = "QUẢN LÍ SINH VIÊN";
            this.Load += new System.EventHandler(this.FRMSINHVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhvien;
        private System.Windows.Forms.Button btnthemmoi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colmasv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colchuyenganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colemail;
        private System.Windows.Forms.Label label2;
    }
}