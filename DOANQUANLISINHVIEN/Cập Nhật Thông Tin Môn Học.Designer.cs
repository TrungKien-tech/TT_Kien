namespace DOANQUANLISINHVIEN
{
    partial class frmcapnhatthongtinmonhoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenmonhoc = new System.Windows.Forms.TextBox();
            this.txtsotinchi = new System.Windows.Forms.TextBox();
            this.txtmagiangvien = new System.Windows.Forms.TextBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Tín Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Giảng Viên";
            // 
            // txttenmonhoc
            // 
            this.txttenmonhoc.Location = new System.Drawing.Point(207, 64);
            this.txttenmonhoc.Name = "txttenmonhoc";
            this.txttenmonhoc.Size = new System.Drawing.Size(216, 22);
            this.txttenmonhoc.TabIndex = 1;
            // 
            // txtsotinchi
            // 
            this.txtsotinchi.Location = new System.Drawing.Point(207, 156);
            this.txtsotinchi.Name = "txtsotinchi";
            this.txtsotinchi.Size = new System.Drawing.Size(122, 22);
            this.txtsotinchi.TabIndex = 1;
            // 
            // txtmagiangvien
            // 
            this.txtmagiangvien.Location = new System.Drawing.Point(207, 236);
            this.txtmagiangvien.Name = "txtmagiangvien";
            this.txtmagiangvien.Size = new System.Drawing.Size(122, 22);
            this.txtmagiangvien.TabIndex = 1;
            // 
            // btncapnhat
            // 
            this.btncapnhat.AutoSize = true;
            this.btncapnhat.BackColor = System.Drawing.Color.Lime;
            this.btncapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.Location = new System.Drawing.Point(207, 311);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(97, 30);
            this.btncapnhat.TabIndex = 2;
            this.btncapnhat.Text = "Cập Nhật";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.AutoSize = true;
            this.btnhuy.BackColor = System.Drawing.Color.Red;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(326, 311);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(97, 30);
            this.btnhuy.TabIndex = 2;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // frmcapnhatthongtinmonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(480, 391);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.txtmagiangvien);
            this.Controls.Add(this.txtsotinchi);
            this.Controls.Add(this.txttenmonhoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmcapnhatthongtinmonhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Thông Tin Môn Học";
            this.Load += new System.EventHandler(this.frmcapnhatthongtinmonhoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenmonhoc;
        private System.Windows.Forms.TextBox txtsotinchi;
        private System.Windows.Forms.TextBox txtmagiangvien;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnhuy;
    }
}