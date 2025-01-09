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
    public partial class frmcapnhatthongtingiangvien : Form
    {
        private string _maGV; // lưu mã giảng viên cần sửa
        public frmcapnhatthongtingiangvien(string maGV)
        {
            InitializeComponent();
            _maGV = maGV;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            using (var db = new DEMOSINHVIEN())
            {
                // Lấy mã giang viên từ TextBox
                string maGV = txtmagiangvien.Text;

                // Tìm giang viên trong database dựa theo mã giang viên
                var giangVien = db.GIANGVIEN.FirstOrDefault(gv => gv.MAGV == maGV);
                if (giangVien != null)
                {
                    // Kiểm tra đầu vào trước khi cập nhật
                    if (string.IsNullOrEmpty(txthoten.Text) || string.IsNullOrEmpty(txtmagiangvien.Text))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cập nhật thông tin giang viên
                    giangVien.HOTEN = txthoten.Text;
                    giangVien.NGAYSINH = dtngaysinh.Value;
                    giangVien.GIOITINH = rdoNam.Checked;
                    giangVien.DIENTHOAI = txtdienthoai.Text;
                    giangVien.EMAIL = txtemail.Text;

                    // Lưu thay đổi vào database
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thông tin giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Trả về kết quả OK để thông báo cập nhật thành công
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy giảng viên để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmcapnhatthongtingiangvien_Load(object sender, EventArgs e)
        {
            // Lấy thông tin giảng viên từ cơ sở dữ liệu khi form được tải
            using (var db = new DEMOSINHVIEN())  // Thay DEMOSINHVIEN bằng lớp kết nối của bạn
            {
                var giangVien = db.GIANGVIEN.FirstOrDefault(gv => gv.MAGV == _maGV);  // Giả sử bạn có bảng GIANGVIEN
                if (giangVien != null)
                {
                    // Đưa thông tin giảng viên vào các trường trên form
                    txtmagiangvien.Text = giangVien.MAGV;
                    txthoten.Text = giangVien.HOTEN;
                    dtngaysinh.Value = giangVien.NGAYSINH ?? DateTime.Now;
                    rdoNam.Checked = giangVien.GIOITINH ?? true;
                    rdoNu.Checked = !(giangVien.GIOITINH ?? false);
                    txtdienthoai.Text = giangVien.DIENTHOAI;
                    txtemail.Text = giangVien.EMAIL;

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
