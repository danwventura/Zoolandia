
namespace zoolandia
{
    

    public class carcharodonMegalodon : Animal 
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

       
       


            public override string GetToothCount(int numOfTeeth)
        {
            var animalTeeth = base.GetToothCount(3);
            return numOfTeeth + " " + animalTeeth;
        }

        
        
       

        

       

    }
}