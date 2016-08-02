namespace zoolandia
{
    public class carcharhinusAmblyrhynchoides : carcharhinus
    {
        public carcharhinusAmblyrhynchoides(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharhinusAmblyrhynchoides(string name) : base(name)
        {
            
        }

        public static string Graceful = "I am very graceful, for I am the Graceful Shark.";
    }
}