namespace zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Рисование фигур";
            this.ClientSize = new Size(1200, 1000);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.BackColor = Color.White;
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawOriginalShapes(g);

            DrawConcentricCircles(g, 900, 200, 180, 3);

            DrawVerticalRectangles(g, 850, 700, 80, 50, 5);

            DrawChessBoard(g, 100, 700, 200, 8);
        }

        private void DrawOriginalShapes(Graphics g)
        {
            Point[] trianglePoints = {
                new Point(100, 100),
                new Point(250, 250),
                new Point(0, 250)
            };
            g.DrawPolygon(new Pen(Color.Blue, 3), trianglePoints);

            Rectangle ellipseRect = new Rectangle(350, 100, 250, 150);
            g.DrawEllipse(new Pen(Color.Green, 3), ellipseRect);

            Rectangle circleRect = new Rectangle(100, 400, 200, 200);
            g.FillEllipse(Brushes.Red, circleRect);

            Rectangle rect = new Rectangle(450, 400, 220, 150);
            g.FillRectangle(Brushes.Orange, rect);

            Rectangle pieRect = new Rectangle(350, 650, 250, 250);
            g.FillPie(Brushes.Purple, pieRect, 30, 120);
        }

        private void DrawConcentricCircles(Graphics g, int centerX, int centerY, int outerRadius, int count)
        {
            int currentRadius = outerRadius;
            Color[] colors = { Color.Red, Color.Blue, Color.Green };

            for (int i = 0; i < count; i++)
            {
                int diameter = currentRadius * 2;
                Rectangle rect = new Rectangle(
                    centerX - currentRadius,
                    centerY - currentRadius,
                    diameter,
                    diameter);

                g.DrawEllipse(new Pen(colors[i % colors.Length], 3), rect);
                currentRadius -= outerRadius / count;
            }
        }

        private void DrawVerticalRectangles(Graphics g, int startX, int startY, int width, int height, int count)
        {
            for (int i = 0; i < count; i++)
            {
                // Смещение каждого следующего прямоугольника
                int x = startX + (i * width / 2);
                int y = startY + (i * height / 4);

                // Вертикальный прямоугольник
                Rectangle rect = new Rectangle(x, y, width, height);

                // Чередование цветов
                Color color = i % 2 == 0 ? Color.DarkBlue : Color.LightBlue;

                // Рисование
                g.FillRectangle(new SolidBrush(color), rect);
                g.DrawRectangle(Pens.Black, rect);

                // Точка соединения (для наглядности)
                g.FillEllipse(Brushes.Red, x + width - 2, y + height - 2, 4, 4);
            }
        }

        private void DrawChessBoard(Graphics g, int startX, int startY, int boardSize, int cells)
        {
            int cellSize = boardSize / cells;

            for (int row = 0; row < cells; row++)
            {
                for (int col = 0; col < cells; col++)
                {
                    Rectangle rect = new Rectangle(
                        startX + col * cellSize,
                        startY + row * cellSize,
                        cellSize,
                        cellSize);

                    Color color = (row + col) % 2 == 0 ? Color.Black : Color.White;
                    g.FillRectangle(new SolidBrush(color), rect);
                    g.DrawRectangle(Pens.Gray, rect);
                }
            }
        }
    }
}
