namespace zoolandia
{
    public class carcharhinusBorneensis : carcharhinus
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
    }
}