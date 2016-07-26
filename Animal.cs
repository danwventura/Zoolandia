
namespace zoolandia
{
    



    public abstract class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }

        public Animal(string name, string commonname)
        {
            this.Name = name;
            this.CommonName = commonname;
            
        }

        
        public string Name {get; set;}

        public string CommonName {get; set;}
        
        //return a string for concatenation --> base.GetToothCount return a string from base and concatenate with override method
        public virtual string GetToothCount(int numOfTeeth)
        {
        
            return "teeth";
        }
        

    }
}