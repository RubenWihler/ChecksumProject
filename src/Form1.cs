using System.Security.Cryptography;

namespace ChecksumProject
{
    public partial class Form1 : Form
    {
        private string _file_path;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public string FilePath
        {
            get { return _file_path; }
            set
            {
                _file_path = value;
                tbox_path.Text = value;

                if (!File.Exists(value) && !Directory.Exists(value))
                {
                    btn_calculate.Enabled = false;
                    tbox_path.ForeColor = Color.Red;
                    return;
                }

                tbox_path.ForeColor = Color.Black;
                btn_calculate.Enabled = true;
            }
        }

        private void Init()
        {
            tbox_path.TextChanged += OnPathChanged;
            btn_search_file.Click += OnSearchFile;
            btn_calculate.Click += Calculate;

            FilePath = string.Empty;
        }

        private void Calculate(object? sender, EventArgs e)
        {
            tbox_checksum.Text = Sha256Of(FilePath);
        }

        private void OnPathChanged(object? sender, EventArgs e)
        {
            if (tbox_path.Text != FilePath) FilePath = tbox_path.Text;
        }

        private void OnSearchFile(object? sender, EventArgs e)
        {
            var file_dialogue = new OpenFileDialog();

            var result = file_dialogue.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                FilePath = file_dialogue.FileName;
            }
        }

        private string Sha256Of(string path)
        {
            using (var sha = SHA256.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    var hash = sha.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}