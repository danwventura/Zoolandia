namespace zoolandia
{
    public class carcharhinusCautus : carcharhinus
    {
        public carcharhinusCautus(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharhinusCautus(string name) : base(name)
        {
            
        }


        public static string GetNervous = "I am timid and get nervous around humans";
    }
}