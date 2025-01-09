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
    public partial class FRMGIANGVIEN : Form
    {
        DEMOSINHVIEN DbGiangVien = new DEMOSINHVIEN();
       

        public FRMGIANGVIEN()
        {
            InitializeComponent();
        }

        private void FRMGIANGVIEN_Load(object sender, EventArgs e)
        {
            filldgvGiangVien();

            // Gắn sự kiện double click cho DataGridView
            dgvGiangVien.CellDoubleClick += dgvGiangvien_CellDoubleClick;
        }

        private void filldgvGiangVien()
        {

            // Xóa toàn bộ dữ liệu hiện có trong DataGridView
            dgvGiangVien.Rows.Clear();

            List<GIANGVIEN> listgiangvien = DbGiangVien.GIANGVIEN.ToList();
            foreach (GIANGVIEN giangvien in listgiangvien)
            {
                int newRow = dgvGiangVien.Rows.Add();
                dgvGiangVien.Rows[newRow].Cells[0].Value = giangvien.MAGV;
                dgvGiangVien.Rows[newRow].Cells[1].Value = giangvien.HOTEN;
                dgvGiangVien.Rows[newRow].Cells[2].Value = giangvien.NGAYSINH;
                dgvGiangVien.Rows[newRow].Cells[3].Value = giangvien.GIOITINH == true ? "Nam" : "Nữ"; //chuyển đổi giới tính do trong sql giá trị là bit.
                dgvGiangVien.Rows[newRow].Cells[4].Value = giangvien.DIENTHOAI;
                dgvGiangVien.Rows[newRow].Cells[5].Value = giangvien.EMAIL;


            }
        }

        private void dgvGiangvien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có dòng hợp lệ được nhấn đúp không
            if (e.RowIndex >= 0 && dgvGiangVien.Rows[e.RowIndex].Cells[0].Value != null)
            {
                // Lấy mã giảng viên từ dòng được chọn
                string maGV = dgvGiangVien.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Mở form cập nhật và truyền mã giảng viên
                var frmCapNhat = new frmcapnhatthongtingiangvien(maGV);
                if (frmCapNhat.ShowDialog() == DialogResult.OK) // Nếu cập nhật thành công
                {
                    // Tải lại danh sách giảng viên sau khi cập nhật
                    filldgvGiangVien();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một giảng viên hay chưa
            if (dgvGiangVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một giảng viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã giảng viên từ dòng được chọn
            string maGV = dgvGiangVien.SelectedRows[0].Cells[0].Value.ToString();

            // Hiển thị xác nhận trước khi xóa
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa giảng viên với Mã: {maGV} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var db = new DEMOSINHVIEN())
                {
                    try
                    {
                        // Tìm giảng viên trong cơ sở dữ liệu
                        var giangVien = db.GIANGVIEN.FirstOrDefault(gv => gv.MAGV == maGV);

                        if (giangVien != null)
                        {
                            // Lấy danh sách các môn học do giảng viên này dạy
                            var monHocList = db.MONHOC.Where(mh => mh.MAGV == maGV).ToList();

                            // Tìm giảng viên chưa dạy bất kỳ môn học nào
                            var giangVienThayThe = db.GIANGVIEN
                                .Where(gv => gv.MAGV != maGV && !db.MONHOC.Any(mh => mh.MAGV == gv.MAGV))
                                .FirstOrDefault();

                            if (giangVienThayThe != null)
                            {
                                // Gán mã giảng viên thay thế cho các môn học
                                foreach (var monHoc in monHocList)
                                {
                                    monHoc.MAGV = giangVienThayThe.MAGV;
                                }
                            }
                            else
                            {
                                // Nếu không tìm thấy giảng viên thay thế, thông báo lỗi
                                MessageBox.Show("Không có giảng viên nào chưa được phân công môn học. Hãy thêm giảng viên mới trước khi xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Xóa giảng viên
                            db.GIANGVIEN.Remove(giangVien);

                            // Lưu thay đổi vào cơ sở dữ liệu
                            db.SaveChanges();

                            // Cập nhật lại DataGridView
                            dgvGiangVien.Rows.RemoveAt(dgvGiangVien.SelectedRows[0].Index);

                            MessageBox.Show($"Xóa giảng viên thành công! Các môn học của giảng viên đã được chuyển sang giảng viên có mã: {giangVienThayThe.MAGV}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy giảng viên trong cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa giảng viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                    var results = db.GIANGVIEN.Where(gv => gv.MAGV.ToLower().Contains(keyword) || gv.EMAIL.ToLower().Contains(keyword) || gv.HOTEN.ToLower().Contains(keyword)).ToList();

                    // Xóa dữ liệu hiện tại trong DataGridView
                    dgvGiangVien.Rows.Clear();

                    // Hiển thị kết quả tìm kiếm
                    foreach (var giangvien in results)
                    {
                        int newRow = dgvGiangVien.Rows.Add();
                       dgvGiangVien.Rows[newRow].Cells[0].Value = giangvien.MAGV;
                       dgvGiangVien.Rows[newRow].Cells[1].Value = giangvien.HOTEN;
                       dgvGiangVien.Rows[newRow].Cells[2].Value = giangvien.NGAYSINH;
                       dgvGiangVien.Rows[newRow].Cells[3].Value = giangvien.GIOITINH == true ? "Nam" : "Nữ"; // test giới tính bằng kiểu bit.
                       dgvGiangVien.Rows[newRow].Cells[4].Value = giangvien.DIENTHOAI;
                       dgvGiangVien.Rows[newRow].Cells[5].Value = giangvien.EMAIL;
                    }

                    // Kiểm tra nếu không có kết quả
                    if (results.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy giang viên nào phù hợp với từ khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            // liêm kết tới form thêm mới
            var frmthemmoi = new FRMTHEMMOIGV();
            if (frmthemmoi.ShowDialog() == DialogResult.OK) // Chỉ khi thêm mới thành công
            {
                // Tải lại danh sách sinh viên
                filldgvGiangVien();
            }
        }
    }
    
}
