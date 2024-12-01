using System.Xml.Linq;

namespace demo_myclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các ô nhập liệu và nút chọn
            string name = txtName.Text;
            string dob = datePickerDOB.Value.ToString("MM/dd/yyyy"); // Định dạng ngày sinh
            string gender = rbtnMale.Checked ? "Nam" : "Nữ";

            // Thu thập sở thích
            string hobbies = "";
            if (chkSports.Checked) hobbies += "Thể thao, ";
            if (chkMovies.Checked) hobbies += "Phim ảnh, ";
            if (chkTravel.Checked) hobbies += "Du lịch, ";

            // Xóa dấu phẩy cuối (nếu có)
            hobbies = hobbies.TrimEnd(',', ' ');

            // Tạo chuỗi thông tin
            string userInfo = $"Họ tên: {name}, Giới tính: {gender}, Ngày sinh: {dob}, Sở thích: {hobbies}";

            // Hiển thị thông tin trong hộp thoại
            MessageBox.Show(userInfo, "Thông tin người dùng");
        }
    }
}
