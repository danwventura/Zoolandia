namespace zoolandia
{
    public class carcharhinusBrachyurus : carcharhinus, ISwimFast
    {
        public carcharhinusBrachyurus(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharhinusBrachyurus(string name) : base(name)
        {
            
        }

        public static string HookedTeeth = "I have hooked teeth";

        public static string GlobeTrotter = "I am found in most parts of the world";

         public void SwimFast()
        {
        System.Console.WriteLine("Warp Speed!");
        }
    }
}