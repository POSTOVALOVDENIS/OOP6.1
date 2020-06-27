using System;

namespace OOP6._1
{
    class num
    {
        private int odin;
        private int dva;
        public num()
        {
        }
        public num(int pervoe)

        {
            odin = pervoe;
        }
        public num(int pervoe, int vtoroe)
        {
            odin = pervoe;
            dva = vtoroe;
        }
        public void Display()
        {
            Console.WriteLine($"{odin} {dva}");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            num Numbers = new num();
            Numbers.Display();
            num Num1 = new num(666);
            Num1.Display();
            num Num2 = new num(777, 777);
            Num2.Display();
            
            Console.ReadLine();
         
        }
    }
}
