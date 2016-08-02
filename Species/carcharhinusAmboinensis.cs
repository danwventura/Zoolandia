namespace zoolandia
{
    public class carcharhinusAmboinensis : carcharhinus, ISwimFast
    {
        public carcharhinusAmboinensis(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharhinusAmboinensis(string name) : base(name)
        {
            
        }

        public static string PigEyes = "I have eyes and a snout like a pig";

         public void SwimFast()
        {
        System.Console.WriteLine("Warp Speed!");
        }
    }
}