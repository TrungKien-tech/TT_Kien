namespace DOANQUANLISINHVIEN
{
    partial class FRMDANGKYMONHOC
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
            this.dgvDangkymonhoc = new System.Windows.Forms.DataGridView();
            this.Colmadangky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coltenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colmasinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colmagiangvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colngaydangky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btndangkymoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangkymonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDangkymonhoc
            // 
            this.dgvDangkymonhoc.AllowUserToAddRows = false;
            this.dgvDangkymonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangkymonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colmadangky,
            this.Coltenmonhoc,
            this.Colmasinhvien,
            this.Colhoten,
            this.Colmagiangvien,
            this.Colngaydangky});
            this.dgvDangkymonhoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDangkymonhoc.Location = new System.Drawing.Point(0, 191);
            this.dgvDangkymonhoc.Name = "dgvDangkymonhoc";
            this.dgvDangkymonhoc.RowHeadersWidth = 51;
            this.dgvDangkymonhoc.RowTemplate.Height = 24;
            this.dgvDangkymonhoc.Size = new System.Drawing.Size(1486, 404);
            this.dgvDangkymonhoc.TabIndex = 0;
            // 
            // Colmadangky
            // 
            this.Colmadangky.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colmadangky.HeaderText = "MADK";
            this.Colmadangky.MinimumWidth = 6;
            this.Colmadangky.Name = "Colmadangky";
            // 
            // Coltenmonhoc
            // 
            this.Coltenmonhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Coltenmonhoc.HeaderText = "Tên Môn Học";
            this.Coltenmonhoc.MinimumWidth = 6;
            this.Coltenmonhoc.Name = "Coltenmonhoc";
            // 
            // Colmasinhvien
            // 
            this.Colmasinhvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colmasinhvien.HeaderText = "MASV";
            this.Colmasinhvien.MinimumWidth = 6;
            this.Colmasinhvien.Name = "Colmasinhvien";
            // 
            // Colhoten
            // 
            this.Colhoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colhoten.HeaderText = "Họ Tên";
            this.Colhoten.MinimumWidth = 6;
            this.Colhoten.Name = "Colhoten";
            // 
            // Colmagiangvien
            // 
            this.Colmagiangvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colmagiangvien.HeaderText = "MAGV";
            this.Colmagiangvien.MinimumWidth = 6;
            this.Colmagiangvien.Name = "Colmagiangvien";
            // 
            // Colngaydangky
            // 
            this.Colngaydangky.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colngaydangky.HeaderText = "Ngày Đăng Ký";
            this.Colngaydangky.MinimumWidth = 6;
            this.Colngaydangky.Name = "Colngaydangky";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Ký Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Từ Khóa";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(662, 70);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(209, 22);
            this.txttimkiem.TabIndex = 13;
            // 
            // btnxoa
            // 
            this.btnxoa.AutoSize = true;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(1204, 66);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 30);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.AutoSize = true;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(895, 66);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(113, 30);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btndangkymoi
            // 
            this.btndangkymoi.AutoSize = true;
            this.btndangkymoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangkymoi.Location = new System.Drawing.Point(1041, 66);
            this.btndangkymoi.Name = "btndangkymoi";
            this.btndangkymoi.Size = new System.Drawing.Size(125, 30);
            this.btndangkymoi.TabIndex = 12;
            this.btndangkymoi.Text = "Đăng Ký Mới";
            this.btndangkymoi.UseVisualStyleBackColor = true;
            this.btndangkymoi.Click += new System.EventHandler(this.btndangkymoi_Click);
            // 
            // FRMDANGKYMONHOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1486, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btndangkymoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDangkymonhoc);
            this.Name = "FRMDANGKYMONHOC";
            this.Text = "Quản Lí Đăng Ký Môn Học";
            this.Load += new System.EventHandler(this.FRMDANGKYMONHOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangkymonhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDangkymonhoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btndangkymoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colmadangky;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coltenmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colmasinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colmagiangvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colngaydangky;
    }
}