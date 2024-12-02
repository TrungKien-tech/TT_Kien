namespace Demo
{
    partial class dta_Form
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
            dtaNhanVien = new DataGridView();
            txtId = new TextBox();
            txtName = new TextBox();
            txtLuong = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblId = new Label();
            lblName = new Label();
            lblAge = new Label();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtaNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dtaNhanVien
            // 
            dtaNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtaNhanVien.Location = new Point(12, 54);
            dtaNhanVien.Name = "dtaNhanVien";
            dtaNhanVien.RowHeadersWidth = 51;
            dtaNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtaNhanVien.Size = new Size(548, 325);
            dtaNhanVien.TabIndex = 0;
            dtaNhanVien.CellClick += dtaStudent_CellClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(789, 71);
            txtId.Name = "txtId";
            txtId.Size = new Size(286, 27);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(789, 175);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 27);
            txtName.TabIndex = 1;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(789, 288);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(286, 27);
            txtLuong.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(622, 344);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 52);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(818, 344);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(105, 52);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(994, 344);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 52);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(684, 78);
            lblId.Name = "lblId";
            lblId.Size = new Size(53, 20);
            lblId.TabIndex = 3;
            lblId.Text = "MSNV:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(684, 182);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Tên NV:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(684, 295);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(76, 20);
            lblAge.TabIndex = 3;
            lblAge.Text = "Lương CB:";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1152, 344);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 52);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Đóng";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dta_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 615);
            Controls.Add(btnThoat);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtLuong);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(dtaNhanVien);
            Name = "dta_Form";
            Text = "Data Grid View";
            Load += dta_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dtaNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtaNhanVien;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtLuong;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblId;
        private Label lblName;
        private Label lblAge;
        private Button btnThoat;
    }
}
