namespace lab03p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jakieú pytanie", "Okno dialogowe", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                label2.Text = "Odpowiedü okna: OK";
            else
                label2.Text = "Odpowiedü okna: CANCEL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
                label3.Text = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
                label4.Text = saveFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                panel1.BackColor = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()== DialogResult.OK)
            {
                label5.Text = fontDialog1.Font.Name.ToString();
                label5.Font = fontDialog1.Font;
            }
        }
    }
}