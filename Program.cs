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

         carcharhinusGalapagensis MyGalapagos = new carcharhinusGalapagensis("Fluffy", "Galapagos Shark");
         Console.WriteLine("I have a " + MyGalapagos.CommonName + " named " + MyGalapagos.Name + ".");



         chelonoidisNigra MyTortoise = new chelonoidisNigra("Charlie", "Galapagos Tortoise");
         Console.WriteLine("I have a " + MyTortoise.CommonName + " named " + MyTortoise.Name + ".");


        sulaNebouxii MyBlueFootedBooby = new sulaNebouxii("Benny", "Blue-footed Booby");
         Console.WriteLine("I have a " + MyBlueFootedBooby.CommonName + " named " + MyBlueFootedBooby.Name + ".");

        }
    }
}
