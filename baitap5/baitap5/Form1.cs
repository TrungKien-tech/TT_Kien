using System.Drawing.Text;

namespace baitap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                toolStripComboBox2.Items.Add(s);
            }
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                rtbvanban.ForeColor = fontDlg.Color;
                rtbvanban.Font = fontDlg.Font;
            }
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            if (rtbvanban.SelectionFont != null)
            {
                FontStyle style = rtbvanban.SelectionFont.Style;
                if (rtbvanban.SelectionFont.Bold)
                {
                    //nếu văn bản đã đậm, xóa thuộc tính bold ra khỏi fontstyle hiện tại
                    style &= FontStyle.Bold;
                }
                else
                {
                    // nếu văn bản chưa đậm, thêm thuộc tính bold vào fontstyle hiện tại
                    style |= FontStyle.Bold;
                }
                rtbvanban.SelectionFont = new Font(rtbvanban.SelectionFont, style);
            }
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            if (rtbvanban.SelectionFont != null)
            {
                FontStyle style = rtbvanban.SelectionFont.Style;
                if (rtbvanban.SelectionFont.Italic)
                {
                    //nếu văn bản đã đậm, xóa thuộc tính italic ra khỏi fontstyle hiện tại
                    style &= FontStyle.Italic;
                }
                else
                {
                    // nếu văn bản chưa đậm, thêm thuộc tính italic vào fontstyle hiện tại
                    style |= FontStyle.Italic;
                }
                rtbvanban.SelectionFont = new Font(rtbvanban.SelectionFont, style);
            }
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            if (rtbvanban.SelectionFont != null)
            {
                FontStyle style = rtbvanban.SelectionFont.Style;
                if (rtbvanban.SelectionFont.Underline)
                {
                    //nếu văn bản đã đậm, xóa thuộc tính underline ra khỏi fontstyle hiện tại
                    style &= FontStyle.Underline;
                }
                else
                {
                    // nếu văn bản chưa đậm, thêm thuộc tính underline vào fontstyle hiện tại
                    style |= FontStyle.Underline;
                }
                rtbvanban.SelectionFont = new Font(rtbvanban.SelectionFont, style);
            }
        }

        private void lưuNộiDungVănBảnCtrlSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CheckFileExists = true;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.Filter = "textfile(*.txt)|*.txt|ALL Filter(*.*)|(*.*)";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, rtbvanban.Text);
                    MessageBox.Show("Tep da duoc luu thanh cong", "Luu tep", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Co loi xay ra khi luu tep" + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "textfile(*.txt)|*.txt|ALL Filter(*.*)|(*.*)|richtext files(*.rtf)|*.rtf";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                try
                {
                    if (Path.GetExtension(selectedFileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {


                        rtbvanban.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        rtbvanban.LoadFile(selectedFileName, RichTextBoxStreamType.RichText);
                    }
                    MessageBox.Show("Tep da duoc mo thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Co loi xay ra khi mo tep" + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
  }

