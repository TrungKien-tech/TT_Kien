using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baitap6.Models;

namespace baitap6
{
    public partial class Form1 : Form
    {
        QUANLISINHVIEN DbSinhvien = new QUANLISINHVIEN();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldgvSinhvien();
            fillcbbKhoa();
        }
        private void  filldgvSinhvien()
        {
            List<STUDENT> liststudent = DbSinhvien.STUDENT.ToList();
            foreach (STUDENT student in liststudent)
            {
                int newRow = dgvSinhVien.Rows.Add();
                dgvSinhVien.Rows[newRow].Cells[0].Value = student.MASV;
                dgvSinhVien.Rows[newRow].Cells[1].Value = student.TENSV;
                dgvSinhVien.Rows[newRow].Cells[2].Value = student.DTB;
                dgvSinhVien.Rows[newRow].Cells[3].Value = student.KHOA.TENKHOA;
            }
        }
        private void fillcbbKhoa()
        {
            List<KHOA> listkhoa = DbSinhvien.KHOA.ToList();

            cbbKhoa.DataSource = listkhoa;
            cbbKhoa.DisplayMember = "TENKHOA";
            cbbKhoa.ValueMember = "MAKHOA";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ form
                string maSV = txtMSSV.Text;
                string tenSV = txtHoten.Text;
                float dtb = float.Parse(txtDTB.Text);
                int maKhoa = int.Parse(cbbKhoa.SelectedValue.ToString());

                // Tạo đối tượng sinh viên mới
                STUDENT newStudent = new STUDENT
                {
                    MASV = maSV,
                    TENSV = tenSV,
                    DTB = dtb,
                    MAKHOA = maKhoa
                };

                // Thêm vào database
                DbSinhvien.STUDENT.Add(newStudent);
                DbSinhvien.SaveChanges();

                // Cập nhật lại DataGridView
                dgvSinhVien.Rows.Clear();
                filldgvSinhvien();

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btrnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có hàng nào được chọn không
                if (dgvSinhVien.CurrentRow != null)
                {
                    // Lấy MASV từ hàng được chọn
                    string maSV = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();

                    // Tìm đối tượng sinh viên trong database
                    STUDENT student = DbSinhvien.STUDENT.FirstOrDefault(s => s.MASV == maSV);

                    if (student != null)
                    {
                        // Cập nhật thông tin
                        student.TENSV = txtHoten.Text;
                        student.DTB = float.Parse(txtDTB.Text);
                        student.MAKHOA = int.Parse(cbbKhoa.SelectedValue.ToString());

                        // Lưu thay đổi
                        DbSinhvien.SaveChanges();

                        // Cập nhật lại DataGridView
                        dgvSinhVien.Rows.Clear();
                        filldgvSinhvien();

                        MessageBox.Show("Sửa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvSinhVien.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgvSinhVien.Rows.RemoveAt(dgvSinhVien.CurrentRow.Index);
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
