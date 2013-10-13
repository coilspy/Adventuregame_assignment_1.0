using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        public static void life1(){

            string packa;
            string GångMål;
            string VapenKöp;
            int Guld = 150;

            int gla;
            Console.Clear();
            Console.WriteLine("Du vaknar på den kalla stenmarken i skogen.\nDin regnbågsskitande raptor väckte dig.");
            Console.WriteLine("Vill du \"packa\" dina saker och sticka eller bara \"sticka\"");
            //Använder while för att om man skulle skriva fel ska man få chansen att skriva in svaret igen utan att behöva starta om.
            packa = Console.ReadLine();
            while (packa.ToLower() != "packa" || packa.ToLower() != "sticka")
            {
                

                if (packa.ToLower() == "packa")
                {
                    Console.WriteLine("Du har inget att packa!");
                    Console.WriteLine("Du sticker ändån?");
                    Console.WriteLine("\nTryck \"enter\" för att fortsätta!");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                if  (packa.ToLower() == "sticka")
                {
                    Console.WriteLine("Du börjar gå.");
                    Console.WriteLine("Tryck \"enter\" för att fortsätta!");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                //Placerade vad som ska hända om du skriver fel på variablen packa för att annars skrevs det ut även om du svarade rätt.
                Console.WriteLine("Det är ingen möjlighet\nVar god försök igen.");
                packa = Console.ReadLine();
                
            } 

            Console.WriteLine("Du går och går... var ska du? ut och \"jaga\" eller gå till \"staden\"?");
            
            GångMål = Console.ReadLine();
            while(GångMål.ToLower() != "jaga" || GångMål.ToLower() != "staden")
            {

                if (GångMål.ToLower() == "jaga")
                {
                    Console.WriteLine("Du har inget att jaga med!");
                    Console.WriteLine("Men du kan köpa i staden");
                    Console.WriteLine("Tryck \"enter\" för att fortsätta");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }

                if (GångMål.ToLower() == "staden")
                {
                    Console.WriteLine("Du börjar gå emot staden.\nTryck \"enter\" för att fortsätta!");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                Console.WriteLine("Det är ingen möjlighet, var god försök igen");
                GångMål = Console.ReadLine();
		    }
            Console.WriteLine("Du anländer till staden på din raptor och går emot vapenbutiken.");
            Console.WriteLine("Tryck \"enter\" för att fortsätta");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Du har "+ Guld +" guld i din inventory");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("En \"yxa\" kostar 125 guld");
            Console.WriteLine("En \"pilbåge\" och 15 pilar kostar 130 guld");
            Console.WriteLine("Ett \"svärd\" kostar 110 guld");
            Console.ResetColor();
            Console.WriteLine("Vilken vill du köpa?");

            VapenKöp = Console.ReadLine();
            while (VapenKöp.ToLower() != "svärd" || VapenKöp.ToLower() != "pilbåge" || VapenKöp.ToLower() != "yxa")
            {
                if (VapenKöp.ToLower() == "svärd")
                {
                    Console.WriteLine("du köpte ett svärd för 110 guld");
                    Guld = 150 - 110;
                    Console.WriteLine("Du har " + Guld + " guld kvar");
                    Console.WriteLine("Tryck \"enter\" för att fortsätta");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                if (VapenKöp.ToLower() == "pilbåge")
                {
                    Console.WriteLine("Du köpte en pilbåge och 15 pilar för 130 guld!");
                    Guld = 150 - 130;
                    Console.WriteLine("Du har " + Guld + " guld kvar");
                    Console.WriteLine("Tryck \"enter\" för att fortsätta");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                if (VapenKöp.ToLower() == "yxa")
                {
                    Console.WriteLine("Du köpte en yxa för 125 guld!");
                    Guld = 150 - 125;
                    Console.WriteLine("Du har " + Guld + " guld kvar");
                    Console.WriteLine("Tryck \"enter\" för att fortsätta");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
            }
                Console.WriteLine("Du har nu något att jaga med!");
                Console.WriteLine("Tillsammans med din raptor börjar ni gå emot skogen!");
                Console.WriteLine("Tryck \"enter\" för att fortsätta");
                Console.ReadLine();
                Console.Clear();
            
  

    }       
            



        static void Main(string[] args)
        {
            //Deklarerar alla mina variabler överst i koden så att det är lätt att hitta dem.
            string ras;
            string namn;
            string spelstil;

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


            Console.WriteLine("vill du spela som en \"jägare\" i skogen eller som en \"gladiator\"?");
            spelstil = Console.ReadLine();
            switch (spelstil.ToLower())
            {
                case "jägare":
                    life1();
                    break;
                case "gladiator":
                    break;
            }



           
            









            Console.ReadLine();
        }
  
    }

}






 
