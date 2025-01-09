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
    public partial class FRMDANGKYMONHOC : Form
    {
        DEMOSINHVIEN DbDangKy = new DEMOSINHVIEN();
        public FRMDANGKYMONHOC()
        {
            InitializeComponent();
        }

        private void FRMDANGKYMONHOC_Load(object sender, EventArgs e)
        {
            //dữ liệu chuyền vào
            filldgvDangKy();
        }

        private void filldgvDangKy()
        {
            List<DANGKYMONHOC> listdangky = DbDangKy.DANGKYMONHOC.ToList();
            foreach (DANGKYMONHOC dangky in listdangky)
            {
                int newRow = dgvDangkymonhoc.Rows.Add();
                dgvDangkymonhoc.Rows[newRow].Cells[0].Value = dangky.MADK;
                dgvDangkymonhoc.Rows[newRow].Cells[1].Value = dangky.TENMONHOC;
                dgvDangkymonhoc.Rows[newRow].Cells[2].Value = dangky.MASV;
                dgvDangkymonhoc.Rows[newRow].Cells[3].Value = dangky.HOTEN;
                dgvDangkymonhoc.Rows[newRow].Cells[4].Value = dangky.MAGV;
                dgvDangkymonhoc.Rows[newRow].Cells[5].Value = dangky.NGAYDANGKY;





            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvDangkymonhoc.SelectedRows.Count > 0)
            {
                // Lấy MADK từ dòng được chọn (kiểu string)
                int selectedRowIndex = dgvDangkymonhoc.SelectedRows[0].Index;
                string madk = dgvDangkymonhoc.Rows[selectedRowIndex].Cells[0].Value.ToString();

                // Xác nhận xóa
                DialogResult confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa học phần này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Xóa học phần từ cơ sở dữ liệu
                        var dangKy = DbDangKy.DANGKYMONHOC.FirstOrDefault(dk => dk.MADK == madk);
                        if (dangKy != null)
                        {
                            DbDangKy.DANGKYMONHOC.Remove(dangKy);
                            DbDangKy.SaveChanges();

                            // Cập nhật lại DataGridView
                            filldgvDangKy();
                            MessageBox.Show("Xóa học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy học phần để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi xóa học phần: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học phần cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndangkymoi_Click(object sender, EventArgs e)
        {
            var frmdangky = new  frmdangkyhocphan();
            frmdangky.ShowDialog();
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
                    // Lấy danh sách đăng ký môn học theo từ khóa
                    var results = db.DANGKYMONHOC.Where(dk => dk.MADK.ToLower().Contains(keyword) ||dk.TENMONHOC.ToLower().Contains(keyword) || dk.MASV.ToLower().Contains(keyword) || dk.HOTEN.ToLower().Contains(keyword) || dk.MAGV.ToLower().Contains(keyword)).ToList();

                    // Xóa dữ liệu hiện tại trong DataGridView
                    dgvDangkymonhoc.Rows.Clear();

                    // Hiển thị kết quả tìm kiếm
                    foreach (var dangky in results)
                    {
                        int newRow = dgvDangkymonhoc.Rows.Add();
                        dgvDangkymonhoc.Rows[newRow].Cells[0].Value = dangky.MADK;
                        dgvDangkymonhoc.Rows[newRow].Cells[1].Value = dangky.TENMONHOC;
                        dgvDangkymonhoc.Rows[newRow].Cells[2].Value = dangky.MASV;
                        dgvDangkymonhoc.Rows[newRow].Cells[3].Value = dangky.HOTEN;
                        dgvDangkymonhoc.Rows[newRow].Cells[4].Value = dangky.MAGV;
                        dgvDangkymonhoc.Rows[newRow].Cells[5].Value = dangky.NGAYDANGKY.HasValue ? dangky.NGAYDANGKY.Value.ToString("dd/MM/yyyy") : "";

                    }

                    // Kiểm tra nếu không có kết quả
                    if (results.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả nào phù hợp với từ khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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