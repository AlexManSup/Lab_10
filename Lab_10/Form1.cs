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
            CarcassDraw();
        }

        private void CarcassDraw()
        {
            
            Pen rectPen = new Pen(Color.Black, 3);
            Pen linePen = new Pen(Color.Red);
            GraphicsObj.Clear(Color.White);
            Font t = new Font(label1.Font.FontFamily, 7F);
            GraphicsObj.DrawLine(new Pen(Color.Black), 15, 210, 15, 10);
            GraphicsObj.DrawLine(new Pen(Color.Black), 15, 10, 580, 10);
            for (int i = 1; i < 560 / 40 + 1; i++)
            {
                GraphicsObj.DrawLine(new Pen(Color.Black), i * 40 + 10, 7, i * 40 + 10, 13);
                GraphicsObj.DrawString((i * 40).ToString(), t, new SolidBrush(Color.Black), i * 40 - 12, -2);
            }
            for (int i = 1; i < 200 / 40 + 1; i++)
            {
                GraphicsObj.DrawLine(new Pen(Color.Black), 12, i * 40, 18, i * 40);
                GraphicsObj.DrawString((i * 40).ToString(), t, new SolidBrush(Color.Black), 0, i * 40 - 15);
            }

            var coordBoxes = new[] { LUX, LUY, RDX, RDY, P1X, P2X, P1Y, P2Y, };
            foreach (var item in coordBoxes)
            {
                if (item.Text == "")
                {
                    MessageBox.Show("Не все координаты были введены");
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
                Y = rectLeftP.Y,
                Width = rectRightP.X - rectLeftP.X,
                Height = rectRightP.Y - rectLeftP.Y
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
            if (rectLeftP.X<rectRightP.X && rectLeftP.Y<rectRightP.Y)
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


            var topLeftPoint = new Point(rect.Left, rect.Top);
            int area = -1;

            // 1
            if (topLeftPoint == lineP1 || topLeftPoint == lineP2)
            {
                MessageBox.Show("Линия проходит через верхний левый угол");
                areaLabel.Text = "";
                return;
            } // 2
            else if (lineYMax == rect.Bottom && lineYMin == rect.Top)
            {
                area = (lineXMin - rect.Left) * rect.Height + linesRectHalfArea;
            } // 3
            else if (lineXMin == rect.Left && lineXMax == rect.Right)
            {
                area = (lineYMin - rect.Top) * rect.Width + linesRectHalfArea;
            } // 4
            else if (lineXMax == rect.Right)
            {

                area = rectArea - linesRectHalfArea;
            } // 5
            else if (lineXMin == rect.Left && lineYMin == rect.Top)
            {
                MessageBox.Show("5");
                area = linesRectHalfArea;
            } // 6
            else if (lineXMin == rect.Left && lineYMax == rect.Bottom)
            {
                MessageBox.Show("6");
                area = rectArea - linesRectHalfArea;
            }
            areaLabel.Text = area.ToString();
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {
            Font t = new Font(label1.Font.FontFamily, 7F);
            e.Graphics.DrawLine(new Pen(Color.Black), 15, 210, 15, 10);
            e.Graphics.DrawLine(new Pen(Color.Black), 15, 10, 580, 10);
            for (int i = 1; i < 560 / 40 + 1; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), i * 40 + 10, 7, i * 40 + 10, 13);
                e.Graphics.DrawString((i * 40).ToString(), t, new SolidBrush(Color.Black), i * 40 - 12, -2);
            }
            for (int i = 1; i < 200 / 40 + 1; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), 12, i * 40, 18, i * 40);
                e.Graphics.DrawString((i * 40).ToString(), t, new SolidBrush(Color.Black), 0, i * 40 - 15);
            }
        }
    }
}
