namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �������� ����������
            if (!int.TryParse(textBoxX.Text, out int x) || !int.TryParse(textBoxY.Text, out int y))
            {
                MessageBox.Show("������� ���������� ����������!");
                return;
            }

            // �������� ����� � ������� ��������������� �������
            string letter = textBoxLetter.Text.ToUpper();
            Control newControl = null;

            switch (letter)
            {
                case "�":
                    Button newButton = new Button();
                    newButton.Text = "����� ������";
                    newButton.Size = new Size(100, 30);
                    newButton.BackColor = Color.LightBlue;
                    newControl = newButton;
                    break;

                case "�":
                    TextBox newTextBox = new TextBox();
                    newTextBox.Text = "����� ����";
                    newTextBox.Size = new Size(100, 20);
                    newTextBox.BackColor = Color.LightGreen;
                    newControl = newTextBox;
                    break;

                case "�":
                    Label newLabel = new Label();
                    newLabel.Text = "����� �����";
                    newLabel.AutoSize = true;
                    newLabel.BackColor = Color.LightPink;
                    newControl = newLabel;
                    break;

                default:
                    MessageBox.Show("������� �, � ��� �!");
                    return;
            }

            if (newControl != null)
            {
                newControl.Location = new Point(x, y);
                newControl.MouseEnter += (s, ev) => Controls.Remove(s as Control);
                Controls.Add(newControl);
            }
        }
    }
}
