namespace zoolandia
{
    public class carcharhinusAmblyrhynchos : carcharhinus
    {
        public carcharhinusAmblyrhynchos(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharhinusAmblyrhynchos(string name) : base(name)
        {
            
        }

        public static string HuntInReefs = "I hunt in the reefs.";
    }
}