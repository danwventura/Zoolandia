
namespace zoolandia
{
    

    public class carcharodonMegalodon : carcharodon, IFlyingJaws 
    {
        public carcharodonMegalodon(string name, string commonname) : base(name, commonname)
        {
            this.Name = name;
            this.CommonName = commonname;
        }
            
        public carcharodonMegalodon(string name) : base(name)
        {
            this.Name = name;
            
        }

        public void FlyingJaws()
        {
            System.Console.WriteLine("I can fly like a rock!");
        }
       
        public static string Lazarus = "I have come back from extinction!";

        

    
        
       

        

       

    }
}