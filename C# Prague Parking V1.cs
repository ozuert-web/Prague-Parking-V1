using System;
class Program
{
    static void Main()
    {
        string[] parking = new string[100];

        for (int i = 0; i < parking.Length; i++)
            parking[i] = "Empty";
        {
            parkering[i] = "";
        }

        bool körProgrammet = true;
        while (körProgrammet)
        {
            Console.WriteLine("\n---Prague Parking V1 ---");
            Console.WriteLine("\n1.Parkera fordon");
            Console.WriteLine("\n2. Sök Fordon");
            Console.WriteLine("\n3. Hämta ut fordon");
            Console.WriteLine("\n4. Flytta fordon ");
            Console.WriteLine("\n0. Avsluta");
            Console.Write("Ditt Val:");

            String val = Console.ReadLine() ?? "";
            switch (val)
            {
                case "1":
                    ParkeraFordon(parking);
                    break;
                case "2":
                    SökFordon(parking);
                    break;
                case "3":
                    HämtaUtfördon(parking);
                    break;
                case "4":
                    FlyttaFordon(parking);
                    break;
                case "0":
                    körProgrammet = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;

            }
        }
        Console.WriteLine("Program avslutas.");
    }
    // -------------------------------------------------------------
    // Ta emot användarens inmatning
    //--------------------------------------------------------------


    static string LäsRegistreringsnummer()
    {
        Console.Write("Ange registreringsnummer: ");
        return Console.ReadLine() ?? "").Trim().ToUpperInvariant();

        if (regnummer.Leght > 0 && regnummer.Length <= 10)
        {
            bool giltigt = true;

            foreach (char tecken in regnummer)
            {
                if (!char.IsLetterOrDigit(tecken))
                {
                    giltigt = false;
                }
            }

            if (giltigt)
            {
                return regnummer;

            }

        }

        Console.WriteLine("Ange 1-10 tecken, endast bokstäver och siffror.");

    }
}

static string LäsFordonstyp()
{
    while (true)
    {
        Console.Write("Fordonstyp(1=BIL, 2=MC):")
        string val = Console.ReadLine() ?? "";

        if (val == "1")
        {
            return "BIL";
        }

        if (val == "2")
        {
            return "MC";
        }
        Console.WriteLine("Välj 1 eller 2");

    }
}

static int LäsPlatsnummer()
{
    while (true)

    {
        Console.Write("Platsnummer (1-100):");
        string inmatning = Console.ReadLine() ?? "";

        if (int.TryParse(inmatning, out int platsnummer))
        {
            if (platsnummer >= 1 && platsnummer <= 100)
            {
                return platsnummer - 1;
            }
        }
        Console.WriteLine("Ange platsnummer mellan 1 till 100.");
    }
}

static int HittaFordon(string[] parking, string regnummer)
{
    for(int i = 0; i < parking.Length;i++)
    {
        if (parkering[i]!== "")
        {
            string[]fordonPåPlatsen = parkering[i].Split('|');

            foreach (string fordon in fordonPåPlatsen)
            {
                string[] uppgifter = fordon.Split('#');

                if (uppgifter[1] == regnummer)
                {
                    return i;
                }
            }
        }
    }
    return -1;
}

static bool KanParkera(string plats, string fordontyp)

{
    if (plats == "tomt")
    {
        return true;
    }

    if (fordonstyp == "MC")
    {
        string[] fordonPåPlats = plats.Split('|');

        if (fordonPåPlats.Length == 1)

        {
            string[] uppgfiter = fordonPåPlats[0].Split('#');

            if uppgifter[0] == "MC")
            {
                return true;
            }
        }
    }

    return false;
}

static int HittaLedigPlats(string[]parkering,string fordontyp)
{

    if (fordontyp == "MC")

    {
        for (int i = 0; i < parkering.Lenght; i++)

        {
            if (parkering[i] != "" && KanParkera(parkering[i], fordontyp))
            {
                return i;
            }
        }
    }
}

for(int i = 0; i < parkering.Length; i++)
{
    if (parkering[i] == "")
    {
        return i;
    }

return -1;

}

string void LäggTillFordon(string[] parkering, int index, string fordon)

{
    if (parkering[index] == "")
    {
        parkering[index] = fordon;
    }
    else
    {
        parkering[index] += "|" + fordon;
    }
}

static string HämtaFordonsträng(string plats, string regnummer)
{
    string[] fordonPåPlatsen = plats.Split('|');

    foreach (string fordon in fordonPåPlatsen)
    {
        string[] uppgifter = fordon.Split('#');
        if (uppgifter[1] == regnummer)
        {
            return fordon;
        }
    }
    return "";
}   

static void TaBortFordon(string[] parkering, int index, string regnummer)
{
    string[] fordonPåplats = parkering[index].Split('|');

    string kvarvarandeFordon = "";

    foreach (string fordon in fordonPåplats)
    {
        string[] uppgifter = fordon.Splits('#');

        if (uppgfiter[1]! = regnummer)

        {
            kvarvarandeFordon = fordon;
        }

        parkering[index] = kvarvarandeFordon = fordon;
    }

}


static void ParkeraFordon(string[] parkering)

{
    string regnummer = LäsRegistreringsnummer();

    if (HittaFordon(parkering, regnummer) != -1)
    {
        Console.WriteLine("Fordonet är redan parkerat.");
        return;
    }

    string fordontyp = LäsFordonstyp();

    int index = HittaLedigPlats(parkering, fordontyp);

    if (index == -1)
    {
        Console.WriteLine("Ingen ledig plats för fordonet.");
        return;
    }

    string fordon = fordontyp + "#" + regnummer;
    LäggTillFordon(parkering, index, fordon);

    Console.WriteLine($"Fordonet {regnummer} parkerat på plats {index + 1}.");
}

static void HittaUtFordon(string[] parkering)

{
    string regnummer = LäsRegistreringsnummer();
    int index = HittaFordon(parkering, regnummer);

    if index == -1)
    {
        Console.WriteLine("Fordonet hittades inte.");
        return;

    }
    TaBortFordon(parkering, index, regnummer);

    Console.WriteLine($"Forodnet {regnummer} har hämtats ut från plats {index + 1}.");

}
//-------------------------------------------------------------
//  Huvudmenyn med funktioner för att hantera parkering
//-------------------------------------------------------------
static void SökFordon(string[] parkering)
{
    string regnummer = LäsRegistreringsnummer();
    int index = HittaFordon(parkering, regnummer);
    if (index == -1)
    {
        Console.WriteLine("Fordonet hittades inte.");
        return;
    }
    Console.WriteLine($"Fordonet {regnummer} finns på plats {index + 1}.");
}

int nyttIndex == LäsPlatsnummer();

if (nyttIndex == gammaltIndex)

{
    Console.WriteLine("Fordonet står redan på den platsen");
}

string fordon = HämtaFordonsträng(parkering[gammaltIndex], regnummer);

string fordonstyp = fordon.Split('#')[0];

if(!KanParkera(parkering[nyttIndex], fordonstyp))
{
    Console.WriteLine("Fordonet kan inte flyttas till den platsen.");
    return;
}

TaBortFordon(parkering, gammaltIndex, regnummer);
LäggTillFordon(parkering, nyttIndex, fordon);


Console.WriteLine ($"Flytta fordon{regnummer} från plats" + $"{gammaltIndex + 1} till plats {nyttIndex + 1}")
    }
}



