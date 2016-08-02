
namespace zoolandia
{
    
    public class carcharhinusGalapagensis : carcharhinus, ISwimFast
    {

         public carcharhinusGalapagensis(string name, string commonname) : base(name, commonname)
         {
            
         }

         public carcharhinusGalapagensis(string name) : base(name)
        {
            
        }

        public static string Galapagos = "I live in near the Galapagos Islands";


         public void SwimFast()
        {
        System.Console.WriteLine("Warp Speed!");
        }
       
       


            

    }
}