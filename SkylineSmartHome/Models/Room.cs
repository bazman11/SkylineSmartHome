using SkylineSmartHome.Interfaces;
using SkylineSmartHome.Models.Devices;
using SkylineSmartHome.Models.Enums;
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

        public Room(Rooms naziv, double temperatura = 22.0)
        {
            _naziv = naziv.ToString(); // iz enuma u string!
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

        public void DodajSijalicu(Sijalica sijalica)
        {
            _sijalice.Add(sijalica);
            Console.WriteLine($"Sijalica {sijalica.GetName()} dodana u sobu {_naziv}.");
        }

        public void DodajUredjaj(IDevice uredjaj)
        {
            _uredjaji.Add(uredjaj);
            Console.WriteLine($"Uređaj {uredjaj.GetName()} dodan u sobu {_naziv}.");
        }

        public void PrikaziStanje()
        {
            Console.WriteLine($"\nSoba: {_naziv}");
            Console.WriteLine($"Temperatura: {_temperatura}°C");

            Console.WriteLine("Sijalice:");
            foreach (var sijalica in _sijalice)
            {
                Console.WriteLine($"  - {sijalica.GetName()} ({sijalica.GetStatusString()})");
            }

            Console.WriteLine("Uređaji:");
            foreach (var uredjaj in _uredjaji)
            {
                Console.WriteLine($"  - {uredjaj.GetName()} ({uredjaj.GetStatusString()})");
            }
        }

    }

}
