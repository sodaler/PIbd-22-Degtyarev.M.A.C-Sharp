using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_9
{
    public partial class BusForm : Form
    {
        private ITransport bus;

        public BusForm()
        {
            InitializeComponent();
        }

        public void Setbus(ITransport bus)
        {
            this.bus = bus;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            bus?.DrawTransport(gr);
            pictureBoxBus.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bus = new Bus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            bus.SetPosition(rnd.Next(30, 200), rnd.Next(30, 200), pictureBoxBus.Width, pictureBoxBus.Height);
            Draw();
        }

        private void buttonCreateDoubleDecker_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bus = new DoubleDecker(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Black, true, true);
            bus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBus.Width, pictureBoxBus.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    bus.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    bus.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    bus.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    bus.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

    }
}
