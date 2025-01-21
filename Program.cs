// See https://aka.ms/new-console-template for more information


using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

public class Opgaver
{

    public static void Main()
    {
        //Løkke til hovedmenuen
        while (true)
        {
            //Udskriver hovedmenuen. 
            Console.Clear();
            Console.WriteLine("Grundlæggende Programmering H1. Opgavesæt. Asger Ømann.");
            Console.WriteLine("");
            Console.WriteLine("Tryk på en tast for at vælge kategori: ");
            Console.WriteLine("A) Begynderopgaver");
            Console.WriteLine("B) Rutinerede Opgaver");
            Console.WriteLine("C) Avancerede Opgaver");

            char tast = char.ToUpper(Console.ReadKey(true).KeyChar);

            switch (tast)
            {
                case 'A':
                    Opgaver.A_Opgaver();
                    break;
                case 'B':
                    break;
                case 'C':
                    break;
                default:
                    continue;
            }

        }
    }
    public static void A_Opgaver()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("A Begynderopgaver ");
            Console.WriteLine("\t1. Hej Verden Program ");
            Console.WriteLine("\t2. Simpel Variabel Opgave ");
            Console.WriteLine("\t3. Grundlæggende Matematiske Operationer");
            Console.WriteLine("\t4. If-else Struktur med Alder ");
            Console.WriteLine("\t5. Grader Fahrenheit til Celsius");
            Console.WriteLine("\t6. Lommeregner ");
            Console.WriteLine("\t7. Brugerdefinerede Metoder ");
            Console.WriteLine("\t8. Loop Eksempel - For Løkke");
            Console.WriteLine("\t9. Simple Arrays ");
            Console.WriteLine("\t10. Multi-dimensionelle Arrays");
            Console.WriteLine("\t11. Konstanter ");
            Console.WriteLine("\t12. E-mail Validering");
            Console.WriteLine("\t13. Fejlretning ");
            Console.WriteLine("\t14. Opretning og Brug af Kommentarer ");
            Console.WriteLine("\t15. Tal Rækkefølge ");
            Console.WriteLine("\t16. Grundlæggende BMI-beregner");
            Console.WriteLine("\t17. String Formattering ");
            Console.WriteLine("\t18. Talgenkendelse med Løkke");
            Console.WriteLine("\t19. Grunding af Versionsstyring");
            Console.WriteLine("\t20. Basis Login System ");
            Console.WriteLine("\t0. TILBAGE til hovedmenuen.");
            Console.WriteLine();
            Console.WriteLine("Indtast et tal fra 0 til 20 og afslut med ENTER.");

            int input;
            if (int.TryParse(Console.ReadLine(), out input) != true)
            {
                Console.WriteLine("Fejl: Du skal indstaste et tal mellem 0 og 20. Tryk på en tast for at prøve igen");
                Console.ReadKey(true);
                continue;
            }

            //Tjek om gyldigt input, clear skærmen hvis det er tilfædet. 
            if (input >= 1 && input <= 20)
            {
                Console.Clear();
            }

            switch (input)
            {
                case 1:
                    OpgA_01();
                    continue;
                case 2:
                    OpgA_02();
                    continue;
                case 3:
                    OpgA_03();
                    continue;
                case 4:
                    OpgA_04();
                    continue;
                case 5:
                    OpgA_05();
                    continue;
                case 6:
                    OpgA_06();
                    continue;
                case 7:
                    OpgA_07();
                    continue;
                case 8:
                    OpgA_08();
                    continue;
                case 9:
                    OpgA_09();
                    continue;
                case 10:
                    OpgA_10();
                    continue;
                case 11:
                    OpgA_11();
                    continue;
                case 12:
                    OpgA_12();
                    continue;
                case 13:
                    OpgA_13();
                    continue;
                case 14:
                    OpgA_14();
                    continue;
                case 15:
                    OpgA_15();
                    continue;
                case 16:
                    OpgA_16();
                    continue;
                case 17:
                    OpgA_17();
                    continue;
                case 18:
                    OpgA_18();
                    continue;
                case 19:
                    OpgA_19();
                    continue;
                case 20:
                    OpgA_20();
                    continue;

                case 0:
                    break;
                default:
                    Console.WriteLine("Fejl: Du skal indstaste et tal mellem 0 og 20. Tryk på en tast for at prøve igen");
                    Console.ReadKey(true);
                    continue;
            }
            break;
        }

    }


    //1. Hej Verden Program
    // • Udskriv "Hej Verden" i konsollen.
    // • Fokus: Introduktion til konsolprogrammering.
    public static void OpgA_01()
    {
        Console.WriteLine("Hej Verden!");
        Console.ReadKey(true);
    }


    //2. Simpel Variabel Opgave
    // * Deklarér en string-variabel med dit navn og udskriv den.
    // * Fokus: Variabler og datatyper.
    public static void OpgA_02()
    {
        string navn = "Asger Ømann";
        Console.WriteLine(navn);
        Console.ReadKey(true);
    }

    /* 3. Grundlæggende Matematiske Operationer
     *   • Brugeren indtaster to tal, og programmet udfører addition, subtraktion, multiplikation
     *     og division.
     *   • Fokus: Enkle operationer, metoder og variabler.
     */
    public static void OpgA_03()
    {
        Console.WriteLine("Programmet udfører addition, subtraktion, multiplication og division på to tal angivet af brugeren");
        double tal1, tal2;
        Console.WriteLine("Indtast det første tal");
        if (double.TryParse(Console.ReadLine(), out tal1) != true)
        {
            Console.WriteLine("Fejl: Ikke et gyldigt tal!");
            Console.ReadKey();
            return;
        }
        ;
        Console.WriteLine("Indtast det andet tal");
        if (double.TryParse(Console.ReadLine(), out tal2) != true)
        {
            Console.WriteLine("Fejl: Ikke et gyldigt tal!");
            Console.ReadKey();
            return;
        }
        ;
        Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
        Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}");
        Console.WriteLine($"{tal1} * {tal2} = {tal1 * tal2}");
        Console.WriteLine($"{tal1} / {tal2} = {tal1 / tal2}");
        Console.ReadKey(true);
    }

    //     4. If-else Struktur med Alder
    // • Brugeren indtaster sin alder, og programmet afgør, om de er myndige.
    // • Fokus: Kontrolstrukturer.
    public static void OpgA_04()
    {
        Console.WriteLine("Indtast din alder");
        double alder;
        if (double.TryParse(Console.ReadLine(), out alder) != true)
        {
            Console.WriteLine("Fejl: Ikke et gyldigt tal!");
            Console.ReadKey();
            return;
        }
        ;
        if (alder < 18)
        {
            Console.WriteLine("Du er umyndig");
        }
        else
        {
            Console.WriteLine("Du er myndig");
        }
        Console.ReadKey(true);
    }

    //5. Grader Fahrenheit til Celsius
    // • Brugeren indtaster en temperatur i Fahrenheit, og programmet konverterer den til
    // Celsius.
    // • Fokus: Matematiske operationer og datatyper.
    public static void OpgA_05()
    {
        Console.WriteLine("Indtast en temperatur i Fahrenheit");
        double temp_Fahr;
        if (double.TryParse(Console.ReadLine(), out temp_Fahr) != true)
        {
            Console.WriteLine("Fejl: Ikke et gyldigt tal!");
            Console.ReadKey();
            return;
        }
        ;
        double temp_Celc = (temp_Fahr - 32.0) * (5.0 / 9.0);
        Console.WriteLine($"Temperaturen omregnet til celcius er: {temp_Celc:N2}");
        Console.ReadKey(true);
    }


    //6. Lommeregner
    // • Brugeren vælger en operation og to tal; programmet udfører operationen og viser
    //   resultatet.
    // • Fokus: Kontrolstrukturer og metoder.
    public static void OpgA_06()
    {
        Console.WriteLine("Opgave 6: Lommeregner.");
        Console.WriteLine("Tryk på en tast for at vælge en operation.");
        Console.WriteLine("A. Addition.");
        Console.WriteLine("S. Subtraktion.");
        Console.WriteLine("M. Multiplikation.");
        Console.WriteLine("D. Division.");
        char tast;
        while (true)
        {
            tast = char.ToUpper(Console.ReadKey(true).KeyChar);
            switch (tast)
            {
                case 'A':
                case 'S':
                case 'M':
                case 'D':
                    break;
                default:
                    continue;
            }
            break;
        }
        double tal1, tal2;
        Console.WriteLine("Indtast det første tal");
        if (double.TryParse(Console.ReadLine(), out tal1) != true)
        {
            Console.WriteLine("Fejl: Ikke et gyldigt tal!");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Indtast det andet tal");
        if (double.TryParse(Console.ReadLine(), out tal2) != true)
        {
            Console.WriteLine("Fejl: Ikke et gyldigt tal!");
            Console.ReadKey();
            return;
        }

        switch (tast)
        {
            case 'A':
                Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
                break;
            case 'S':
                Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}");
                break;
            case 'M':
                Console.WriteLine($"{tal1} * {tal2} = {tal1 * tal2}");
                break;
            case 'D':
                Console.WriteLine($"{tal1} / {tal2} = {tal1 / tal2}");
                break;
        }
        Console.ReadKey(true);
    }

    //7. Brugerdefinerede Metoder
    // • Opret en metode, der udskriver en velkomstbesked, og kald metoden.
    // • Fokus: Metoder uden returværdi.
    public static void OpgA_07()
    {
        OpgA_07_Velkomstbesked();
        Console.ReadKey(true);
    }

    public static void OpgA_07_Velkomstbesked()
    {
        Console.WriteLine("Velkommen til opgave 7!");
    }

    //8. Loop Eksempel – For Løkke
    // • Programmet udskriver tallene fra 1 til 10.
    //• Fokus: For-løkker og iteration.
    public static void OpgA_08()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write(i);
            Console.Write("\t");
        }
        Console.ReadKey(true);
    }


    //9. Simple Arrays
    // • Lav et program, der udskriver elementerne i en enkel array (f.eks. en liste over
    // frugter).
    // • Fokus: Arrays.
    public static void OpgA_09()
    {
        string[] pizzaer = { "Margaritha", "Calzone", "Capricciosa", "Bianca", "Kebabpizza" };
        Console.WriteLine("Liste over pizzaer:");
        foreach (string pizza in pizzaer)
        {
            Console.WriteLine(pizza);
        }
        Console.ReadKey(true);
    }

    //10. Multi-dimensionelle Arrays
    // • Lav en 2x2 matrix, der repræsenterer en simpel tabel over tal, og udskriv indholdet.
    // • Fokus: Multidimensionelle arrays.
    public static void OpgA_10()
    {
        int[][] talbox = [[1, 2], [3, 4]];
        foreach (int[] talrække in talbox)
        {
            foreach (int tal in talrække)
            {
                Console.Write(tal);
                Console.Write(" ");
            }
            Console.Write("\n");
        }
        Console.ReadKey(true);
    }

    //11. Konstanter
    // • Brug en konstant til at repræsentere moms (f.eks. 25%) og beregn moms for en
    // given pris.
    // • Fokus: Variabler og konstanter.

    public static void OpgA_11()
    {
        const double MOMSsats = 0.25;
        Console.WriteLine("Momsomregner: Skriv en pris uden moms, i kr., for at få lagt moms til:");
        double BeløbUdenMOMS;
        if (double.TryParse(Console.ReadLine(), out BeløbUdenMOMS) == false)
        {
            Console.WriteLine("ugyldigt beløb.");
        }
        ;
        Console.WriteLine($"Prisen med MOMS er {BeløbUdenMOMS + (BeløbUdenMOMS * MOMSsats):N2} kr.");
        Console.ReadKey(true);
    }
    public static void OpgA_12()
    {
        Console.WriteLine("Skriv en emailadresse ");
        string email = Console.ReadLine()!;
        bool email_check = false;
        if (email.Contains('@'))
        {
            if (email.Split('@')[1].Contains('.'))
            {
                System.Console.WriteLine("Din email ser fin ud.");
                email_check = true;
            }
        }
        if (!email_check) Console.WriteLine("Din email mangler et @ eller .");

        Console.ReadKey(true);
    }
    public static void OpgA_13()
    {

        Console.ReadKey(true);
    }
    public static void OpgA_14()
    {

        Console.ReadKey(true);
    }

    //15. Tal Rækkefølge
    // • Brugeren indtaster tre tal, og programmet viser dem i stigende rækkefølge.
    // • Fokus: Arrays og kontrolstrukturer.
    public static void OpgA_15()
    {
        //Deklarer række af 3 tal. 
        double[] talrække = [0, 0, 0];
        //Løkke til bruger input
        for (int i = 0; i < 3; i++)
        {
            //Brugerinstruktion
            Console.WriteLine($"Skriv det {i + 1}. tal.");
            //Tryparse bruger input
            if (!double.TryParse(Console.ReadLine(), out talrække[i]))
            {
                //Besked til brugeren om fejlindtastning, afslutning af programmet. 
                Console.WriteLine("Ugyldigt tal.");
                Console.ReadKey(true);
                return;
            }
        }
        //Sortering af input. "Bubble sort" metoden.
        double swap;
        for (int i = 0; i < (talrække.Length - 1); i++)
        {
            if (talrække[i] > talrække[i + 1])
            {
                swap = talrække[i];
                talrække[i] = talrække[i + 1];
                talrække[i + 1] = swap;
            }
        }
        //Udskrivning af den sorterede talrække. 
        Console.Write("Den sortede talrække er: ");
        for (int i = 0; i < talrække.Length; i++)
        {
            Console.Write($"{talrække[i]} ");
        }

        //Afvent tastetryk fra bruger før afslutning. 
        Console.ReadKey(true);
    }

    //16. Grundlæggende BMI-beregner
    // • Brugeren indtaster højde og vægt, og programmet beregner BMI.
    // • Fokus: Matematiske operationer og variabler.
    public static void OpgA_16()
    {
        //Deklarering af variabler
        double højde_cm, højde_m, vægt_kg, bmi;
        //Brugerinput højde
        Console.WriteLine("Skriv din højde i cm.");
        if (!double.TryParse(Console.ReadLine(), out højde_cm))
        {
            //Besked til brugeren om fejlindtastning, afslutning af programmet. 
            Console.WriteLine("Ugyldigt tal.");
            Console.ReadKey(true);
            return;
        }
        //Brugerinput vægt
        Console.WriteLine("Skriv din vægt i kg.");
        if (!double.TryParse(Console.ReadLine(), out vægt_kg))
        {
            //Besked til brugeren om fejlindtastning, afslutning af programmet. 
            Console.WriteLine("Ugyldigt tal.");
            Console.ReadKey(true);
            return;
        }
        //Udregning af BMI
        højde_m = højde_cm / 100.0;
        bmi = vægt_kg / (højde_m * højde_m);

        Console.WriteLine($"Din BMI er {bmi}");

        Console.ReadKey(true);
    }

    //17. String Formattering
    // • Brugeren indtaster navn og alder, og programmet formaterer og udskriver disse.
    // • Fokus: String manipulation.
    public static void OpgA_17()
    {
        //Brugeren skriver sit navn.
        Console.Write("Skriv dit navn: ");
        string navn = Console.ReadLine()!;
        //Brugeren skriver sin alder.
        Console.Write("Skriv dit alder: ");
        string alder = Console.ReadLine()!;

        //Udskrivning af navn og alder
        Console.Clear();
        Console.WriteLine($"Du hedder {navn} og er {alder} år gammel!");
        Console.ReadKey(true);
    }

    //18. Talgenkendelse med Løkke
    // • Brugeren indtaster tal mellem 1 og 10 indtil de gætter det "hemmelige" tal.
    //• Fokus: Løkker og betingelser.
    public static void OpgA_18()
    {
        //Sæt det hemmelige tal til en værdi mellem 1 og 10. 
        Random rand = new Random();
        int hemmelig = (rand.Next() % 10) + 1;

        //Brugerinstruktion
        Console.WriteLine("Gæt et tal fra 1 til 10");
        int gæt, forsøg = 1;
        //Tjek af brugerinput, skal være et tal. 
        while (!int.TryParse(Console.ReadLine(), out gæt))
        {
            Console.WriteLine("Fejl: Gættet skal være et heltal!");
        }
        
        //Tjek om tallet er det hemmelig tal. Gentag input og tjek i en løkke indtil brugeren gætter rigtigt. 
        while (gæt != hemmelig)
        {
            Console.WriteLine("Forkert gæt prøv igen!");
            forsøg++;
            while (!int.TryParse(Console.ReadLine(), out gæt))
            {
                Console.WriteLine("Fejl: Gættet skal være et heltal!");
            }
        }
        //Udskriv lykønskning.
        Console.WriteLine($"Tillyke du gættede rigtigt i {forsøg} forsøg!");

        Console.ReadKey(true);
    }
    public static void OpgA_19()
    {

        Console.ReadKey(true);
    }
    public static void OpgA_20()
    {   
        //Hardcodede brugernavn og password
        string brugernavn = "admin", adgangskode = "Ab123456";
        //Deklarering af variabler til brugerinput. 
        string brugernavn_input, adgangskode_input; 
        //Input fra bruger.
        Console.WriteLine("Skriv brugernavn");
        brugernavn_input = Console.ReadLine()!;
        Console.WriteLine("Skrive adgangskode");
        adgangskode_input = Console.ReadLine()!;
        //Tjek om brugernavn og adgangskode stemmer. 
        if (brugernavn == brugernavn_input && adgangskode == adgangskode_input){
            Console.WriteLine("Velkommen til konsolen.");
        } else {
            Console.WriteLine("Forkert brugernavn eller adgangskode. Adgang nægtet!");
        }
        Console.ReadKey(true);
    }
}