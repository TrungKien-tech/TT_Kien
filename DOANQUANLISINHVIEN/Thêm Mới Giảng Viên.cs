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
    public partial class FRMTHEMMOIGV : Form
    {
        public FRMTHEMMOIGV()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            using (var db = new DEMOSINHVIEN())
            {
                try
                {
                    // Tạo đối tượng giảng viên mới
                    GIANGVIEN newGiangVien = new GIANGVIEN
                    {
                        MAGV = txtmagiangvien.Text.Trim(),
                        HOTEN = txthoten.Text.Trim(),
                        NGAYSINH = dtngaysinh.Value.Date,
                        GIOITINH = rdoNam.Checked, // True nếu chọn Nam, False nếu chọn Nữ 
                        DIENTHOAI = txtdienthoai.Text.Trim(),
                        EMAIL = txtemail.Text.Trim()
                    };

                    // Kiểm tra nếu MAGV đã tồn tại trong cơ sở dữ liệu
                    if (db.GIANGVIEN.Any(sv => sv.MAGV == newGiangVien.MAGV))
                    {
                        MessageBox.Show("Mã giảng viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Thêm giảng viên vào cơ sở dữ liệu
                    db.GIANGVIEN.Add(newGiangVien);
                    db.SaveChanges();

                    MessageBox.Show("Thêm giảng viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            //đóng form và không thông báo.
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
