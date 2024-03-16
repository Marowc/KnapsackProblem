using plecakowy1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI
{
    public partial class Form1 : Form
    {

        int number = 0, seed = 0, capacity = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox1.Text);
            seed = Convert.ToInt32(textBox2.Text);
            capacity = Convert.ToInt32(textBox3.Text);
            Problem Problem = new Problem(number, seed);
            textBox5.Text = Problem.ToString();
            string Result = Problem.Solve(capacity).ToString();
            textBox4.Text = Result;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"^[0-9]*$"))
            {
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                textBox3.Select(textBox3.Text.Length, 0);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[0-9]*$"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Select(textBox1.Text.Length, 0);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^[0-9]*$"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Select(textBox2.Text.Length, 0);
            }
        }
    }
}