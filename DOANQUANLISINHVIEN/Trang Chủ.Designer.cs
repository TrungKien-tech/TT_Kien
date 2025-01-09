namespace DOANQUANLISINHVIEN
{
    partial class MAINFORM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripdangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripDKMH = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLíToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1486, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripdangxuat});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // toolstripdangxuat
            // 
            this.toolstripdangxuat.Image = global::DOANQUANLISINHVIEN.Properties.Resources.icons8_exit_50;
            this.toolstripdangxuat.Name = "toolstripdangxuat";
            this.toolstripdangxuat.Size = new System.Drawing.Size(224, 28);
            this.toolstripdangxuat.Text = "Đăng Xuất";
            this.toolstripdangxuat.Click += new System.EventHandler(this.toolstripdangxuat_Click);
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripSinhVien,
            this.toolstripGiangVien,
            this.toolstripMonHoc,
            this.toolstripDKMH});
            this.quảnLíToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(89, 27);
            this.quảnLíToolStripMenuItem.Text = "Quản Lý";
            // 
            // toolstripSinhVien
            // 
            this.toolstripSinhVien.Image = global::DOANQUANLISINHVIEN.Properties.Resources.icons8_student_48;
            this.toolstripSinhVien.Name = "toolstripSinhVien";
            this.toolstripSinhVien.Size = new System.Drawing.Size(238, 28);
            this.toolstripSinhVien.Text = "Sinh Viên";
            this.toolstripSinhVien.Click += new System.EventHandler(this.toolstripSinhVien_Click);
            // 
            // toolstripGiangVien
            // 
            this.toolstripGiangVien.Image = global::DOANQUANLISINHVIEN.Properties.Resources.teacher;
            this.toolstripGiangVien.Name = "toolstripGiangVien";
            this.toolstripGiangVien.Size = new System.Drawing.Size(238, 28);
            this.toolstripGiangVien.Text = "Giảng Viên";
            this.toolstripGiangVien.Click += new System.EventHandler(this.toolstripGiangVien_Click);
            // 
            // toolstripMonHoc
            // 
            this.toolstripMonHoc.Image = global::DOANQUANLISINHVIEN.Properties.Resources._object;
            this.toolstripMonHoc.Name = "toolstripMonHoc";
            this.toolstripMonHoc.Size = new System.Drawing.Size(238, 28);
            this.toolstripMonHoc.Text = "Môn Học";
            this.toolstripMonHoc.Click += new System.EventHandler(this.toolstripMonHoc_Click);
            // 
            // toolstripDKMH
            // 
            this.toolstripDKMH.Image = global::DOANQUANLISINHVIEN.Properties.Resources.regsiter;
            this.toolstripDKMH.Name = "toolstripDKMH";
            this.toolstripDKMH.Size = new System.Drawing.Size(238, 28);
            this.toolstripDKMH.Text = "Đăng Ký Môn Học";
            this.toolstripDKMH.Click += new System.EventHandler(this.toolstripDKMH_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DOANQUANLISINHVIEN.Properties.Resources.ánhinhvien;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1486, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MAINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MAINFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolstripSinhVien;
        private System.Windows.Forms.ToolStripMenuItem toolstripGiangVien;
        private System.Windows.Forms.ToolStripMenuItem toolstripMonHoc;
        private System.Windows.Forms.ToolStripMenuItem toolstripDKMH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolstripdangxuat;
    }
}