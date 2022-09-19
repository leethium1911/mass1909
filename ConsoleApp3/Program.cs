using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[25];
            
            Random rnd = new Random();
            //array[0] = 59;
            //array[1] = rnd.Next(-500, 99999);
            //array[2] = rnd.Next(-500, 99999);
            //array[3] = rnd.Next(-500, 99999);

            Console.WriteLine($"Элементов в массиве: - {array.Length}");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}


            

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 20);
                Console.WriteLine(array[i]);            

            }
            int c = 1;
            for (int i = 0; i < array.Length; i++)
            {
                c *= array[i];
            }

            Console.WriteLine("Произведение = " + c);

            Console.ReadLine();
            
        }
    }
}
