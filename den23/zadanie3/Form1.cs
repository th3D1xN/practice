namespace zadanie3
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
                double x0 = Convert.ToDouble(textBoxX0.Text);
                double xk = Convert.ToDouble(textBoxXk.Text);
                double dx = Convert.ToDouble(textBoxDx.Text);
                double b = Convert.ToDouble(textBoxB.Text);

                listBoxResult.Items.Clear();

                for (double x = x0; x <= xk; x += dx)
                {
                    double underRoot = x * x * x + Math.Pow(b, 3);

                    if (underRoot < 0)
                    {
                        listBoxResult.Items.Add($"x = {x:F2} -> Ошибка: подкоренное < 0");
                        continue;
                    }

                    double y = 9 * (x + 15 * Math.Sqrt(underRoot));
                    listBoxResult.Items.Add($"x = {x:F2}; y = {y:F4}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
