using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegtyarevBus
{
    class Parking<T> : IEnumerator<T>, IEnumerable<T>
         where T : class, ITransport
    {
        private readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int pictureWidth;
       
        private readonly int pictureHeight;
       
        private readonly int _placeSizeWidth = 210;
       
        private readonly int _placeSizeHeight = 120;

        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;     
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _maxCount = width * height;
            _currentIndex = -1;
        }


        public static int operator +(Parking<T> p, T bus)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new BusStationOverflowException();
            }
            if (p._places.Contains(bus))
            {
                throw new BusStationAlreadyHaveException();
            }
            p._places.Add(bus);
            return p._places.Count - 1;
        }

        public static T operator -(Parking<T> p, int i)
        {
            if (i < -1 || i > p._places.Count)
            {
                throw new BusStationNotFoundException(i);
            }
            T bus = p._places[i];
            p._places.RemoveAt(i);
            return bus;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
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

        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }

        public void Sort() => _places.Sort((IComparer<T>)new BusComparer());


        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _places.Count;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
       
    }
}
