using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1_9
{
    public class Bus
    {
        private float _startPosX;

        private float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;

        private readonly int busWidth = 125;

        private readonly int busHeight = 90;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool HeadLight { private set; get; }

        public bool SecondFloor { private set; get; }


        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool headLight, bool secondFloor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            HeadLight = headLight;
            SecondFloor = secondFloor;

        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureHeight = height;
            _pictureWidth = width;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - busWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - busHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(DopColor);
            pen.Width = 3.0F;

            //второй этаж
            if (SecondFloor)
            {
                g.DrawRectangle(pen, _startPosX, _startPosY, 130, 40);
                g.DrawEllipse(pen, _startPosX + 10, _startPosY + 7, 15, 20);
                g.DrawEllipse(pen, _startPosX + 35, _startPosY + 7, 15, 20);
                g.DrawEllipse(pen, _startPosX + 60, _startPosY + 7, 15, 20);
                g.DrawEllipse(pen, _startPosX + 85, _startPosY + 7, 15, 20);
                g.DrawEllipse(pen, _startPosX + 110, _startPosY + 7, 15, 20);
            }

            //фара
            if (HeadLight)
            {
                g.FillRectangle(brush, _startPosX - 6, _startPosY + 55, 5, 13);
            }

            //Кузов
            Brush br = new SolidBrush(MainColor);
            Pen p = new Pen(MainColor);
            p.Width = 3.0F;
            g.FillEllipse(br, _startPosX + 10, _startPosY + 75, 15, 15);
            g.DrawRectangle(p, _startPosX, _startPosY + 40, 130, 40);
            g.FillEllipse(br, _startPosX + 100, _startPosY + 75, 15, 15);
            g.DrawRectangle(p, _startPosX + 50, _startPosY + 50, 15, 30);
            g.DrawEllipse(p, _startPosX + 10, _startPosY + 45, 15, 20);
            g.DrawEllipse(p, _startPosX + 30, _startPosY + 45, 15, 20);
            g.DrawEllipse(p, _startPosX + 70, _startPosY + 45, 15, 20);
            g.DrawEllipse(p, _startPosX + 90, _startPosY + 45, 15, 20);
            g.DrawEllipse(p, _startPosX + 110, _startPosY + 45, 15, 20);

        }
    }
}
