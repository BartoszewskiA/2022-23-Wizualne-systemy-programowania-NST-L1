namespace lab01p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            //x = int.Parse(textBox1.Text);
            if (int.TryParse(textBox1.Text, out x)) { }
            else {
                x = 0;
                textBox1.Text = 0.ToString();
            }
            if (int.TryParse(textBox2.Text, out y)) { }
            else
            {
                y = 0;
                textBox2.Text = 0.ToString();
            }
            string s = "";
            // --- dodawanie -----
            s += x.ToString();
            if (y >= 0) {s += "+";}
            s+=y.ToString();
            s += "=";
            s+=(x+y).ToString();
            label3.Text=s;
            // --- odejmowanie -----
            s = x.ToString();
            if (y >= 0) 
            { 
                s += "-";
                s += y.ToString();
            }
            else
            {
                s+="+";
                s += (-y).ToString();
            }
            
            s += "=";
            s += (x - y).ToString();
            label4.Text = s;
            // --- mnozenie -----
            s = x.ToString();
            if (y >= 0) { s += "*"; }
            else
            {
                s += "* ";
            }
            s += y.ToString();
            s += "=";
            s += (x * y).ToString();
            label5.Text = s;
            // --- dzielenie -----
            s = x.ToString();
            if (y >= 0) { s += "/"; }
            else
            {
                s += "/ ";
            }
            s += y.ToString();
            s += "=";
            s += Math.Round((double)x / y,3).ToString();
            label6.Text = s;
        }
    }
}