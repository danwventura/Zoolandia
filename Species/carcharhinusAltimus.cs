
namespace zoolandia
{
    public class carcharhinusAltimus : carcharhinus, ISwimFast 
    {
        public carcharhinusAltimus(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharhinusAltimus(string name) : base(name)
        {
            
        }

        public static string BigNose = "I have a big nose";

         public void SwimFast()
        {
        System.Console.WriteLine("Warp Speed!");
        }
    }
}