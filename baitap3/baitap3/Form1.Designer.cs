namespace baitap3
{
    partial class Form1
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "1", "Nv1", "Teo" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "2", "Nv2", "Ty" }, -1);
            lvBT2 = new ListView();
            clnSTT = new ColumnHeader();
            clnMa = new ColumnHeader();
            clnTen = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSTT = new TextBox();
            txtMa = new TextBox();
            txtTen = new TextBox();
            button1 = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // lvBT2
            // 
            lvBT2.Columns.AddRange(new ColumnHeader[] { clnSTT, clnMa, clnTen });
            lvBT2.FullRowSelect = true;
            lvBT2.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.StateImageIndex = 0;
            lvBT2.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lvBT2.Location = new Point(30, 43);
            lvBT2.Margin = new Padding(4, 5, 4, 5);
            lvBT2.Name = "lvBT2";
            lvBT2.Size = new Size(327, 346);
            lvBT2.TabIndex = 0;
            lvBT2.UseCompatibleStateImageBehavior = false;
            lvBT2.View = View.Details;
            lvBT2.SelectedIndexChanged += lvNhanVien_ColumnClick;
            // 
            // clnSTT
            // 
            clnSTT.Text = "STT";
            // 
            // clnMa
            // 
            clnMa.Text = "Ma";
            // 
            // clnTen
            // 
            clnTen.Text = "Ten";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 1;
            label1.Text = "STT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 149);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 2;
            label2.Text = "Ma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 226);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 3;
            label3.Text = "Ten";
            // 
            // txtSTT
            // 
            txtSTT.Location = new Point(513, 68);
            txtSTT.Margin = new Padding(4, 5, 4, 5);
            txtSTT.Name = "txtSTT";
            txtSTT.Size = new Size(189, 27);
            txtSTT.TabIndex = 4;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(513, 149);
            txtMa.Margin = new Padding(4, 5, 4, 5);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(189, 27);
            txtMa.TabIndex = 5;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(513, 223);
            txtTen.Margin = new Padding(4, 5, 4, 5);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(189, 27);
            txtTen.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(422, 287);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(136, 58);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(595, 287);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 60);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(794, 287);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 65);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(button1);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(txtSTT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvBT2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "listview";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lvBT2;
        private System.Windows.Forms.ColumnHeader clnSTT;
        private System.Windows.Forms.ColumnHeader clnMa;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}
