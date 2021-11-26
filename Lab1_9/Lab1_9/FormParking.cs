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
    public partial class FormParking : Form
    {
        private readonly ParkingCollection parkingCollection;

        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width,
            pictureBoxParking.Height);
        }

        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >=
            listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index <
            listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
            else if (listBoxParkings.Items.Count == 0)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                pictureBoxParking.Image = bmp;
            }
        }


        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        private void buttonDelParking_Click(object sender, EventArgs e)
        {
           
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить построение { listBoxParkings.SelectedItem.ToString()}?",
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void buttonSetBus_Click(object sender, EventArgs e)
        {        
            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var bus = new Bus(100, 1000, dialog.Color);
                    if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + bus >= 0)
                    { 
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Построение заполнено");
                    }
                }
            }
        }

        private void buttonSetDoubleDecker_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dopDialog = new ColorDialog();
                    if (dopDialog.ShowDialog() == DialogResult.OK)
                    {
                        var doubleDecker = new DoubleDecker(100, 1000, dialog.Color, dopDialog.Color, true, true);
                        if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + doubleDecker >= 0)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Построение заполнено");
                        }
                    }
                }
            }
        }

        private void buttonTakeBus_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "" && listBoxParkings.SelectedIndex > -1)
            {
                var bus = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (bus != null)
                {
                    BusForm form = new BusForm();
                    form.Setbus(bus);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
