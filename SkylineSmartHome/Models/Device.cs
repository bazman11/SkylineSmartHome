using SkylineSmartHome.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylineSmartHome.Models
{
    public abstract class Device : IDevice
    {
        private string _name;
        private bool _status;

        public string GetName() => _name;
        public bool GetStatus() => _status;

        public Device(string name)
        {
            _name = name;
            _status = false;
        }

        public virtual void TurnOn()
        {
            _status = true;
            Console.WriteLine($"{_name} is now ON.");
        }

        public virtual void TurnOff()
        {
            _status = false;
            Console.WriteLine($"{_name} is now OFF.");
        }

        public virtual string GetStatusString()
        {
            return $"{_name} is {(_status ? "ON" : "OFF")}";
        }
    }
}
