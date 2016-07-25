
namespace zoolandia
{
    

    public class carcharodonMegalodon : Animal 
    {
        public carcharodonMegalodon(string name, string commonname) : base(name, commonname){}
            


       
       


            public override int GetToothCount(int numOfTeeth)
        {
            var animalTeeth = base.GetToothCount(3);
            return animalTeeth + numOfTeeth;
        }

        
        
       

        

       

    }
}