namespace laba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != '\b' && number != ',')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            Schet schet = new Schet();

            result = schet.GetSize(sizeBox.Text, comboBox1.Text);

            if (result[0] == 'U')
            {
                label6.Text = "";
                label4.Text = result;
            }
            else
            {
                label4.Text = "";
                label6.Text = result;
            }
        }

        private void sizeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&&e.KeyChar!=',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
