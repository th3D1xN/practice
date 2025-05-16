namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
             Graphics g = e.Graphics;
        
        // �������� ���� ���������
        using (SolidBrush orangeBrush = new SolidBrush(Color.Orange))
        {
            g.FillEllipse(orangeBrush, 100, 100, 200, 200);
        }

        // ������ ���������
        using (Pen darkOrangePen = new Pen(Color.DarkOrange, 2))
        {
            g.DrawEllipse(darkOrangePen, 100, 100, 200, 200);
        }

        // �������� ��������� (������)
        using (Pen texturePen = new Pen(Color.DarkOrange, 1))
        {
            // ������������ �����
            g.DrawLine(texturePen, 200, 100, 200, 300);
            
            // ������������ ����� �����
            g.DrawLine(texturePen, 200, 200, 130, 130);
            g.DrawLine(texturePen, 200, 200, 130, 270);
            
            // ������������ ����� ������
            g.DrawLine(texturePen, 200, 200, 270, 130);
            g.DrawLine(texturePen, 200, 200, 270, 270);
        }

        // ����
        using (SolidBrush highlightBrush = new SolidBrush(Color.White))
        {
            g.FillEllipse(highlightBrush, 140, 130, 30, 30);
        }

        // ������
        Point[] leafPoints = {
            new Point(190, 90),
            new Point(200, 70),
            new Point(210, 90)
        };
        using (SolidBrush leafBrush = new SolidBrush(Color.ForestGreen))
        {
            g.FillPolygon(leafBrush, leafPoints);
        }
        }
    }
}
