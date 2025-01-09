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
    public partial class frmdangkyhocphan : Form
    {
        public frmdangkyhocphan()
        {
            InitializeComponent();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {

            using (var db = new DEMOSINHVIEN())
            {
                try
                {
                    // Lấy thông tin từ các điều khiển trên form
                    string maDangKy = cbbmadangky.SelectedItem?.ToString(); 
                    string tenMonHoc = cbbtenmonhoc.SelectedItem?.ToString(); 
                    string maGiangVien = txtmagiangvien.Text.Trim(); 
                    string maSinhVien = txtmasinhvien.Text.Trim();
                    string hoTen = txthoten.Text.Trim();
                    DateTime ngayDangKy = DateTime.Now; 

                    // Kiểm tra thông tin cần thiết
                    if (string.IsNullOrEmpty(maDangKy) || string.IsNullOrEmpty(tenMonHoc) ||
                        string.IsNullOrEmpty(maGiangVien) || string.IsNullOrEmpty(maSinhVien) || string.IsNullOrEmpty(hoTen))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo đối tượng đăng ký học phần mới
                    DANGKYMONHOC newDangKy = new DANGKYMONHOC
                    {
                        MADK = maDangKy,
                        TENMONHOC = tenMonHoc,
                        MAGV = maGiangVien,
                        MASV = maSinhVien,
                        HOTEN = hoTen,
                        NGAYDANGKY = ngayDangKy
                    };
                    db.DANGKYMONHOC.Add(newDangKy);
                    db.SaveChanges();

                    // Thông báo thành công
                    MessageBox.Show("Đăng ký học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đóng form sau khi đăng ký thành công
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra khi đăng ký học phần: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
