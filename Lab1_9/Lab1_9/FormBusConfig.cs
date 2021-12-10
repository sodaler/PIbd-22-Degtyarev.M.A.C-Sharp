using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DegtyarevBus
{
    public partial class FormBusConfig : Form
    {

        ITransport bus = null;

        private Action<Vehicle> eventAddBus;

        public FormBusConfig()
        {
            InitializeComponent();

            panelRed.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;


            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawBus()
        {
            if (bus != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bus.SetPosition(5, 5, pictureBoxBus.Width, pictureBoxBus.Height);
                bus.DrawTransport(gr);
                pictureBoxBus.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddBus == null)
            {
                eventAddBus = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddBus += ev;
            }
        }

        private void labelBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelBus.DoDragDrop(labelBus.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }

        private void panelBus_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelBus_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Автобус":
                    bus = new Bus((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Двухэтажный автобус":
                    bus = new DoubleDecker((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxSecondFloor.Checked, checkBoxHeadLight.Checked);
                    break;
            }
            DrawBus();
        }

        private void labelDoubleDecker_MouseDown(object sender, MouseEventArgs e)
        {
            labelDoubleDecker.DoDragDrop(labelDoubleDecker.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                bus.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBus();
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
            
        {
            if (bus != null)
                (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus.GetType() != typeof(DoubleDecker))
                return;
            Color DopColor = (Color)e.Data.GetData(typeof(Color));
            DoubleDecker catamaran = (DoubleDecker)bus;
            catamaran.SetDopColor(DopColor);
            DrawBus();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            eventAddBus?.Invoke((Vehicle)bus);
            Close();
        }  
    }
}
