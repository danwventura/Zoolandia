
namespace zoolandia


{
public class carcharodon : Animal 
    {
    public readonly string Genus = "carcharodon";

        public carcharodon(string name, string commonname) : base(name,commonname)
        {
            
        }

        public carcharodon(string name) : base (name)
        {
            
        }

        public override string GetToothCount(int numOfTeeth)
        {
            var animalTeeth = base.GetToothCount(3);
            return numOfTeeth + " " + "massive triangular " + animalTeeth;
        }


        public static string MovieStar = "I appear in movies/horror films";
    }
}