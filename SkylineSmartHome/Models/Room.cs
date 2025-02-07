using SkylineSmartHome.Interfaces;
using SkylineSmartHome.Models.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylineSmartHome.Models
{
    public class Room
    {
        private string _naziv;
        private double _temperatura;
        private List<Sijalica> _sijalice;
        private List<IDevice> _uredjaji;

        public Room(Room naziv, double temperatura = 22.0)
        {
            _naziv = naziv.ToString();
            _temperatura = temperatura;
            _sijalice = new List<Sijalica>();
            _uredjaji = new List<IDevice>();
        }

        public string GetNaziv() => _naziv;
        public double GetTemperatura() => _temperatura;

        public void SetTemperatura(double temperatura)
        {
            _temperatura = temperatura;
            Console.WriteLine($"Temperatura u sobi {_naziv} postavljena na {_temperatura}°C.");
        }

    }

}
