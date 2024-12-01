namespace demo_myclass
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            chkSports = new CheckBox();
            chkMovies = new CheckBox();
            chkTravel = new CheckBox();
            datePickerDOB = new DateTimePicker();
            rbtnMale = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 21);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Thông tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 67);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 137);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 67);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 142);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Sở thích";
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 27);
            txtName.TabIndex = 5;
            // 
            // chkSports
            // 
            chkSports.AutoSize = true;
            chkSports.Location = new Point(495, 142);
            chkSports.Name = "chkSports";
            chkSports.Size = new Size(89, 24);
            chkSports.TabIndex = 9;
            chkSports.Text = "Thể thao";
            chkSports.UseVisualStyleBackColor = true;
            // 
            // chkMovies
            // 
            chkMovies.AutoSize = true;
            chkMovies.Location = new Point(629, 142);
            chkMovies.Name = "chkMovies";
            chkMovies.Size = new Size(92, 24);
            chkMovies.TabIndex = 10;
            chkMovies.Text = "Phim ảnh";
            chkMovies.UseVisualStyleBackColor = true;
            // 
            // chkTravel
            // 
            chkTravel.AutoSize = true;
            chkTravel.Location = new Point(754, 142);
            chkTravel.Name = "chkTravel";
            chkTravel.Size = new Size(77, 24);
            chkTravel.TabIndex = 11;
            chkTravel.Text = "Du lịch";
            chkTravel.UseVisualStyleBackColor = true;
            // 
            // datePickerDOB
            // 
            datePickerDOB.Location = new Point(471, 60);
            datePickerDOB.Name = "datePickerDOB";
            datePickerDOB.Size = new Size(250, 27);
            datePickerDOB.TabIndex = 12;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(129, 135);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(62, 24);
            rbtnMale.TabIndex = 13;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Nam";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(242, 135);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(572, 253);
            button1.Name = "button1";
            button1.Size = new Size(164, 59);
            button1.TabIndex = 15;
            button1.Text = "Xuất thông tin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 450);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(rbtnMale);
            Controls.Add(datePickerDOB);
            Controls.Add(chkTravel);
            Controls.Add(chkMovies);
            Controls.Add(chkSports);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Demo myclass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private CheckBox chkSports;
        private CheckBox chkMovies;
        private CheckBox chkTravel;
        private DateTimePicker datePickerDOB;
        private RadioButton rbtnMale;
        private RadioButton radioButton2;
        private Button button1;
    }
}
