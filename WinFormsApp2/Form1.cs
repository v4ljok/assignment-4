namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int factorial = 1;
            if (number < 0)
            {
                MessageBox.Show("The factorial can't be negative");
                return;
            }

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            MessageBox.Show("The factorial of " + number + " is " + factorial);
        }
    }
}