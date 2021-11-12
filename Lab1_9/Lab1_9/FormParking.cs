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
    public partial class FormParking : Form
    {
        private readonly Parking<Bus> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Bus>(pictureBoxParking.Width,
            pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonSetBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var bus = new Bus(100, 1000, dialog.Color);
            
            if ((parking + bus) != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonSetDoubleDecker_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var bus = new DoubleDecker(100, 1000, dialog.Color, dialogDop.Color,
                    true, true);
                    if ((parking + bus) != -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }


        private void buttonTakeBus_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var bus = parking - Convert.ToInt32(maskedTextBox.Text);
                if (bus != null)
                {
                    BusForm form = new BusForm();
                    form.Setbus(bus);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
