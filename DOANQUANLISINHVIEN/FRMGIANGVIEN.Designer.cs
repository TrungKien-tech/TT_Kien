namespace DOANQUANLISINHVIEN
{
    partial class FRMGIANGVIEN
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
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.Colma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.AllowUserToAddRows = false;
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colma,
            this.Colhoten,
            this.Colngaysinh,
            this.Colgioitinh,
            this.Coldienthoai,
            this.ColEmail});
            this.dgvGiangVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGiangVien.Location = new System.Drawing.Point(0, 191);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.RowHeadersWidth = 51;
            this.dgvGiangVien.RowTemplate.Height = 24;
            this.dgvGiangVien.Size = new System.Drawing.Size(1486, 404);
            this.dgvGiangVien.TabIndex = 0;
            // 
            // Colma
            // 
            this.Colma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colma.HeaderText = "MSGV";
            this.Colma.MinimumWidth = 6;
            this.Colma.Name = "Colma";
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
            this.Colngaysinh.HeaderText = "Ngày Sinh";
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
            // Coldienthoai
            // 
            this.Coldienthoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Coldienthoai.HeaderText = "Điện Thoại";
            this.Coldienthoai.MinimumWidth = 6;
            this.Coldienthoai.Name = "Coldienthoai";
            // 
            // ColEmail
            // 
            this.ColEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.MinimumWidth = 6;
            this.ColEmail.Name = "ColEmail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ Khóa";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(676, 70);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(197, 22);
            this.txttimkiem.TabIndex = 8;
            // 
            // btnxoa
            // 
            this.btnxoa.AutoSize = true;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(1177, 66);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 30);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.AutoSize = true;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(893, 66);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(113, 30);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.AutoSize = true;
            this.btnthemmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemmoi.Location = new System.Drawing.Point(1039, 66);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(113, 30);
            this.btnthemmoi.TabIndex = 7;
            this.btnthemmoi.Text = "Thêm Mới";
            this.btnthemmoi.UseVisualStyleBackColor = true;
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 54);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thông Tin Giảng Viên";
            // 
            // FRMGIANGVIEN
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
            this.Controls.Add(this.dgvGiangVien);
            this.Name = "FRMGIANGVIEN";
            this.Text = "Quản Lí Giảng Viên";
            this.Load += new System.EventHandler(this.FRMGIANGVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthemmoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
    }
}