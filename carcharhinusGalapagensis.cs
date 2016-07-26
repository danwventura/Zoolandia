
namespace zoolandia
{
    
    public class carcharhinusGalapagensis : Animal 
    {

         public carcharhinusGalapagensis(string name, string commonname) : base(name, commonname)
         {
             this.Name = name;
             this.CommonName = commonname;
         }

         public carcharhinusGalapagensis(string name) : base(name)
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