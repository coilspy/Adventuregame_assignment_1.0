using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarerar alla mina variabler överst i koden så att det är lätt att hitta dem.
            string ras;
            string namn;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            //Introductionen till mitt spel
            Console.WriteLine("DET MEST EPISKA SPELET NÅGONSIN!");
            Console.WriteLine("Tryck \"enter\" för att börja");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();

            //Jag ville få in en någorlunda Rpg-ish stil i mitt spel och därför kodade jag namnval och rasval.
            Console.WriteLine("Innan vi börjar ska du få välja en ras och namn.\nMöjliga raser: Ork, Alv, Människa och Gnom");
            ras = Console.ReadLine();
            while (!(ras.ToLower() == "gnom" || ras.ToLower() == "alv" || ras.ToLower() == "ork" || ras.ToLower() == "människa"))
            {
                Console.WriteLine("Det är ingen valbar ras\nVar snäll och välj en valbar ras.");
                ras = Console.ReadLine();


            }
            Console.WriteLine("Du valde " + ras + "\nNu ska du välja namn");
            Console.WriteLine("Tryck \"enter\" för att fortsätta");
            Console.ReadLine();
            Console.Clear();

            //Påminner spelaren om vilken ras den valde för att kunna välja något namn som passar,om man vill det.
            Console.WriteLine("(Tänk på att du är en " + ras + ")");
            Console.WriteLine("Vad vill du heta?");
            namn = Console.ReadLine();
            
            Console.WriteLine("Du heter nu " + namn + " och är av rasen " + ras);
            Console.WriteLine("Tryck \"enter\" för att fortsätta");
            Console.ReadLine();
            Console.Clear();





            Console.WriteLine("Du vaknar på den kalla stenmarken i din cell.\nDin regnbågsskitande raptor väckte dig.");











            Console.ReadLine();
        }

    }
}
