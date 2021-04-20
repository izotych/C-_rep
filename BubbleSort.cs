using System;
namespace Kata_sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 2, 1, 3, 4, 5};
            
            Sort(array);
            Read(array);
        }

        public static void Sort(int[] mass)
        {
            int Sas = 0;
            int temp;
            bool swap;
            for (int j = 0; j < mass.Length; j++)
            {
                swap = false;
                // При каждом обмене, мы должны меньше раз пробегать по массиву
                for (int i = 0; i < mass.Length - 1 - j; i++)
                {
                    
                    if (mass[i] > mass[i + 1])
                    {
                        temp = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = temp;
                        swap = true;
                    }
                    Sas += 1;
                   
                }
                if (!swap)
                {
                    break;
                }
            }
            Console.WriteLine(Sas + " раз прошли по членам массива");
        }
        public static void Read(int[] mass)
        {
            foreach(int elem in mass)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
