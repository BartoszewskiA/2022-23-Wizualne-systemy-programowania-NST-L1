namespace lab03p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus sed facilisis odio. Donec a commodo leo, at elementum nisi. Nunc aliquet et elit nec gravida. Phasellus consequat odio nec nisl fringilla maximus. Aenean sagittis suscipit tellus in consectetur. Donec rhoncus placerat metus, at venenatis mi malesuada nec. Ut nisi diam, mollis eget hendrerit quis, pulvinar quis enim. Mauris scelerisque vitae sapien sed dictum. Sed non ex ac nisi aliquet bibendum in in enim. Pellentesque scelerisque rhoncus gravida. Mauris sed orci vitae magna mattis interdum at a quam. Sed non sapien non sem pellentesque varius. Integer vitae suscipit nisl.";
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK) 
                richTextBox1.Font = fontDialog1.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(colorDialog2.ShowDialog()==DialogResult.OK)
                richTextBox1.BackColor = colorDialog2.Color;
        }
    }
}