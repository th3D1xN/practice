namespace zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBoxX.Text);
                double b = Convert.ToDouble(textBoxB.Text);

                double fx = 0;

                if (radioButtonSinh.Checked)
                    fx = Math.Sinh(x);
                else if (radioButtonX2.Checked)
                    fx = x * x;
                else if (radioButtonExp.Checked)
                    fx = Math.Exp(x);
                else
                    throw new Exception("Выберите функцию f(x)");

                double xb = x * b;
                double s;

                if (xb > 1 && xb < 10)
                {
                    s = Math.Exp(fx);
                }
                else if (xb > 12 && xb < 40)
                {
                    s = Math.Sqrt(Math.Abs(fx + 4 * b));
                }
                else
                {
                    s = b * fx * fx;
                }

                textBoxResult.Text = s.ToString("F6");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

    }
}
