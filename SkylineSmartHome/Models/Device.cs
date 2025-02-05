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
        private int _id;
        private string _name;
        private bool _status;

        public int GetId() => _id;
        public void SetId(int id) => _id = id;

        public string GetName() => _name;
        public void SetName(string name) => _name = name;

        public bool GetStatus() => _status;
        public void SetStatus(bool status) => _status = status;

        public Device(int id, string name)
        {
            _id = id;
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
