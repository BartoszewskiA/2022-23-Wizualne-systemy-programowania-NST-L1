namespace lab03p03_pliki_tekstowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
            }
        }

        private void otwórzToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode .Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                List<string> tekst = new List<string>();
                while(!sr.EndOfStream)
                {
                    tekst.Add(sr.ReadLine());
                }
                richTextBox1.Lines = tekst.ToArray();
                sr.Close();
            }
        }

        private void zapiszToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream (saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter (fs);
                List<string> tekst = new List<string>(richTextBox1.Lines);
                for (int i = 0; i < tekst.Count; i++)
                {
                    sw.WriteLine(tekst[i]);
                }
                sw.Close();
            }
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> tekst = new List<string>();
            for(int i=0; i< richTextBox1.Lines.Length; i++)
            {
                if(richTextBox1.Lines[i].Length > 0)
                    tekst.Add(richTextBox1.Lines[i]);
            }
            richTextBox1.Lines = tekst.ToArray();
        }

        private void edytuj2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List <string> tekst = new List<string>(richTextBox1.Lines);
            for(int i=0; i< tekst.Count; i++)
            {
                tekst[i] = (i + 1).ToString() + ": " + tekst[i];
            }
            richTextBox1.Lines = tekst.ToArray();
        }
    }
}