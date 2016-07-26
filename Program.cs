using System;
using zoolandia;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            
            
         carcharodonMegalodon MyMegalodon = new carcharodonMegalodon("Bubbles", "Megalodon");
         Console.WriteLine("I have a " + MyMegalodon.CommonName + " named " + MyMegalodon.Name + ".");
         Console.WriteLine(MyMegalodon.Name + " has " + MyMegalodon.GetToothCount(600));
         Console.WriteLine(Animal.FeedMe(5, "Great White Sharks"));

         carcharhinusGalapagensis MyGalapagos = new carcharhinusGalapagensis("Fluffy", "Galapagos Shark");
         Console.WriteLine("I have a " + MyGalapagos.CommonName + " named " + MyGalapagos.Name + ".");
         Console.WriteLine(MyGalapagos.Name + " has " + MyGalapagos.GetToothCount(300));
         Console.WriteLine(Animal.FeedMe(12, "beer cans"));


         chelonoidisNigra MyTortoise = new chelonoidisNigra("Charlie", "Galapagos Tortoise");
         Console.WriteLine("I have a " + MyTortoise.CommonName + " named " + MyTortoise.Name + ".");
         Console.WriteLine(MyTortoise.Name + " has " + MyTortoise.GetToothCount(1));
         Console.WriteLine(Animal.FeedMe(3, "leaves"));


        sulaNebouxii MyBlueFootedBooby = new sulaNebouxii("Benny", "Blue-footed Booby");
         Console.WriteLine("I have a " + MyBlueFootedBooby.CommonName + " named " + MyBlueFootedBooby.Name + ".");
         Console.WriteLine(MyBlueFootedBooby.Name + " has " + MyBlueFootedBooby.GetToothCount(0));
         Console.WriteLine(Animal.FeedMe(6, "minnows"));

        }
    }
}
