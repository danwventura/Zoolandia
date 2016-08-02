namespace zoolandia
{
    public class carcharhinusBrevipinna : carcharhinus, ISwimFast
    {
        public carcharhinusBrevipinna(string name, string commonname) : base(name, commonname)
         {
             System.Console.WriteLine(this.Name);
             System.Console.WriteLine(this.CommonName);

         }

         public carcharhinusBrevipinna(string name) : base(name)
        {
            
        }


        public static string SpinningLeap = "When I hunt I use a spinning leap to catch my prey";

         public void SwimFast()
        {
        System.Console.WriteLine("Warp Speed!");
        }

    }
}