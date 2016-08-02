
namespace zoolandia
{
    
    public class carcharodonCarcharias : carcharodon, IFlyingJaws
    {
        public carcharodonCarcharias(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharodonCarcharias(string name) : base(name)
        {
            
        }
        public static string AirJaws = "I'll fly through the air with the greatest of ease";


        public void FlyingJaws()
        {
            System.Console.WriteLine("I can fly like a bird!");
        }



    }
}