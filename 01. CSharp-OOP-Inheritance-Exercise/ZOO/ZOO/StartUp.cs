using System;

namespace Zoo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear("Pesho");
            Console.WriteLine(bear.Name);
            Console.WriteLine(new Gorilla("Gosho").Name);
            Console.WriteLine(new Snake("Ivan").Name);
            Console.WriteLine(new Reptile("Misho").Name);
        }
    }
}
