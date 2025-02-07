using SkylineSmartHome.Models.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SkylineSmartHome.Interfaces
{
    public interface IRoom
    {
        string GetNaziv();
        double GetTemperatura();
        void SetTemperatura(double temperatura);
        void DodajSijalicu(Sijalica sijalica);
        void DodajUredjaj(IDevice uredjaj);
        List<IDevice> GetDevices();
        void PrikaziStanje();
    }
}
