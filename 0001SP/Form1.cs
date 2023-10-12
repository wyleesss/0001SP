using System.Diagnostics;

namespace _0001SP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (notepadProcess is null)
                notepadProcess = Process.Start("notepad.exe");
            
            else
                MessageBox.Show("The process has\nalready started", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            notepadProcess.Kill();
            notepadProcess = null;
        }
    }
}