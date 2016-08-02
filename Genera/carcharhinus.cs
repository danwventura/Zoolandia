namespace zoolandia

{
    public class carcharhinus : Animal

    {
        public readonly string Genus = "carcharhinus";

        public carcharhinus(string name, string commonname) : base(name, commonname)
        {
            
        }

        public carcharhinus(string name) : base(name)
        {
            
        }

        public override string GetToothCount(int numOfTeeth)
        {
            var animalTeeth = base.GetToothCount(3);
            return numOfTeeth + " " + animalTeeth;
        }
    }

}