using System.ComponentModel;

namespace Demo
{
    public partial class dta_Form : Form
    {
        public dta_Form()
        {
            InitializeComponent();
        }

        List<NhanVien> nhanvien;

        private void dta_Form_Load(object sender, EventArgs e)
        {
            nhanvien = new List<NhanVien>();
            nhanvien.Add(new NhanVien() { Ma = 22801954, Ten = "Vũ Văn Vương", Luongcb = 21000 });
            nhanvien.Add(new NhanVien() { Ma = 22751654, Ten = "Nguyễn Anh Tài", Luongcb = 22000 });
            nhanvien.Add(new NhanVien() { Ma = 21457854, Ten = "Cao Văn Lâm", Luongcb = 23000 });
            dtaNhanVien.DataSource = nhanvien;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //CSNhanVien form2 = new CSNhanVien(nhanvien,null);
                //form2.ShowDialog();

                //NhanVien newNhanvien = new NhanVien()
                //{
                //    Ma = int.Parse(txtId.Text),
                //    Ten = txtName.Text,
                //    Luongcb = int.Parse(txtLuong.Text)
                //};

                //if (nhanvien.Any(s => s.Ma == newNhanvien.Ma))
                //{
                //    MessageBox.Show("ID đã tồn tại, vui lòng nhập ID khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                //nhanvien.Add(newNhanvien);

                //dtaNhanVien.DataSource = null;
                //dtaNhanVien.DataSource = new BindingList<NhanVien>(nhanvien);

                // Đưa con trỏ đến dòng vừa thêm
                //dtaNhanVien.ClearSelection();
                //int addedIndex = nhanvien.IndexOf(newNhanvien); // Tìm vị trí dòng vừa thêm
                //if (addedIndex >= 0)
                //{
                //    dtaNhanVien.Rows[addedIndex].Selected = true; // Chọn dòng
                //    dtaNhanVien.CurrentCell = dtaNhanVien.Rows[addedIndex].Cells[0]; // Đưa con trỏ vào ô đầu tiên
                //}

                //txtId.Clear();
                //txtName.Clear();
                //txtLuong.Clear();
                CSNhanVien form2 = new CSNhanVien(nhanvien, null);
                form2.ShowDialog();

                // Làm mới DataGridView sau khi thêm
                dtaNhanVien.DataSource = null;
                dtaNhanVien.DataSource = new BindingList<NhanVien>(nhanvien);
                if (nhanvien.Count > 0)
                {
                    int lastIndex = nhanvien.Count - 1;
                    dtaNhanVien.ClearSelection(); // Xóa chọn cũ
                    dtaNhanVien.Rows[lastIndex].Selected = true; // Chọn dòng cuối
                    dtaNhanVien.CurrentCell = dtaNhanVien.Rows[lastIndex].Cells[0]; // Đưa con trỏ tới ô đầu tiên của dòng
                }
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dtaStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            // lấy ra dòng được chọn
            DataGridViewRow row = dtaNhanVien.Rows[e.RowIndex];
            // Đưa dữ liệu lên textbox
            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtLuong.Text = row.Cells[2].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtaNhanVien.SelectedRows.Count > 0)
            {
                int selectedIndex = dtaNhanVien.SelectedRows[0].Index;
                NhanVien selectedNhanVien = nhanvien[selectedIndex];

                // Mở form chỉnh sửa
                CSNhanVien form2 = new CSNhanVien(nhanvien, selectedNhanVien);
                form2.ShowDialog();

                // Làm mới DataGridView
                dtaNhanVien.DataSource = null;
                dtaNhanVien.DataSource = new BindingList<NhanVien>(nhanvien);

                // Giữ con trỏ tại dòng vừa sửa
                dtaNhanVien.ClearSelection();
                dtaNhanVien.Rows[selectedIndex].Selected = true;

                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtaNhanVien.SelectedRows.Count > 0)
            {
                int selectedIndex = dtaNhanVien.SelectedRows[0].Index;

                nhanvien.RemoveAt(selectedIndex);

                dtaNhanVien.DataSource = null;
                dtaNhanVien.DataSource = new BindingList<NhanVien>(nhanvien);

                // Đưa con trỏ đến dòng gần nhất
                if (nhanvien.Count > 0)
                {
                    int newIndex = Math.Min(selectedIndex, nhanvien.Count - 1);
                    dtaNhanVien.ClearSelection();
                    dtaNhanVien.Rows[newIndex].Selected = true;
                }

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đóng form hiện tại
                this.Close();
            }
        }
    }
}