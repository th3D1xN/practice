using System;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private int[] numbers = new int[10]; // �������� �� 10 ���������
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++) // �������� �� 10 ���������
            {
                numbers[i] = random.Next(-100, 101);
                listBox1.Items.Add(numbers[i]);
            }
            labelResult.Text = "";
        }

        private void ButtonSwap_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("������� ��������� ������!");
                return;
            }

            // ����� ������������ ��������
            int minIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[minIndex])
                    minIndex = i;
            }

            // ����� � ��������� ���������
            int temp = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = numbers[minIndex];
            numbers[minIndex] = temp;

            // ���������� ListBox
            listBox1.Items.Clear();
            foreach (int number in numbers)
            {
                listBox1.Items.Add(number);
            }

            labelResult.Text = $"����������� ������� {numbers[numbers.Length - 1]} ��������� � �����";
        }
    }
}

