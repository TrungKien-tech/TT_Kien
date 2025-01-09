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
    public partial class FRMSINHVIEN : Form
    {
        DEMOSINHVIEN DbSinhVien = new DEMOSINHVIEN();
        public FRMSINHVIEN()
        {
            InitializeComponent();
        }

        private void FRMSINHVIEN_Load(object sender, EventArgs e)
        {
            //nhạp dữ liệu cho các thuộc tính
            fillDgvsinhvien();

            // Gắn sự kiện double click cho DataGridView
            dgvSinhvien.CellDoubleClick += dgvSinhvien_CellDoubleClick;

        }
        private void fillDgvsinhvien()
        {
            // Xóa toàn bộ dữ liệu hiện có trong DataGridView
            dgvSinhvien.Rows.Clear();

            List<SINHVIEN> listsinhvien = DbSinhVien.SINHVIEN.ToList();
            foreach (SINHVIEN sinhvien in listsinhvien)
            {
                int newRow = dgvSinhvien.Rows.Add();
                dgvSinhvien.Rows[newRow].Cells[0].Value = sinhvien.MASV;
                dgvSinhvien.Rows[newRow].Cells[1].Value = sinhvien.HOTEN;
                dgvSinhvien.Rows[newRow].Cells[2].Value = sinhvien.NGAYSINH;
                dgvSinhvien.Rows[newRow].Cells[3].Value = sinhvien.GIOITINH == true ? "Nam" : "Nữ"; //chuyển đổi giới tính do trong sql giá trị là bit.
                dgvSinhvien.Rows[newRow].Cells[4].Value = sinhvien.LOP;
                dgvSinhvien.Rows[newRow].Cells[5].Value = sinhvien.CHUYENNGANH;
                dgvSinhvien.Rows[newRow].Cells[6].Value = sinhvien.DIENTHOAI;
                dgvSinhvien.Rows[newRow].Cells[7].Value = sinhvien.EMAIL;


            }
        }

        private void dgvSinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void dgvSinhvien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng hợp lệ được nhấn đúp không
            if (e.RowIndex >= 0 && dgvSinhvien.Rows[e.RowIndex].Cells[0].Value != null)
            {
                // Lấy mã sinh viên từ dòng được chọn
                string maSV = dgvSinhvien.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Mở form cập nhật và truyền mã sinh viên
                var frmCapNhat = new frmcapnhatthongtin(maSV);
                if (frmCapNhat.ShowDialog() == DialogResult.OK) // Nếu cập nhật thành công
                {
                    // Tải lại danh sách sinh viên sau khi cập nhật
                    fillDgvsinhvien();
                }
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvSinhvien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy MASV của sinh viên được chọn
            string maSV = dgvSinhvien.SelectedRows[0].Cells[0].Value?.ToString();

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Không thể xác định sinh viên cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị xác nhận trước khi xóa
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên có mã {maSV} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var db = new DEMOSINHVIEN())
                {
                    try
                    {
                        // Tìm sinh viên trong cơ sở dữ liệu
                        var sinhVien = db.SINHVIEN.FirstOrDefault(sv => sv.MASV == maSV);

                        if (sinhVien != null)
                        {
                            // Xóa sinh viên khỏi cơ sở dữ liệu
                            db.SINHVIEN.Remove(sinhVien);
                            db.SaveChanges();

                            // Xóa dòng trong DataGridView
                            dgvSinhvien.Rows.RemoveAt(dgvSinhvien.SelectedRows[0].Index);

                            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra khi xóa sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {   //dùng để liên kết tới form khác như form main
            var frmthemmoi = new FRMThemMoi();
            if (frmthemmoi.ShowDialog() == DialogResult.OK) // Chỉ khi thêm mới thành công
            {
                // Tải lại danh sách sinh viên
                fillDgvsinhvien();
            }
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa từ TextBox
            string keyword = txttimkiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DEMOSINHVIEN())
            {
                try
                {
                    // Lấy danh sách sinh viên theo từ khóa
                    var results = db.SINHVIEN.Where(sv => sv.MASV.ToLower().Contains(keyword) || sv.HOTEN.ToLower().Contains(keyword) ||  sv.LOP.ToLower().Contains(keyword) || (sv.GIOITINH == true && keyword.ToLower() == "nam") || (sv.GIOITINH == false && keyword.ToLower() == "nữ") || sv.CHUYENNGANH.ToLower().Contains(keyword)).ToList();
                    // Xóa dữ liệu hiện tại trong DataGridView
                    dgvSinhvien.Rows.Clear();

                    // Hiển thị kết quả tìm kiếm
                    foreach (var sinhvien in results)
                    {
                        int newRow = dgvSinhvien.Rows.Add();
                        dgvSinhvien.Rows[newRow].Cells[0].Value = sinhvien.MASV;
                        dgvSinhvien.Rows[newRow].Cells[1].Value = sinhvien.HOTEN;
                        dgvSinhvien.Rows[newRow].Cells[2].Value = sinhvien.NGAYSINH;
                        dgvSinhvien.Rows[newRow].Cells[3].Value = sinhvien.GIOITINH == true ? "Nam" : "Nữ"; // test giới tính bằng kiểu bit.
                        dgvSinhvien.Rows[newRow].Cells[4].Value = sinhvien.LOP;
                        dgvSinhvien.Rows[newRow].Cells[5].Value = sinhvien.CHUYENNGANH;
                        dgvSinhvien.Rows[newRow].Cells[6].Value = sinhvien.DIENTHOAI;
                        dgvSinhvien.Rows[newRow].Cells[7].Value = sinhvien.EMAIL;
                    }

                    // Kiểm tra nếu không có kết quả
                    if (results.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sinh viên nào phù hợp với từ khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}



