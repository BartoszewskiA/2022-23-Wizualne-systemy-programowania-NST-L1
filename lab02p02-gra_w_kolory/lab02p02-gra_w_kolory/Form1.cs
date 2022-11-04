namespace lab02p02_gra_w_kolory
{
    public partial class Form1 : Form
    {
        Random random;
        int wynik = 0;
        int los;
        string[] kolory = new string[] { "Czerwony", "Zielony", "Niebieski", "ó³ty" };
        Color[] pedzel = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            losuj();
        }

        void losuj()
        {
           los = random.Next(0, kolory.Length);
           label2.Text = kolory[los];
            label2.ForeColor = pedzel[random.Next(0, pedzel.Length)];
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (los == 0) 
                wynik++;
            else
                wynik--;
            label1.Text = wynik.ToString();
            losuj();
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {

            if (los == 1)
                wynik++;
            else
                wynik--; 
            label1.Text= wynik.ToString();
            losuj();
        }

        private void panel3_DoubleClick(object sender, EventArgs e)
        {
            if (los == 2)
                wynik++;
            else
                wynik--;
            label1.Text = wynik.ToString();
            losuj();
        }

        private void panel4_DoubleClick(object sender, EventArgs e)
        {
            if (los == 3)
                wynik++;
            else
                wynik--;
            label1.Text = wynik.ToString();
            losuj();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value = progressBar1.Value - 1;
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("twój wynik: " + wynik.ToString(), "Wynik", MessageBoxButtons.OK);
                
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            losuj();
        }
    }
}