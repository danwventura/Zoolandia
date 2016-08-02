

namespace zoolandia
{
    

    public class sulaNebouxii : sula, IFly 
    {
        public sulaNebouxii(string name, string commonname) : base(name, commonname)
        {
            this.Name = name;
            this.CommonName = commonname;
        }

        public sulaNebouxii(string name) : base(name)
        {
            this.Name = name;
            
        }

        public void Fly()
        {
            System.Console.WriteLine("I am flying!");
        }

            

    }
}