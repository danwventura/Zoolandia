namespace zoolandia
{

    public class chelonoidis : Animal

    {

        public readonly string Genus = "chelonoidis";

        public chelonoidis(string name, string commonname) : base(name, commonname)
        {

        }

        public chelonoidis(string name) : base(name)
        {
            
        }

        public override string GetToothCount(int numOfTeeth)
        {
            var animalTeeth = base.GetToothCount(3);
            return numOfTeeth + " " + animalTeeth;
        }


        public static string EatPlants = "I eat plants";

        public virtual string LayEggs(int numOfEggs)
        {
            return "I lay " + numOfEggs + " eggs in the sand.";
        }
    }





}

