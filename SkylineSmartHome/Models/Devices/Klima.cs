using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylineSmartHome.Models.Devices
{
    public class Klima : Device
    {
        private int _temperatura;

        public Klima(string name) : base(name)
        {
            _temperatura = 22;
        }

        public int GetTemperaturu() => _temperatura;

        public void PovecajTemperaturu()
        {
            _temperatura++;
            Console.WriteLine($"{GetName()} temperatura je sada: {_temperatura}°C.");
        }

        public void SmanjiTemperaturu()
        {
            _temperatura--;
            Console.WriteLine($"{GetName()} temperatura je sada: {_temperatura}°C.");
        }

        public override string GetStatusString()
        {
            return $"{GetName()} je {(GetStatus() ? "UKLJUČEN" : "ISKLJUČEN")} | Temperatura: {_temperatura}°C";
        }
    }
}
