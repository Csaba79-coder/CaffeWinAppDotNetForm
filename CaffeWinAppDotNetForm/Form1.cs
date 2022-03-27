namespace CaffeWinAppDotNetForm
{
    public partial class Form1 : Form
    {

        Caffee caffee;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            caffee.ExtraSugar();
            textBoxCaffee.Text = caffee.price.ToString();
        }

        private void buttonExtraMilk_Click(object sender, EventArgs e)
        {
            caffee.ExtraMilk();
            textBoxCaffee.Text = caffee.price.ToString();
        }

        private void buttonExtraCream_Click(object sender, EventArgs e)
        {
            caffee.ExtraCream();
            textBoxCaffee.Text = caffee.price.ToString();
        }

        private void buttonCaffee_Click(object sender, EventArgs e)
        {
            caffee = new Caffee();
            textBoxCaffee.Text = caffee.price.ToString();
        }
    }
}