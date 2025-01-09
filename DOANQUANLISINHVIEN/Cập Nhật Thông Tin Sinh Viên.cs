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
    public partial class frmcapnhatthongtin : Form
    {
        private string _maSV; // Lưu mã sinh viên cần sửa
        public frmcapnhatthongtin(string maSV)
        {
            InitializeComponent();
            _maSV = maSV;  // Gán giá trị vào thuộc tính
        }

        private void frmcapnhatthongtin_Load(object sender, EventArgs e)
        {
            // Lấy thông tin sinh viên từ cơ sở dữ liệu
            using (var db = new DEMOSINHVIEN())
            {
                var sinhVien = db.SINHVIEN.FirstOrDefault(sv => sv.MASV == _maSV);
                if (sinhVien != null)
                {
                    // Đưa thông tin sinh viên vào các trường trên form
                    txtmasinhvien.Text = sinhVien.MASV;
                    txthoten.Text = sinhVien.HOTEN;
                    dtngaysinh.Value = sinhVien.NGAYSINH ?? DateTime.Now;
                    rdoNam.Checked = sinhVien.GIOITINH ?? true;
                    rdoNu.Checked = !(sinhVien.GIOITINH ?? false);
                    txtlop.Text = sinhVien.LOP;
                    cbbchuyennganh.Text = sinhVien.CHUYENNGANH;
                    txtdienthoai.Text = sinhVien.DIENTHOAI;
                    txtemail.Text = sinhVien.EMAIL;
                }
            }
        }
        

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            using (var db = new DEMOSINHVIEN())
            {
                // Lấy mã sinh viên từ TextBox
                string maSV = txtmasinhvien.Text;

                // Tìm sinh viên trong database dựa theo mã sinh viên
                var sinhVien = db.SINHVIEN.FirstOrDefault(sv => sv.MASV == maSV);
                if (sinhVien != null)
                {
                    // Kiểm tra đầu vào trước khi cập nhật
                    if (string.IsNullOrEmpty(txthoten.Text) || string.IsNullOrEmpty(txtlop.Text) || cbbchuyennganh.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cập nhật thông tin sinh viên
                    sinhVien.HOTEN = txthoten.Text;
                    sinhVien.NGAYSINH = dtngaysinh.Value;
                    sinhVien.GIOITINH = rdoNam.Checked && rdoNu.Checked;
                    sinhVien.LOP = txtlop.Text;
                    sinhVien.DIENTHOAI = txtdienthoai.Text;

                    if (cbbchuyennganh.SelectedItem != null)
                    {
                        sinhVien.CHUYENNGANH = cbbchuyennganh.SelectedItem.ToString();
                    }

                    // Lưu thay đổi vào database
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Trả về kết quả OK để thông báo cập nhật thành công
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
