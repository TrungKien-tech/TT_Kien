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
    public partial class FRMThemMoiMonHoc : Form
    {
        public FRMThemMoiMonHoc()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (var db = new DEMOSINHVIEN())
            {
                try
                {
                    // Lấy dữ liệu từ giao diện người dùng
                    string tenMH = txtmonhoc.Text.Trim();
                    string maGV = txtmagiangvien.Text.Trim();
                    string soTinChiStr = txtsotinchi.Text.Trim();

                    // Kiểm tra nếu tên môn học hoặc mã giảng viên bị bỏ trống
                    if (string.IsNullOrEmpty(tenMH) || string.IsNullOrEmpty(maGV) || string.IsNullOrEmpty(soTinChiStr))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Chuyển đổi số tín chỉ từ chuỗi sang int
                    int soTinChi;
                    if (!int.TryParse(soTinChiStr, out soTinChi))
                    {
                        MessageBox.Show("Số tín chỉ phải là một số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Kiểm tra nếu môn học đã tồn tại
                    if (db.MONHOC.Any(mh => mh.TENMH == tenMH))
                    {
                        MessageBox.Show("Tên môn học đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo đối tượng MONHOC mới
                    MONHOC newMonHoc = new MONHOC
                    {
                        TENMH = tenMH,
                        MAGV = maGV,
                        SOTINCHI = soTinChi // Gán số tín chỉ đã chuyển đổi
                    };

                    // Thêm môn học vào cơ sở dữ liệu
                    db.MONHOC.Add(newMonHoc);
                    db.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    MessageBox.Show("Thêm môn học mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đóng form sau khi lưu
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
