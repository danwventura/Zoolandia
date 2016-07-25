
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
        
        
        public virtual int GetToothCount(int numOfTeeth)
        {
        
            return 0;
        }
        

    }
}