using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DegtyarevBus
{
    public class Bus : Vehicle
    {
        protected readonly int busWidth = 140;
       
        protected readonly int busHeight = 90;

        protected readonly char separator = ';';

        public Bus(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        
        protected Bus(int maxSpeed, float weight, Color mainColor, int busWidth,
        int busHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.busWidth = busWidth;
            this.busHeight = busHeight;
        }

        public Bus(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {

                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - busWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - busHeight)
                    {
                        _startPosY += step;
                    }
                    break;

            }
        }
        public override void DrawTransport(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);
            Pen p = new Pen(MainColor);
            p.Width = 3.0F;
            g.DrawRectangle(p, _startPosX, _startPosY + 40, 130, 40);
            g.DrawRectangle(p, _startPosX + 50, _startPosY + 50, 15, 30);
            g.FillEllipse(br, _startPosX + 10, _startPosY + 75, 15, 15);
            g.FillEllipse(br, _startPosX + 100, _startPosY + 75, 15, 15);
            g.DrawEllipse(p, _startPosX + 10, _startPosY + 50, 15, 20);
            g.DrawEllipse(p, _startPosX + 30, _startPosY + 50, 15, 20);
            g.DrawEllipse(p, _startPosX + 70, _startPosY + 50, 15, 20);
            g.DrawEllipse(p, _startPosX + 90, _startPosY + 50, 15, 20);
            g.DrawEllipse(p, _startPosX + 110, _startPosY + 50, 15, 20);
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}
