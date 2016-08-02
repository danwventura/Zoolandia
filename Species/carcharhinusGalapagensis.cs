
namespace zoolandia
{
    
    public class carcharhinusGalapagensis : carcharhinus 
    {

         public carcharhinusGalapagensis(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharhinusGalapagensis(string name) : base(name)
        {
            
        }

        public static string Galapagos = "I live in near the Galapagos Islands";

       
       


            

    }
}