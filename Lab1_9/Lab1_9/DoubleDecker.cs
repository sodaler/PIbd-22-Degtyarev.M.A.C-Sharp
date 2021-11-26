using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DegtyarevBus
{
    public class DoubleDecker : Bus
    {
        
        public Color DopColor { private set; get; }

        public bool HeadLight { private set; get; }

        public bool SecondFloor { private set; get; }

        public DoubleDecker(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool headLight, bool secondFloor) :
            base(maxSpeed, weight, mainColor, 125, 90)
        {
            DopColor = dopColor;
            HeadLight = headLight;
            SecondFloor = secondFloor;
        }

        public override void DrawTransport(Graphics g)
        {
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(DopColor);
            pen.Width = 3.0F;

            base.DrawTransport(g);

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

        }
    }
}
