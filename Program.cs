using System;
using System.Collections.Generic;
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
         Console.WriteLine(carcharodonMegalodon.Lazarus);
         MyMegalodon.FlyingJaws();


         carcharhinusGalapagensis MyGalapagos = new carcharhinusGalapagensis("Fluffy", "Galapagos Shark");
         Console.WriteLine("I have a " + MyGalapagos.CommonName + " named " + MyGalapagos.Name + ".");
         Console.WriteLine(MyGalapagos.Name + " has " + MyGalapagos.GetToothCount(300));
         Console.WriteLine(Animal.FeedMe(12, "beer cans"));
         Console.WriteLine(carcharhinusGalapagensis.Galapagos);
         MyGalapagos.SwimFast();


         chelonoidisNigra MyTortoise = new chelonoidisNigra("Charlie", "Galapagos Tortoise");
         Console.WriteLine("I have a " + MyTortoise.CommonName + " named " + MyTortoise.Name + ".");
         Console.WriteLine(MyTortoise.Name + " has " + MyTortoise.GetToothCount(1));
         Console.WriteLine(chelonoidisNigra.EatPlants);
         Console.WriteLine(Animal.FeedMe(3, "leaves"));
         Console.WriteLine(MyTortoise.LayEggs(300));
         MyTortoise.MoveSlowly();


         sulaNebouxii MyBlueFootedBooby = new sulaNebouxii("Benny", "Blue-footed Booby");
         Console.WriteLine("I have a " + MyBlueFootedBooby.CommonName + " named " + MyBlueFootedBooby.Name + ".");
         Console.WriteLine(MyBlueFootedBooby.Name + " has " + MyBlueFootedBooby.GetToothCount(0));
         Console.WriteLine(Animal.FeedMe(6, "minnows"));
         MyBlueFootedBooby.Fly();

         carcharodonCarcharias MyGreatWhite = new carcharodonCarcharias("Sammy", "Great White Shark");


         Console.WriteLine();
         Aquarium my_aquarium = new Aquarium();
         Console.WriteLine("Habitat: " + my_aquarium.public_name);
         my_aquarium.inhabitants.Add(MyMegalodon);
         my_aquarium.inhabitants.Add(MyGalapagos);
         Console.WriteLine(MyMegalodon.CommonName);
         Console.WriteLine(MyGreatWhite.CommonName);
         Beach my_beach = new Beach();
         Console.WriteLine("Habitat: " + my_beach.public_name);
         my_beach.inhabitants.Add(MyBlueFootedBooby);
         my_beach.inhabitants.Add(MyTortoise);
         Console.WriteLine(MyBlueFootedBooby.CommonName);
         Console.WriteLine(MyTortoise.CommonName);



        }
    }
}
