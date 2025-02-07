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
    public class Flat : IFlat
    {
        private Dictionary<Rooms, List<IDevice>> sobe;

        public Flat()
        {
            sobe = new Dictionary<Rooms, List<IDevice>>
        {
            { Rooms.DnevnaSoba, new List<IDevice>() },
            { Rooms.SpavacaSoba, new List<IDevice>() },
            { Rooms.Kuhinja, new List<IDevice>() },
            { Rooms.Trpezarija, new List<IDevice>() },
            { Rooms.DjecijaSoba, new List<IDevice>() },
            { Rooms.Kupatilo, new List<IDevice>() }
        };
        }

        public void DodajUredjaj(Rooms soba, IDevice device)
        {
            if ((soba == Rooms.Kuhinja && (device is MasinaZaSudje || device is Frizider)) ||
                (soba == Rooms.Kupatilo && (device is Bojler || device is VesMasina)) ||
                (soba != Rooms.Kuhinja && soba != Rooms.Kupatilo && !(device is MasinaZaSudje || device is Frizider || device is Bojler || device is VesMasina)))
            {
                sobe[soba].Add(device);
                Console.WriteLine($"Uredjaj {device.GetName()} dodat u {soba}.");
            }
            else
            {
                Console.WriteLine($"Uredjaj {device.GetName()} se ne moze dodati u {soba}.");
            }
        }

        public void PrikaziUredjaje()
        {
            foreach (var soba in sobe)
            {
                Console.WriteLine($"\n{soba.Key}:");
                foreach (var uredjaj in soba.Value)
                {
                    Console.WriteLine($"  - {uredjaj.GetName()} ({uredjaj.GetStatusString()})");
                }
            }
        }
    }

}
