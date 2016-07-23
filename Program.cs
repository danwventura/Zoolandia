using System;
using zoolandia;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
         carcharodonMegalodon Bubbles = new carcharodonMegalodon();
         Console.WriteLine("I have a pet named " + Bubbles.Name + ".");
         Console.WriteLine("He is a " + Bubbles.CommonName + ".");
         Console.WriteLine("He is a big fella measuring over " + Bubbles.GetLength() + " feet long.");
        //  Console.WriteLine("When he is hungry, he likes to eat " + Bubbles.CatchPrey(string GreatWhite));


         carcharhinusGalapagensis Oscar = new carcharhinusGalapagensis();
         Console.WriteLine("I have a second pet named " + Oscar.Name + ".");
         Console.WriteLine("He is a " + Oscar.CommonName + ".");
         Console.WriteLine("He is a medium fella measuring over " + Oscar.GetLength() + " feet long.");
        //  Console.WriteLine("When he is hungry, he likes to eat ") + Oscar.EatTrash(string RustyCan)


         chelonoidisNigra Charlie = new chelonoidisNigra();
         Console.WriteLine("I have a third pet named " + Charlie.Name + ".");
         Console.WriteLine("He is a " + Charlie.CommonName + ".");
         Console.WriteLine("He is a heavy bro weighing in over " + Charlie.GetWeight() + " pounds.");
        //  Console.WriteLine("Charlie is no spring hare. He even " + Charlie.DoSomethingSlowly(string Walks));

        sulaNebouxii Benny = new sulaNebouxii();
        Console.WriteLine("My last pet is named " + Benny.Name + ".");
        Console.WriteLine("He is a " + Benny.CommonName + ".");
        Console.WriteLine("He has HUGE.......wings. They are " + Benny.GetWingspan() + " feet long, tip to tip.");
        // Console.WriteLine("When he has free time he likes to travel to " + Benny.FlyTo(string Galapagos));
        }
    }
}
