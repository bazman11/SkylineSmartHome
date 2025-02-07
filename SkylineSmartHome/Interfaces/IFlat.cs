using SkylineSmartHome.Models.Devices;
using SkylineSmartHome.Models.Enums;
using System.Collections.Generic;

namespace SkylineSmartHome.Interfaces
{
    public interface IFlat
    {
        void DodajUredjaj(Rooms soba, IDevice device);
        void PrikaziUredjaje();
    }
}
