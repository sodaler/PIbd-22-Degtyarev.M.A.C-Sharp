using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_9
{
    class Parking<T> where T : class, ITransport
    {
        private readonly T[] _places;

        private readonly int pictureWidth;
       
        private readonly int pictureHeight;
       
        private readonly int _placeSizeWidth = 210;
       
        private readonly int _placeSizeHeight = 120;
       
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;     
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new T[width * height];
        }
 
        public static int operator +(Parking<T> p, T bus)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {                  
                    p._places[i] = bus;
                    return i;
                }
            }
            return -1;         
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index >= 0 && index <= p._places.Length && p._places[index] != null)
            {
                T bus = p._places[index];
                p._places[index] = null;
                return bus;
            }
            return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; ++i)
            {
                _places[i]?.SetPosition(15 + i % 5 * _placeSizeWidth, i / 5 * _placeSizeHeight + 25, pictureWidth, pictureHeight);
                _places[i]?.DrawTransport(g);
            }
        }
       
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                    _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
                (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

    }
}
