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
    public partial class frmcapnhatthongtinmonhoc : Form
    {
        private int _maMH;
        public frmcapnhatthongtinmonhoc(int maMH)
        {
            InitializeComponent();
            _maMH = maMH; // Lưu mã môn học
        }

        private void frmcapnhatthongtinmonhoc_Load(object sender, EventArgs e)
        {
            using (var db = new DEMOSINHVIEN())
            {
                var monHoc = db.MONHOC.FirstOrDefault(mh => mh.MAMH == _maMH);
                if (monHoc != null)
                {
                    txttenmonhoc.Text = monHoc.TENMH;
                    txtsotinchi.Text = monHoc.SOTINCHI.ToString();
                    txtmagiangvien.Text = monHoc.MAGV;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            using (var db = new DEMOSINHVIEN())
            {
                // Kiểm tra thông tin nhập
                if (string.IsNullOrWhiteSpace(txttenmonhoc.Text) ||string.IsNullOrWhiteSpace(txtsotinchi.Text) || string.IsNullOrWhiteSpace(txtmagiangvien.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra mã môn học (_maMH) đã được truyền vào từ form chính
                var monHoc = db.MONHOC.FirstOrDefault(mh => mh.MAMH == _maMH);
                if (monHoc != null)
                {
                    // Cập nhật thông tin
                    monHoc.TENMH = txttenmonhoc.Text.Trim();

                    if (int.TryParse(txtsotinchi.Text.Trim(), out int soTinChi))
                    {
                        monHoc.SOTINCHI = soTinChi;
                    }
                    else
                    {
                        MessageBox.Show("Số tín chỉ phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    monHoc.MAGV = txtmagiangvien.Text.Trim();

                    // Lưu thay đổi vào cơ sở dữ liệu
                    db.SaveChanges();

                    MessageBox.Show("Cập nhật thông tin môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đóng form sau khi cập nhật thành công
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy môn học để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {       

            this.Close();
        }
    }
}
