namespace task4
{
    public partial class Form1 : Form
    {
        private const string FilePath = "ankety.txt";
        public Form1()
        {
            InitializeComponent();
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = radioMale.Checked ? "Мужской" : radioFemale.Checked ? "Женский" : "Не указан";

            if (comboDay.SelectedIndex == -1 || comboMonth.SelectedIndex == -1 || comboYear.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите полную дату рождения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string birthDate = $"{comboDay.Text} {comboMonth.Text} {comboYear.Text}";
            string data = $"{txtLastName.Text}, {txtFirstName.Text}, {txtMiddleName.Text}, {gender}, {birthDate}, {txtResidence.Text}, {txtEmail.Text}, {txtPhone.Text}, {txtHighSalary.Text}, {txtLowSalary.Text}";

            File.AppendAllText(FilePath, data + Environment.NewLine);
            MessageBox.Show("Анкета сохранена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtResidence.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtLowSalary.Clear();
            txtHighSalary.Clear();

            radioMale.Checked = false;
            radioFemale.Checked = false;

            comboDay.SelectedIndex = -1;
            comboMonth.SelectedIndex = -1;
            comboYear.SelectedIndex = -1;

            checkCar.Checked = false;
            checkLicenseA.Checked = false;
            checkLicenseB.Checked = false;
            checkLicenseC.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShowSaved_Click_1(object sender, EventArgs e)
        {
            listSavedAnkets.Items.Clear();

            if (File.Exists(FilePath))
            {
                string[] lines = File.ReadAllLines(FilePath);
                foreach (string line in lines)
                {
                    listSavedAnkets.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Файл анкет не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

