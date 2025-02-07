using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylineSmartHome.Interfaces
{
    public interface IDevice
    {
        string GetName();
        void TurnOn();
        void TurnOff();
        string GetStatusString();
    }

}
