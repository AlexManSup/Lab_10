using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        Graphics GraphicsObj;
        public Form1()
        {
            InitializeComponent();
            GraphicsObj = image.CreateGraphics();
        }

        private void PlayB_Click(object sender, EventArgs e)
        {
            axisDraw();
            CarcassDraw();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int l = ((MaskedTextBox)sender).Text.Length;
            if (l!=0)
            {
                char FirstLetter = ((MaskedTextBox)sender).Text[0];
                if (FirstLetter == '-')
                {
                    if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)))
                        e.Handled = true;
                }
                else
                {
                    if (!(e.KeyChar == '-' || char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)))
                        e.Handled = true;
                }
            }
        }
        private void axisDraw()
        {
            Pen Lines = new Pen(Color.Black);
            GraphicsObj.Clear(Color.White);
            Font t = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style);
            Brush text = new SolidBrush(Color.Black);
            GraphicsObj.Transform = new System.Drawing.Drawing2D.Matrix(1, 0, 0, 1, 0, 0);
            GraphicsObj.DrawLine(Lines, 300, 0, 300, 600);
            GraphicsObj.DrawLine(Lines, 0, 300, 600, 300);
            for (int i = 1; i < 600 / 50; i++)
            {
                GraphicsObj.DrawLine(Lines, i * 50, 302, i * 50, 298);
                GraphicsObj.DrawLine(Lines, 302, i * 50, 298, i * 50);
                if (i != 6)
                {
                    GraphicsObj.DrawString(Convert.ToString(i * 50 - 300), t, text, i * 50, 310);
                    GraphicsObj.DrawString(Convert.ToString(-i * 50 + 300), t, text, 270, i * 50);
                }
            }
            GraphicsObj.Transform = new System.Drawing.Drawing2D.Matrix(1, 0, 0, -1, 300, 300);
        }
        private void CarcassDraw()
        {
            
            Pen rectPen = new Pen(Color.Black);
            Pen linePen = new Pen(Color.Red);
            var coordBoxes = new[] { LUX, LUY, RDX, RDY, P1X, P2X, P1Y, P2Y, };
            foreach (var item in coordBoxes)
            {
                if (item.Text == "")
                {
                    MessageBox.Show("Не все координаты были введены");
                    areaLabel.Text = "";
                    return;
                }
                int coord = Convert.ToInt32(item.Text);
                if (coord > 200 || coord < -200)
                {
                    MessageBox.Show("Одна из координа выходит за предел допустимых значений (-200<X<200)");
                    areaLabel.Text = "";
                    return;
                }
            }

            Point rectLeftP = new Point(Convert.ToInt32(LUX.Text), Convert.ToInt32(LUY.Text));
            Point rectRightP = new Point(Convert.ToInt32(RDX.Text), Convert.ToInt32(RDY.Text));
            Point lineP1 = new Point(Convert.ToInt32(P1X.Text), Convert.ToInt32(P1Y.Text));
            Point lineP2 = new Point(Convert.ToInt32(P2X.Text), Convert.ToInt32(P2Y.Text));

            Rectangle rect = new Rectangle
            {
                X = rectLeftP.X,
                Y = rectRightP.Y,
                Width = rectRightP.X - rectLeftP.X,
                Height = rectLeftP.Y - rectRightP.Y
            };
            var rectArea = rect.Width * rect.Height;
            var rectXCoords = new[] { rect.Left, rect.Right };
            var rectYCoords = new[] { rect.Top, rect.Bottom };
            bool InRange(int value, int min, int max)
            {
                if (min > max)
                {
                    //throw new Exception();
                }
                if (value >= min && value <= max)
                {
                    return true;
                }
                return false;
            }
            if (rectLeftP.X < rectRightP.X && rectLeftP.Y > rectRightP.Y)
            {
                if (!(
                    (rectXCoords.Contains(lineP1.X) && InRange(lineP1.Y, rect.Top, rect.Bottom) ||
                    rectYCoords.Contains(lineP1.Y) && InRange(lineP1.X, rect.Left, rect.Right))
                    &&
                    (rectXCoords.Contains(lineP2.X) && InRange(lineP2.Y, rect.Top, rect.Bottom) ||
                    rectYCoords.Contains(lineP2.Y) && InRange(lineP2.X, rect.Left, rect.Right))
                                                                                                ))
                {
                    MessageBox.Show("Точки должны быть на периметре прямоугольника");
                    areaLabel.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Координаты прямоугольника введены некорректно");
                areaLabel.Text = "";
                return;
            }

            if ((lineP1.Y == rect.Top) && (lineP2.Y == rect.Top) ||
                (lineP1.Y == rect.Bottom) && (lineP2.Y == rect.Bottom) ||
                (lineP1.X == rect.Right) && (lineP2.X == rect.Right) ||
                (lineP1.X == rect.Left) && (lineP2.X == rect.Left))
            {
                MessageBox.Show("Точки не могут быть на одном ребре");
                areaLabel.Text = "";
                return;
            }
            GraphicsObj.DrawLine(linePen, lineP1, lineP2);
            GraphicsObj.DrawRectangle(rectPen, rect);
            var lineXMin = Math.Min(lineP1.X, lineP2.X);
            var lineXMax = Math.Max(lineP1.X, lineP2.X);
            var lineYMin = Math.Min(lineP1.Y, lineP2.Y);
            var lineYMax = Math.Max(lineP1.Y, lineP2.Y);
            var lineRectW = lineXMax - lineXMin;
            var lineRectH = lineYMax - lineYMin;
            var linesRectHalfArea = lineRectW * lineRectH / 2;


            var topRightPoint = new Point(rect.Right, rect.Bottom);
            int area = -1;
            label3.Visible = false;
            // 1
            if (topRightPoint == lineP1 || topRightPoint == lineP2)
            {
                area = rect.Height * rect.Width;
                label3.Visible = true;
                label3.Text = $"Линия проходит через правый \nверхний угол, следовательно берется \n" +
                    $"полная площадь прямоугольника\n" +
                    $"Площадь первой фигуры= {rectArea - linesRectHalfArea}\n" +
                    $"Площадь второй фигуры= {Math.Abs(area- rectArea - linesRectHalfArea)}";
            } // 2
            else if (lineYMax == rect.Bottom && lineYMin == rect.Top)
            {
                area = Math.Abs((lineXMin - rect.Right) * rect.Height) + linesRectHalfArea;
            } // 3
            else if (lineXMin == rect.Left && lineXMax == rect.Right)
            {
                area = (lineYMin - rect.Top) * rect.Width + linesRectHalfArea;
            } // 4
            else if (lineXMin == rect.Left)
            {
                area = rectArea - linesRectHalfArea;
            } // 5
            else if (lineXMax == rect.Right && lineYMin == rect.Top)
            {
                area = rectArea - linesRectHalfArea;
                
            } // 6
            else if (lineXMax == rect.Right && lineYMax == rect.Bottom)
            {
                area = linesRectHalfArea;
            }
            areaLabel.Text = area.ToString();
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            Brush text = new SolidBrush(Color.Black);
            Font f = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style);
            e.Graphics.DrawLine(pen, 300, 0, 300, 600);
            e.Graphics.DrawLine(pen, 0, 300, 600, 300);
            for (int i = 1; i < 600 / 50; i++)
            {
                e.Graphics.DrawLine(pen, i * 50, 302, i * 50, 298); 
                e.Graphics.DrawLine(pen, 302, i * 50, 298, i * 50);
                if (i != 6)
                {
                    e.Graphics.DrawString(Convert.ToString(i * 50 - 300), f, text, i * 50, 310);
                    e.Graphics.DrawString(Convert.ToString(-i * 50 + 300), f, text, 270, i * 50);
                }
            }
            e.Graphics.Transform = new System.Drawing.Drawing2D.Matrix(1, 0, 0, 1, 300, 300);
        }
    }
}
