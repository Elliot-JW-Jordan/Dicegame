namespace Dicegame22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Start;

            Random rand = new Random();
            int randomNumber, randomNumberDealer, tur = 0;
            bool Speltur = true;

            Console.WriteLine("Välkommen till 21");
            Console.WriteLine("Vil du påbörja spelet");





            while (true)
            {
                int talsumma = 0, dealertalsumma = 0;
                int Spelarbettsumma = 500;
                int bet;
                string input1;
                Console.WriteLine("Hur mycket utav" + Spelarbettsumma + "vill du betta (Max 500) ?");
                input1 = Console.ReadLine() ?? "";
               bet = int.Parse(input1);

               
                while (Speltur)
                {


                    Console.WriteLine("Vil du Slå eller Stanna");
                    Start = Console.ReadLine() ?? "";


                    if (Start == "Slå" || Start == "slå")
                    {
                        tur++;

                        randomNumber = rand.Next(1, 7);
                        talsumma += randomNumber;
                        Console.WriteLine(" Din summa ligger på " + talsumma + ". vill du  'Stanna' eller 'Slå'?");


                        randomNumberDealer = rand.Next(1, 7);
                        dealertalsumma += randomNumberDealer;
                        Console.WriteLine("Dealern slår " + randomNumberDealer + " och fick summan" + dealertalsumma + "Som summa");

                        // Start = Console.ReadLine() ?? "";


                        if (talsumma > 21)
                        {
                            Console.WriteLine("Du förlorade, din summa ligger på" + talsumma + "vilket ligger över gränsen av 21");

                            Console.WriteLine("Din slutgiltiga summa är :" + talsumma + " och dealerns :" + dealertalsumma);
                            return;

                            Speltur = false;

                            //break;
                        }


                    }




                    else if (Start == "Stanna" || Start == "stana")
                    {

                        Console.WriteLine("Du har valt att stanna,Din slutigtlia summa blev" + talsumma + "Det blir nu Delarns tur");
                        randomNumberDealer = rand.Next(1, 7);
                        dealertalsumma += randomNumberDealer;

                        Console.WriteLine("Dealern slår" + dealertalsumma + " och stannar");

                        Speltur = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ogiltig inmatning");
                        continue;
                    }








                }


                if (talsumma <= 21)
                {
                    Console.WriteLine("Nu är det dealerns tur.");

                    while (dealertalsumma < 17)
                    {
                        randomNumberDealer = rand.Next(1, 7);
                        dealertalsumma += randomNumberDealer;
                        Console.WriteLine("Dealern slår " + randomNumberDealer + " och fick summan" + dealertalsumma + "Som summa");



                        if (dealertalsumma > 21)
                        {
                            Console.WriteLine("Din slutgiltiga summa är :" + talsumma + " och dealerns :" + dealertalsumma);
                            Console.WriteLine("Dealern slog" + randomNumberDealer + " och fick  summan" + dealertalsumma + " vilket  ligger över 21,du vann ");

                            break;
                        }
                    }
                }


                if (dealertalsumma <= 21)
                {
                    Console.WriteLine("Din slutgilta summa är" + talsumma + " och dealerns är " + dealertalsumma);


                    if (talsumma > dealertalsumma)
                    {
                        Console.WriteLine("Du Vann");
                        Spelarbettsumma += bet * 2;
                        Console.WriteLine("Du har " + Spelarbettsumma + "poäng kvar");

                    }
                    else if (talsumma < dealertalsumma)
                    {
                        Console.WriteLine("Dealern Vann");

                        Spelarbettsumma = -bet;
                        Console.WriteLine("Du har " + Spelarbettsumma + "poäng kvar");
                    }
                    else
                    {
                        Spelarbettsumma = -bet;

                        Console.WriteLine("Det blev oavgjort");
                        Console.WriteLine("Du har " + Spelarbettsumma + "poäng kvar");
                    }












                }




























            }
        }
    }
}
