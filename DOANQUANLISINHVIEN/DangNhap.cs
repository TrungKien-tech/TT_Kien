using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOANQUANLISINHVIEN.SQLSINHVIEN;

namespace DOANQUANLISINHVIEN
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();

            using (var db = new DEMOSINHVIEN())
            {
                var NguoiDung = db.DANGNHAP.FirstOrDefault(nd => nd.TAIKHOAN == taikhoan && nd.MATKHAU == matkhau);

                if (NguoiDung != null)
                {
                  
                    // Mở MainForm
                    MAINFORM mainForm = new MAINFORM();
                    mainForm.Show();

                    // Ẩn form đăng nhập
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận thoát
            DialogResult result = MessageBox.Show( "Bạn có chắc chắn muốn thoát không?","Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát hoàn toàn ứng dụng
            }
        }
    }
}
