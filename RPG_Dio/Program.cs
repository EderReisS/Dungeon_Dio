using RPG_Dio.classes;
using RPG_Dio.facede;
using System;

namespace RPG_Dio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            heroi Arus = fcHeroi.montarHeroi("Arus", 1, 31,100);
            heroi Silva = fcHeroi.montarHeroi("Silva", 2, 20,12);
            heroi Bright = fcHeroi.montarHeroi("Bright", 3, 42,121);

            Console.WriteLine(Arus);
            Console.WriteLine(Silva);
            Console.WriteLine(Bright);

            Console.WriteLine(Bright.mostrarStatus());

            Console.WriteLine(fcHeroi.atacar(Arus));
            Console.WriteLine(fcHeroi.atacar(Silva));
            Console.WriteLine(fcHeroi.atacar(Bright));
        }
    }
}
