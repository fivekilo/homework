namespace WinFormsCompute
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            string c=comboBox1.Text;
            double d1 = double.Parse(s1);
            double d2 = double.Parse(s2);
            double result=0;
            bool b = true;
            switch (c)
            {
                case "+":
                    result=(d1 + d2);
                    break;
                case "-":
                    result=(d1 - d2);
                    break;
                case "*":
                    result = (d1 * d2);
                    break;
                case "/":
                    if (d2 == 0)
                    {
                        Console.WriteLine("除数不可为0");
                        b= false;
                        break;
                    }
                    else
                    {
                        result = (d1 / d2);
                        break;
                    }
            }
            if (b)
            {
                textBox3.Text = result.ToString();
            }
            else
            {
                textBox3.Text = "除数不可为0";
            }
        }
    }
}