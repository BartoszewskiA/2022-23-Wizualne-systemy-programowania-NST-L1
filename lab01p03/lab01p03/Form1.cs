namespace lab01p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int metry = hScrollBar1.Value;
            label1.Text = metry.ToString() + " m";
            double kilometry = metry / 1000.0;
            label2.Text = kilometry.ToString() + " km";
        }
    }
}