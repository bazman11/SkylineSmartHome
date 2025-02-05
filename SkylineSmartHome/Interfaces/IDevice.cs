using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkylineSmartHome.Interfaces
{
    public interface IDevice
    {
        int GetId();
        void SetId(int id);

        string GetName();
        void SetName(string name);

        bool GetStatus();
        void SetStatus(bool status);

        void TurnOn();
        void TurnOff();
        string GetStatusString();
    }

}
