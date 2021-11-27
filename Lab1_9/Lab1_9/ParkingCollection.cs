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

        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }
       
        public void DelParking(string name)
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
            using (StreamWriter fs = new StreamWriter(filename))
            {
                fs.Write($"ParkingCollection{Environment.NewLine}", fs);
                foreach (var level in parkingStages)
                {                  
                    fs.Write($"Parking{separator}{level.Key}{Environment.NewLine}", fs);
                    ITransport bus = null;

                    for (int i = 0; (bus = level.Value.GetNext(i)) != null; i++)                        
                    {
                        if (bus != null)
                        {
                            
                            if (bus.GetType().Name == "Bus")

                            {
                                fs.Write($"Bus{separator}", fs);
                            }

                            if (bus.GetType().Name == "DoubleDecker")

                            {
                                fs.Write($"DoubleDecker{separator}", fs);
                            }
                          
                            fs.Write(bus + Environment.NewLine, fs);
                        }
                    }
                }
                return true;
            }            
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            parkingStages.Clear();

            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                String line;
                
                Vehicle bus = null;
                string key = string.Empty;
                line = sr.ReadLine();
                if (!line.Contains("ParkingCollection"))
                {
                    return false;
                }
                while ((line = sr.ReadLine()) != null)
                {
                    
                    if (line.Contains("Parking"))
                    {                       
                        key = line.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                    }
                    else if (line.Split(separator)[0] == "Bus")
                    {
                        bus = new  Bus(line.Split(separator)[1]);
                        var result = parkingStages[key] + bus;
                        if (result < 0)
                        {
                            return false;
                        }
                    }
                    else if (line.Split(separator)[0] == "DoubleDecker")
                    {
                        bus = new DoubleDecker(line.Split(separator)[1]);
                        var result = parkingStages[key] + bus;
                        if (result < 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return true;
        }
    }
}
