
namespace zoolandia
{
    
    public class carcharhinusGalapagensis : Animal 
    {

         public carcharhinusGalapagensis(string name, string commonname) : base(name, commonname){}

       
       


            public override string GetToothCount(int numOfTeeth)
        {
            var animalTeeth = base.GetToothCount(3);
            return numOfTeeth + " " + animalTeeth;
        }

    }
}