namespace Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) - int.Parse(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) * int.Parse(textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) / int.Parse(textBox2.Text));
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-numeric input
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-numeric input
            }
        }
    }
}
