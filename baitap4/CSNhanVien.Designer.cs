namespace baitap4
{
    partial class CSNhanVien
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
            lblMSNV = new Label();
            lblTenNV = new Label();
            label3 = new Label();
            txtMSNV = new TextBox();
            txtTenNV = new TextBox();
            txtLuongCB = new TextBox();
            btnDongY = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // lblMSNV
            // 
            lblMSNV.AutoSize = true;
            lblMSNV.Location = new Point(169, 62);
            lblMSNV.Name = "lblMSNV";
            lblMSNV.Size = new Size(53, 20);
            lblMSNV.TabIndex = 0;
            lblMSNV.Text = "MSNV:";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(169, 143);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(102, 20);
            lblTenNV.TabIndex = 1;
            lblTenNV.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 228);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 1;
            label3.Text = "Lương căn bản:";
            // 
            // txtMSNV
            // 
            txtMSNV.Location = new Point(363, 55);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.Size = new Size(248, 27);
            txtMSNV.TabIndex = 2;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(363, 136);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(279, 27);
            txtTenNV.TabIndex = 2;
            // 
            // txtLuongCB
            // 
            txtLuongCB.Location = new Point(363, 225);
            txtLuongCB.Name = "txtLuongCB";
            txtLuongCB.Size = new Size(212, 27);
            txtLuongCB.TabIndex = 2;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(219, 311);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(104, 45);
            btnDongY.TabIndex = 3;
            btnDongY.Text = "Đồng Ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(538, 311);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(104, 45);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // CSNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBoQua);
            Controls.Add(btnDongY);
            Controls.Add(txtLuongCB);
            Controls.Add(txtTenNV);
            Controls.Add(txtMSNV);
            Controls.Add(label3);
            Controls.Add(lblTenNV);
            Controls.Add(lblMSNV);
            Name = "CSNhanVien";
            Text = "CSNhanVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMSNV;
        private Label lblTenNV;
        private Label label3;
        private TextBox txtMSNV;
        private TextBox txtTenNV;
        private TextBox txtLuongCB;
        private Button btnDongY;
        private Button btnBoQua;
    }
}