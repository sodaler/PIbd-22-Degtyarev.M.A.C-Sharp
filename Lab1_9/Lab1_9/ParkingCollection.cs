using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegtyarevBus
{
    class ParkingCollection
    {
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
       
        public List<string> Keys => parkingStages.Keys.ToList();
       
        private readonly int pictureWidth;
        
        private readonly int pictureHeight;

        private readonly char separator = ':';
        
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddBusStation(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelBusStation(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"BusStationCollection");
                foreach (KeyValuePair<string, Parking<Vehicle>> level in parkingStages)
                {
                    sw.WriteLine($"BusStation{separator}{level.Key}");
                    ITransport bus = null;
                    for (int i = 0; (bus = level.Value.GetNext(i)) != null; i++)
                    {
                        if (bus != null)
                        {
                            if (bus.GetType().Name == "Bus")
                            {
                                sw.Write($"Bus{separator}");
                            }
                            if (bus.GetType().Name == "DoubleDecker")
                            {
                                sw.Write($"DoubleDecker{separator}");
                            }
                            sw.WriteLine(bus);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Не найдено");
            }
            string bufferTextFromFile = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("BusStationCollection"))
                {
                    parkingStages.Clear();
                }

                else
                {
                    throw new FileFormatException("Формат файла неверный");
                }

                Vehicle bus = null;
                string key = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("BusStation"))
                    {
                        key = line.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(separator)[0] == "Bus")
                    {
                        bus = new Bus(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "DoubleDecker")
                    {
                        bus = new DoubleDecker(line.Split(separator)[1]);
                    }
                    int result = parkingStages[key] + bus;
                    if (result == -1)
                    {
                        throw new TypeLoadException("Не удалось загрузить автобус на стоянку");
                    }
                }
                return true;
            }
        }
    }
}
