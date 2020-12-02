using System;
using HungryNinja.Model;


namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet ciciPizza = new Buffet();
            Ninja sebastian = new Ninja();

            while (sebastian.Full == false)
            {
                sebastian.Eat(ciciPizza.Serve());
            }
        }
    }
}
