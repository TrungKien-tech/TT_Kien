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
    public partial class FRMMONHOC : Form
    {
        DEMOSINHVIEN DbMonHoc = new DEMOSINHVIEN();
        public FRMMONHOC()
        {
            InitializeComponent();
        }

        private void FRMMONHOC_Load(object sender, EventArgs e)
        {
            // chuyền dữ liệu vào datagrv
            filldgvMonHoc();

            // Gắn sự kiện double click cho DataGridView
            dgvMonHoc.CellDoubleClick += dgvMonHoc_CellDoubleClick;

        }

        private void filldgvMonHoc()
        {

            // Xóa toàn bộ dữ liệu hiện có trong DataGridView
            dgvMonHoc.Rows.Clear();

            List<MONHOC> listmonhoc = DbMonHoc.MONHOC.ToList();
            foreach (MONHOC monhoc in listmonhoc)
            {
                int newRow = dgvMonHoc.Rows.Add();
                dgvMonHoc.Rows[newRow].Cells[0].Value = monhoc.MAMH;
                dgvMonHoc.Rows[newRow].Cells[1].Value = monhoc.TENMH;
                dgvMonHoc.Rows[newRow].Cells[2].Value = monhoc.SOTINCHI;
                dgvMonHoc.Rows[newRow].Cells[3].Value = monhoc.MAGV;



            }

        }
        private void dgvMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maMH = (int)dgvMonHoc.Rows[e.RowIndex].Cells[0].Value; // Lấy mã môn học
                var frmCapNhat = new frmcapnhatthongtinmonhoc(maMH); // Truyền mã môn học
                if (frmCapNhat.ShowDialog() == DialogResult.OK)
                {
                    // Tải lại danh sách môn học sau khi cập nhật
                    filldgvMonHoc();
                }
            }
        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
           
             if (dgvMonHoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã môn học (MAMH) của môn học được chọn
            int maMonHoc = Convert.ToInt32(dgvMonHoc.SelectedRows[0].Cells[0].Value);

            // Xác nhận xóa
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Tìm môn học trong cơ sở dữ liệu bằng MAMH
                    MONHOC monHocToDelete = DbMonHoc.MONHOC.FirstOrDefault(mh => mh.MAMH == maMonHoc);

                    // Kiểm tra nếu môn học tồn tại
                    if (monHocToDelete != null)
                    {
                        // Xóa môn học khỏi cơ sở dữ liệu
                        DbMonHoc.MONHOC.Remove(monHocToDelete);
                        DbMonHoc.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                        // Cập nhật lại DataGridView
                        filldgvMonHoc();

                        MessageBox.Show("Môn học đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Môn học không tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // liên kết tới form thêm môn học
            var frmthemmoi = new FRMThemMoiMonHoc();
            frmthemmoi.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txttimkiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                filldgvMonHoc();
            }
            else
            {
                var filteredList = DbMonHoc.MONHOC .Where(monhoc => monhoc.TENMH.Contains(keyword)).ToList();

                dgvMonHoc.Rows.Clear();

                foreach (MONHOC monhoc in filteredList)
                {
                    int newRow = dgvMonHoc.Rows.Add();
                    dgvMonHoc.Rows[newRow].Cells[0].Value = monhoc.MAMH;
                    dgvMonHoc.Rows[newRow].Cells[1].Value = monhoc.TENMH;
                    dgvMonHoc.Rows[newRow].Cells[2].Value = monhoc.SOTINCHI;
                    dgvMonHoc.Rows[newRow].Cells[3].Value = monhoc.MAGV;
                }

                if (filteredList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy môn học với từ khóa '" + keyword + "'", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
           
        }
    }
 }


