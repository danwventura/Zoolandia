namespace zoolandia
{
    public class carcharhinusAmblyrhynchoides : carcharhinus,ISwimFast
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

         public void SwimFast()
        {
        System.Console.WriteLine("Warp Speed!");
        }
    }
}