using System.Diagnostics;
using System.Security.Policy;

namespace Desktop_Tool
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
            FilesToList();
            Define.isClose = true;
            Define.isOpen = false;
            Location = new Point(Define.CLOSEVOL_SIZE, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Define.isClose)
            {
                OpenSlowly();
            }
            else if (Define.isOpen)
            {
                CloseSlowly();
            }
        }
        private void CloseSlowly()
        {
            int i = Define.OPENVOL_SIZE;
            while (i < Define.CLOSEVOL_SIZE)
            {
                Thread.Sleep(1);
                i += 20;
                Location = new Point(i, 100);
            }
            StateCtrlBtn.Text = "《";
            Define.isClose = true;
            Define.isOpen = false;
        }
        private void OpenSlowly()
        {
            int i = Define.CLOSEVOL_SIZE;
            while (i > Define.OPENVOL_SIZE)
            {
                Thread.Sleep(1);
                i -= 20;
                Location = new Point(i, 100);
            }
            StateCtrlBtn.Text = "》";
            Define.isOpen = true;
            Define.isClose = false;
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null) return;
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);
            //CreateDirectoryOrFile("临时");

            //托入的文件放入文件夹里
            foreach (string s2 in s)
            {
                if(!Path.HasExtension(s2))
                {
                    return;
                }
                string fileName = Path.GetFileName(s2);
                string dest = "D:\\临时文件\\" + fileName;
                MoveFiles(s2, dest);
            }
            FilesToList();
        }

        /// <summary>
        /// 文件夹映射到listBox中
        /// </summary>
        private void FilesToList()
        {
            //将文件夹里的文件路径放到临时变量里
            string folderPath = "D:\\临时文件\\";
            string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

            //在临时变量里查找文件，将没有的加入到临时变量中
            foreach (string file in files)
            {
                if (!Define.Files.ContainsKey(Path.GetFileName(file)))
                    Define.Files.Add(Path.GetFileName(file), file);
            }
            //在文件中查找临时变量，将没有的删除
            foreach (string file in Define.Files.Values)
            {
                if (!files.Contains(file))
                    Define.Files.Remove(Path.GetFileName(file));
            }

            //绑定数据源
            listBox1.DataSource = Define.Files.Keys.ToList<string>();
            listBox1.Refresh();

        }

        private void MoveFiles(string sourceFileName, string destFileName)
        {
            string path = sourceFileName;
            string path2 = destFileName;
            try
            {
                if (!File.Exists(path))
                {
                    using (FileStream fs = File.Create(path)) { }
                }

                // Ensure that the target does not exist.
                if (File.Exists(path2))
                    File.Delete(path2);

                // Move the file.
                File.Move(path, path2);

                // See if the original exists now.
                if (File.Exists(path))
                {
                    Console.WriteLine("The original file still exists, which is unexpected.");
                }
                else
                {
                    Console.WriteLine("The original file no longer exists, which is expected.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string? file = listBox1.SelectedItems[0].ToString();
                if (file == null) return;
                string Excutefile = Define.Files[file].ToString();

                var psi = new ProcessStartInfo
                {
                    FileName = Excutefile,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (listBox1.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    openFileRode.Visible = true;
                    delete.Visible = true;

                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string? filePath = listBox1.SelectedItems[0].ToString();
                if (filePath == null) return;
                File.Delete(Define.Files[filePath].ToString());
                FilesToList();
            }
        }

        private void openFileRode_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string? FilesPath = null;
                foreach (var items in Define.Files)
                {
                    if (items.Key.Contains(listBox1.SelectedItems[0].ToString()))
                    {
                        FilesPath = items.Value.ToString().Replace(items.Key, "");
                    }
                }
                var psi = new ProcessStartInfo
                {
                    FileName = FilesPath,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }
    }
}