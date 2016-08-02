namespace zoolandia
{
    public class carcharhinusBorneensis : carcharhinus, ISwimFast
    {
        public carcharhinusBorneensis(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharhinusBorneensis(string name) : base(name)
        {
            
        }

        public static string Endangered = "I am an endangered species.";

         public void SwimFast()
        {
        System.Console.WriteLine("Warp Speed!");
        }
    }
}