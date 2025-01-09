using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANQUANLISINHVIEN
{
    public partial class MAINFORM : Form
    {
        public MAINFORM()
        {
            InitializeComponent();
        }
      
        private void toolstripSinhVien_Click(object sender, EventArgs e)
        {

             var frmsinhvien = new FRMSINHVIEN();  
             frmsinhvien.Show();
        }

        private void toolstripGiangVien_Click(object sender, EventArgs e)
        {
            // Tạo instance của form FRMGIANGVIEN
            var frmGiangVien = new FRMGIANGVIEN();

            // Hiển thị form dưới dạng hộp thoại
            frmGiangVien.Show();
        }

        private void toolstripMonHoc_Click(object sender, EventArgs e)
        {
            // Tạo instance của form FRMMONHOC
            var frmMonHoc = new FRMMONHOC();

            // Hiển thị form dưới dạng hộp thoại
            frmMonHoc.Show();
        }

        private void toolstripdangxuat_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo xác nhận
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?","Xác nhận đăng xuất", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Đóng MainForm và mở lại form Đăng nhập
                this.Hide(); // Ẩn MainForm
                var frmDangNhap = new DangNhap(); // Tạo form Đăng nhập
                frmDangNhap.ShowDialog(); // Hiển thị form Đăng nhập
                this.Close(); // Đóng MainForm sau khi đăng xuất
            }
        }

        private void toolstripDKMH_Click(object sender, EventArgs e)
        {

            // Tạo instance của form FRMDANGKYMONHOC
            var frmDangKyMonHoc = new FRMDANGKYMONHOC();

            // Hiển thị form dưới dạng hộp thoại
            frmDangKyMonHoc.Show();
        }
    }
}
