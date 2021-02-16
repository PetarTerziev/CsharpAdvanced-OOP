using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("25");
            list.Add("-55");
            list.Add("1001");
            list.Add("-555555");


            Console.WriteLine(list.Count);
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.Count);

        }
    }
}
