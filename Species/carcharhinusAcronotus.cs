

namespace zoolandia
{
    
    public class carcharhinusAcronotus : carcharhinus, ISwimFast
    {
        public carcharhinusAcronotus(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharhinusAcronotus(string name) : base(name)
        {
            
        }
        public static string BlackNose = "I have a black nose";

        public void SwimFast()
        {
        System.Console.WriteLine("Warp Speed!");
        }
    }


    
}