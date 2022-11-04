namespace lab01p02_klikacz
{
    public partial class Form1 : Form
    {
        
        private int licznik =0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = licznik.ToString();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            licznik = 0;
            label1.Text = licznik.ToString();
            koloruj();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            licznik++;
            label1.Text = licznik.ToString();
            koloruj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            licznik--;
            label1.Text = licznik.ToString();
            koloruj();
        }

        private void koloruj()
        {
            if (licznik > 0)
            {
                label1.ForeColor = Color.Green;
            }
            else if (licznik < 0)
            {
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Black;
            }
        }
    }
}