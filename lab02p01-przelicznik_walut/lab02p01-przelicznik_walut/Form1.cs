namespace lab02p01_przelicznik_walut
{
    
    public partial class Form1 : Form
    {
        private double kwota = 0; 
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = kwota.ToString();
            opisy();
        }

        double przelicz(double x)
        {
            double wynik = 0;
            double posrednia = 0;
            if (radioButton1.Checked)
                posrednia = x;
            else if (radioButton2.Checked)
                posrednia = x * 4.72;
            else
                posrednia = x * 4.73;

            if (radioButton4.Checked)
                wynik = posrednia;
            else if (radioButton5.Checked)
                wynik = posrednia / 4.72;
            else
                wynik = posrednia / 4.73;
            wynik = Math.Round(wynik, 2);
            return wynik;
        }

        void opisy()
        {
            if (radioButton1.Checked)
                label1.Text = "PLN";
            else if (radioButton2.Checked)
                label1.Text = "EURO";
            else
                label1.Text = "USD";
            if (radioButton4.Checked)
                label2.Text = "PLN";
            else if (radioButton5.Checked)
                label2.Text = "EURO";
            else
                label2.Text = "USD";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            kwota = hScrollBar1.Value;
            textBox1.Text = kwota.ToString();
            textBox2.Text = przelicz(kwota).ToString();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(kwota).ToString();
            opisy();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(kwota).ToString();
            opisy();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(kwota).ToString();
            opisy();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(kwota).ToString();
            opisy();
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(kwota).ToString();
            opisy();
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            textBox2.Text = przelicz(kwota).ToString();
            opisy();
        }
    }
}