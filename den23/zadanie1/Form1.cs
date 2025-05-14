namespace zadanie1
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
                double y = Convert.ToDouble(textBoxY.Text);
                double z = Convert.ToDouble(textBoxZ.Text);

                double numerator = Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), x + y);
                double denominator = Math.Atan(x) + Math.Atan(z);
                double part1 = numerator / denominator;

                double part2 = Math.Pow(Math.Pow(x, 6) + Math.Pow(Math.Log(y), 2), 1.0 / 3.0);

                double phi = part1 + part2;

                textBoxResult.Text = phi.ToString("F6");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }


    }
}
