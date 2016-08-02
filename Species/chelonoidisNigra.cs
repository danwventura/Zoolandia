

namespace zoolandia
{
    

    public class chelonoidisNigra : chelonoidis, IMoveSlowly
    {
        public chelonoidisNigra(string name, string commonname) : base(name, commonname)
        {
            
        }

        public chelonoidisNigra(string name) : base(name)
        {
            
        }

        public void MoveSlowly()
        {
            System.Console.WriteLine("I move slower than a snail across cold molasses");
        }

       
       


            

    }
}