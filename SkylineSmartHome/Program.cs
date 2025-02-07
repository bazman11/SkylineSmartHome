using System;
using System.Collections.Generic;
using SkylineSmartHome.Interfaces;
using SkylineSmartHome.Models;
using SkylineSmartHome.Models.Devices;
using SkylineSmartHome.Models.Enums;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int brojSoba = rand.Next(1, 6);
        Console.WriteLine("Dobrodosli u Skyline Smart Home Sistem.");

        Dictionary<int, Room> sobe = new Dictionary<int, Room>();
        Rooms[] sveSobe = { Rooms.DnevnaSoba, Rooms.Kuhinja, Rooms.Trpezarija, Rooms.SpavacaSoba, Rooms.DjecijaSoba, Rooms.Kupatilo };
        for (int i = 0; i < brojSoba; i++)
        {
            double temperatura = rand.Next(15, 31);
            sobe.Add(i + 1, new Room(sveSobe[i], temperatura));
        }

        Console.WriteLine($"Automatski se generisao stan sa {brojSoba} soba:");
        foreach (var soba in sobe)
        {
            Console.WriteLine($"{soba.Key}. {soba.Value.GetNaziv()} - Temperatura: {soba.Value.GetTemperatura()}°C");
            int brojUredjaja = rand.Next(1, 6);
            for (int j = 0; j < brojUredjaja; j++)
            {
                IDevice uredjaj;
                switch (soba.Value.GetNaziv())
                {
                    case "Kuhinja":
                        uredjaj = rand.Next(2) == 0 ? new Frizider("Frizider") : new MasinaZaSudje("Masina za sudje");
                        break;
                    case "Kupatilo":
                        uredjaj = rand.Next(2) == 0 ? new Bojler("Bojler") : new VesMasina("Ves Masina");
                        break;
                    case "DnevnaSoba":
                    case "SpavacaSoba":
                    case "DjecijaSoba":
                        uredjaj = rand.Next(2) == 0 ? new Sijalica("Sijalica") : new Racunar("Racunar");
                        break;
                    default:
                        uredjaj = new Sijalica("Sijalica");
                        break;
                }
                sobe[soba.Key].DodajUredjaj(uredjaj);
            }
        }

        while (true)
        {
            Console.WriteLine("\nOdaberi sobu (unesi broj, -1 za izlaz):");
            if (!int.TryParse(Console.ReadLine(), out int izborSobe) || izborSobe == -1)
                break;

            if (!sobe.ContainsKey(izborSobe))
            {
                Console.WriteLine("Neispravan unos. Pokusaj ponovo.");
                continue;
            }

            Room odabranaSoba = sobe[izborSobe];
            Console.WriteLine($"Odabrali ste sobu: {odabranaSoba.GetNaziv()} - Temperatura: {odabranaSoba.GetTemperatura()}°C.");

            Console.WriteLine("Dostupni uređaji:");
            List<IDevice> uredjaji = odabranaSoba.GetDevices();
            for (int i = 0; i < uredjaji.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {uredjaji[i].GetName()} ({uredjaji[i].GetStatusString()})");
            }

            Console.WriteLine("Odaberi uredjaj (unesi broj, -1 za nazad):");
            if (!int.TryParse(Console.ReadLine(), out int izborUredjaja) || izborUredjaja == -1)
                continue;

            if (izborUredjaja < 1 || izborUredjaja > uredjaji.Count)
            {
                Console.WriteLine("Neispravan unos. Pokusaj ponovo.");
                continue;
            }

            IDevice odabraniUredjaj = uredjaji[izborUredjaja - 1];
            Console.WriteLine($"Odabrali ste uredjaj: {odabraniUredjaj.GetName()}");

            Console.WriteLine("1. Upali\n2. Ugasi");
            if (odabraniUredjaj is Klima klima)
            {
                Console.WriteLine("3. Povecaj temperaturu rada\n4. Smanji temperaturu rada");
                Console.WriteLine("5. Povecaj temperaturu sobe\n6. Smanji temperaturu sobe");
            }

            if (!int.TryParse(Console.ReadLine(), out int akcija))
                continue;

            switch (akcija)
            {
                case 1:
                    odabraniUredjaj.TurnOn();
                    break;
                case 2:
                    odabraniUredjaj.TurnOff();
                    break;
                case 3:
                    if (odabraniUredjaj is Klima klima1)
                        klima1.PovecajTemperaturu();
                    break;
                case 4:
                    if (odabraniUredjaj is Klima klima2)
                        klima2.SmanjiTemperaturu();
                    break;
                case 5:
                    odabranaSoba.SetTemperatura(odabranaSoba.GetTemperatura() + 1);
                    break;
                case 6:
                    odabranaSoba.SetTemperatura(odabranaSoba.GetTemperatura() - 1);
                    break;
                default:
                    Console.WriteLine("Neispravna opcija.");
                    break;
            }
        }

        Console.WriteLine("Izlazak iz sistema...");
    }
}
