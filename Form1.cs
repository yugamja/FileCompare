using System.Linq;

namespace FileCompare
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void PopulateListView(ListView lv, string folderPath)
        {
            lv.BeginUpdate();
            lv.Items.Clear();
            try
            { // 폴더(디렉터리) 먼저추가
                var dirs = Directory.EnumerateDirectories(folderPath)
                .Select(p => new DirectoryInfo(p))
                .OrderBy(d => d.Name);
                foreach (var d in dirs)
                {
                    var item = new ListViewItem(d.Name);
                    item.SubItems.Add("<DIR>");
                    item.SubItems.Add(d.LastWriteTime.ToString("g"));
                    lv.Items.Add(item);
                }
                // 파일추가
                var files = Directory.EnumerateFiles(folderPath)
                .Select(p => new FileInfo(p))
                .OrderBy(f => f.Name);

                foreach (var f in files)
                {
                    var item = new ListViewItem(f.Name);
                    item.SubItems.Add(f.Length.ToString("N0") + " 바이트");
                    item.SubItems.Add(f.LastWriteTime.ToString("g"));

                    if (lv == lvwLeftDir && Directory.Exists(txtRightDir.Text))
                    {
                        string rightPath = Path.Combine(txtRightDir.Text, f.Name);

                        if (!File.Exists(rightPath))
                        {
                            item.Tag = "ONLY";
                        }
                        else
                        {
                            var rf = new FileInfo(rightPath);

                            if (f.LastWriteTime == rf.LastWriteTime)
                                item.Tag = "SAME";
                            else if (f.LastWriteTime > rf.LastWriteTime)
                                item.Tag = "NEW";   // 왼쪽이 더 최신
                            else
                                item.Tag = "OLD";   // 왼쪽이 더 오래됨
                        }
                    }
                    else if (lv == lvwRightDir && Directory.Exists(txtLeftDir.Text))
                    {
                        string leftPath = Path.Combine(txtLeftDir.Text, f.Name);

                        if (!File.Exists(leftPath))
                        {
                            item.Tag = "ONLY";
                        }
                        else
                        {
                            var lf = new FileInfo(leftPath);

                            if (f.LastWriteTime == lf.LastWriteTime)
                                item.Tag = "SAME";
                            else if (f.LastWriteTime > lf.LastWriteTime)
                                item.Tag = "NEW";   // 오른쪽이 더 최신
                            else
                                item.Tag = "OLD";   // 오른쪽이 더 오래됨
                        }
                    }

                    lv.Items.Add(item);
                }


                // 컬럼너비자동조정(컨텐츠기준)
                for (int i = 0; i < lv.Columns.Count; i++)
                {
                    lv.AutoResizeColumn(i,
                    ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(this, "폴더를찾을수없습니다.", "오류",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, "입출력오류: " + ex.Message, "오류",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lv.EndUpdate();
            }
        }

        private void btnLeftDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를선택하세요.";
                // 현재텍스트박스에있는경로를초기선택폴더로설정
                if (!string.IsNullOrWhiteSpace(txtLeftDir.Text) &&
                Directory.Exists(txtLeftDir.Text))
                {
                    dlg.SelectedPath = txtLeftDir.Text;
                }
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtLeftDir.Text = dlg.SelectedPath;

                    PopulateListView(lvwLeftDir, txtLeftDir.Text);

                    if (Directory.Exists(txtRightDir.Text))
                        PopulateListView(lvwRightDir, txtRightDir.Text);

                }
            }
        }

        private void btnRightDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를선택하세요.";
                // 현재텍스트박스에있는경로를초기선택폴더로설정
                if (!string.IsNullOrWhiteSpace(txtRightDir.Text) &&
                Directory.Exists(txtRightDir.Text))
                {
                    dlg.SelectedPath = txtRightDir.Text;
                }
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRightDir.Text = dlg.SelectedPath;

                    PopulateListView(lvwRightDir, txtRightDir.Text);

                    if (Directory.Exists(txtLeftDir.Text))
                        PopulateListView(lvwLeftDir, txtLeftDir.Text);

                }
            }
        }

        private void CopyFileWithConfirmation(string srcPath, string destPath)
{
    var srcInfo = new FileInfo(srcPath);

    if (File.Exists(destPath))
    {
        var destInfo = new FileInfo(destPath);

        string msg =
            $"파일이 이미 존재합니다.\n\n" +
            $"[원본]\n{srcInfo.LastWriteTime}\n\n" +
            $"[대상]\n{destInfo.LastWriteTime}\n\n" +
            $"덮어쓰시겠습니까?";

        var result = MessageBox.Show(
            msg,
            "복사 확인",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result != DialogResult.Yes)
            return;
    }

    File.Copy(srcPath, destPath, true);
}

        private void btnCopyFromLeft_Click(object sender, EventArgs e)
        {
            if (lvwLeftDir.SelectedItems.Count == 0)
            {
                MessageBox.Show("파일을 선택하세요.");
                return;
            }

            foreach (ListViewItem item in lvwLeftDir.SelectedItems)
            {
                if (item.SubItems[1].Text == "<DIR>")
                    continue;

                string fileName = item.Text;

                string srcPath = Path.Combine(txtLeftDir.Text, fileName);
                string destPath = Path.Combine(txtRightDir.Text, fileName);

                CopyFileWithConfirmation(srcPath, destPath);
            }

            PopulateListView(lvwLeftDir, txtLeftDir.Text);
            PopulateListView(lvwRightDir, txtRightDir.Text);
        }

        private void btnCopyFromRight_Click(object sender, EventArgs e)
        {
            if (lvwRightDir.SelectedItems.Count == 0)
            {
                MessageBox.Show("파일을 선택하세요.");
                return;
            }

            foreach (ListViewItem item in lvwRightDir.SelectedItems)
            {
                if (item.SubItems[1].Text == "<DIR>")
                    continue;

                string fileName = item.Text;

                string srcPath = Path.Combine(txtRightDir.Text, fileName);
                string destPath = Path.Combine(txtLeftDir.Text, fileName);

                CopyFileWithConfirmation(srcPath, destPath);
            }

            PopulateListView(lvwLeftDir, txtLeftDir.Text);
            PopulateListView(lvwRightDir, txtRightDir.Text);
        }

        private void lvwLeftDir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwRightDir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 왼쪽
            lvwLeftDir.View = View.Details;
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Columns.Clear();
            lvwLeftDir.Columns.Add("이름", 300);
            lvwLeftDir.Columns.Add("크기", 100);
            lvwLeftDir.Columns.Add("수정일", 160);

            // 오른쪽
            lvwRightDir.View = View.Details;
            lvwRightDir.FullRowSelect = true;
            lvwRightDir.GridLines = true;
            lvwRightDir.Columns.Clear();
            lvwRightDir.Columns.Add("이름", 300);
            lvwRightDir.Columns.Add("크기", 100);
            lvwRightDir.Columns.Add("수정일", 160);

            lvwLeftDir.OwnerDraw = true;
            lvwRightDir.OwnerDraw = true;

            lvwLeftDir.DrawItem += lvwLeftDir_DrawItem;
            lvwLeftDir.DrawSubItem += lvwLeftDir_DrawSubItem;
            lvwLeftDir.DrawColumnHeader += lvwLeftDir_DrawColumnHeader;

            lvwRightDir.DrawItem += lvwLeftDir_DrawItem;
            lvwRightDir.DrawSubItem += lvwLeftDir_DrawSubItem;
            lvwRightDir.DrawColumnHeader += lvwLeftDir_DrawColumnHeader;
        }

        private void lvwLeftDir_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawBackground();
        }

        private void lvwLeftDir_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Color textColor = Color.Black;

            if (e.Item.Tag != null)
            {
                string status = e.Item.Tag.ToString();

                if (status == "NEW")
                    textColor = Color.Red;
                else if (status == "OLD")
                    textColor = Color.Gray;
                else if (status == "ONLY")
                    textColor = Color.Purple;
                else if (status == "SAME")
                    textColor = Color.Black;
            }

            TextRenderer.DrawText(
                e.Graphics,
                e.SubItem.Text,
                e.Item.Font,
                e.Bounds,
                textColor);
        }

        private void lvwLeftDir_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvwRightDir_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvwRightDir_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawBackground();
        }

        private void lvwRightDir_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawBackground();
        }
    }
}
