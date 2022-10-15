namespace notepad_simple_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textField.Clear();  
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textField.Text = File.ReadAllText(openFileDialog1.FileName);    
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|PDF File|*.pdf|Word File|*.doc"; 
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName,textField.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textField.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textField.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textField.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textField.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textField.Copy();   
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textField.Paste();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textField.Text = System.DateTime.Now.ToString();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textField.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textField.ForeColor = colorDialog1.Color;
            }
        }
    }
}