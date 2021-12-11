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

        public DoubleDecker(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                HeadLight = Convert.ToBoolean(strs[4]);
                SecondFloor = Convert.ToBoolean(strs[5]);
            }
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


        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
                
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{SecondFloor}{separator}{HeadLight}";

        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(DoubleDecker other)
        {
            var res = (this as Bus).Equals(other as Bus);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (HeadLight != other.HeadLight)
            {
                return false;
            }
            if (SecondFloor != other.SecondFloor)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is DoubleDecker carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
    }
}
