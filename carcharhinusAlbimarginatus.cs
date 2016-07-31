
namespace zoolandia
{
    public class carcharhinusAlbimarginatus : carcharhinus
    {
        public carcharhinusAlbimarginatus(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharhinusAlbimarginatus(string name) : base(name)
        {
            
        }


        public static string SilverTip= "I have a silver tip on my dorsal fin!";


    }
}