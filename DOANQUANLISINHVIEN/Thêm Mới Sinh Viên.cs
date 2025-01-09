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
    public partial class FRMThemMoi : Form
    {
        public FRMThemMoi()
        {
            InitializeComponent();
        }

        private void FRMThemMoi_Load(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            using (var db = new DEMOSINHVIEN())
            {
                try
                {
                    // Tạo đối tượng sinh viên mới
                    SINHVIEN newSinhVien = new SINHVIEN
                    {
                        MASV = txtmasinhvien.Text.Trim(),
                        HOTEN = txthoten.Text.Trim(),
                        NGAYSINH = dtngaysinh.Value.Date,
                        GIOITINH = rdoNam.Checked, // True nếu chọn Nam, False nếu chọn Nữ
                        LOP = txtlop.Text.Trim(),
                        CHUYENNGANH = cbbchuyennganh.Text.Trim(),
                        DIENTHOAI = txtdienthoai.Text.Trim(),
                        EMAIL = txtemail.Text.Trim()
                    };

                    // Kiểm tra nếu MASV đã tồn tại trong cơ sở dữ liệu
                    if (db.SINHVIEN.Any(sv => sv.MASV == newSinhVien.MASV))
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (db.SINHVIEN.Any(sv => sv.HOTEN == newSinhVien.HOTEN))
                    {
                        MessageBox.Show("Tên sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Thêm sinh viên vào cơ sở dữ liệu
                    db.SINHVIEN.Add(newSinhVien);
                    db.SaveChanges();

                    MessageBox.Show("Thêm sinh viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Trả về kết quả OK và đóng form
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
            // đóng form 
            this.DialogResult = DialogResult.Cancel;
            this.Close();
           
        }
    }
}
