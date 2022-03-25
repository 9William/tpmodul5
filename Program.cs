using System;


namespace tpmodul5_1302204126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo s = new SayaTubeVideo("Tutorial Design By Contract - Gerry William Mathew Kurniawan");
            s.PrintVideoDetails();
            s.IncreasePlayCount(3);
            s.PrintVideoDetails();
        }
    }
}
