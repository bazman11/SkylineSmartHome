# Skyline Smart Home

Kratka konzolna aplikacija razvijena u .NET 6, kao ulazni projekat za Skyline Coding Battle.

## Pokretanje aplikacije

1. Pokrenite aplikaciju unutar .NET okruzenja. Preporucujem Visual Studio.
2. Program ce automatski generisati stan sa **slucajnim brojem soba (1-5)**, i slucajnim brojem uredjaja u svakoj sobi.
3. Bit ce prikazan spisak dostupnih soba.
4. Korisnik bira sobu unosom broja.

## Interakcija sa aplikacijom

### 1. Odabir sobe
- Nakon prikaza dostupnih soba, korisnik unosi sa tastature broj sobe koju zeli da pregleda.
- Za izlazak iz programa, unosi **-1**.

### 2. Pregled i upravljanje uredjajima
- Nakon odabira sobe, program prikazuje dostupne uredjaje.
- Korisnik unosi redni broj uredjaja kojim zeli manipulisati.
- Za povratak na izbor sobe, unosi se **-1**.

### 3. Kontrola uredjaja
- Kada korisnik odabere uređaj, nudi se:
  - **1** - Ukljucivanje uredjaja
  - **2** - Iskljucivanje uredjaja
  - **3** - Povecavanje temperature (ako je uredjaj **Klima**)
  - **4** - Smanjvanje temperature (ako je uredjaj **Klima**)

## Restrikcija za uredjaje po sobama
- **Kuhinja** moze imati: **Masinu za sudje, Frizider**
- **Kupatilo** moze imati: **Bojler, Ves-masinu**
- **Sve sobe** mogu imati **Sijalicu**

## Izlazak iz aplikacije
- U bilo kojem trenutku, korisnik moze unijeti **-1** sa tastature kako bi se vratio na prethodni meni ili izasao iz aplikacije.
