namespace lab01p04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            koloruj();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            koloruj();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            koloruj();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            koloruj();
        }

        private void koloruj()
        {
            if (radioButton1.Checked == true)
            {
                panel1.BackColor = Color.Red;
            }
            else if (radioButton2.Checked == true)
            {
                panel1.BackColor = Color.Green;
            }
            else
            {
                panel1.BackColor = Color.Blue;
            }
        }
    }
}