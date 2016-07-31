namespace zoolandia
{

    public class sula : Animal
    {
        public readonly string Genus = "sula";

        public sula(string name, string commonname) : base(name, commonname)
        {

        }

        public sula(string name) : base(name) 
        {
            
        }


        public override string GetToothCount(int numOfTeeth)
        {
            var animalTeeth = base.GetToothCount(3);
            return numOfTeeth + " " + animalTeeth;
        }



        public static string LayEggs = "I lay a few eggs on the sand";
    }
}