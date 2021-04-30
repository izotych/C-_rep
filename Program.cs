using System;

namespace FirstApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введи длину массива");
            var cap = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи номер элемента, который хочешь узреть");
            var elementNumber = int.Parse(Console.ReadLine());

            Array mass = new(cap);
            mass.Add(1);
            mass.Add(2);
            mass.Add(3);
            mass.Add(4);
            mass.ShowMass();
            //mass.Add(10,2);
            Console.WriteLine("next");
            //mass.RemoveRange(1, 2); // проблемы при маленьких массивах
            mass.AddRange(7, 3);
            mass.ShowMass();
            mass.ShowCount();
            mass.ShowElementInMass(elementNumber);


            /*mass.ShowMass();
            mass.Remove(2);
            mass.ShowMass();
            mass.ShowCount();*/
            /*mass.Add(4, 3);
            Console.WriteLine("next");
            mass.ShowMass();*/


            //Console.WriteLine(mass.Capacity());
            

            
        }
        
    }

    class Array
    {
        public int[] data;

        public Array(int cap)
        {

            data = new int[cap];
            Count = 0;
        }

        public void ShowElementInMass(int index)
        {
            if (index > data.Length - 1)
            {
                Console.WriteLine("Индекс находится за пределами массива");
            }
            Console.WriteLine(data[index]);
        }

        public void ShowMass()
        {
            string array = "[";
            for (var i = 0; i < data.Length; i++)
            {
                array += data[i];
                array += ",";
            }
            array += "]";
            Console.WriteLine(array);
        }
        
        public void ShowCount()
        {
            Console.WriteLine(Count);
        }
        public void AddRange(int value, int range)
        {
            if (Count >= data.Length || Count + range > data.Length)
            {
                int[] dataAdd = new int[Count + range];

                for (var i = 0; i < Count; i++)
                {                
                        dataAdd[i] = data[i];
                }
                for (var i = 0; i < range; i++)
                {
                    dataAdd[Count + i] = value;

                }

                data = dataAdd;
            }
            else
            {
                for (var i = 0; i < range; i++)
                {
                    data[Count + i] = value;
                    
                }
            }
            Count += range;
        }
        public void Add(int value)
        {
            //добавление элемента в конец массива
            if (Count >= data.Length)
            {
                int[] dataAdd = new int[data.Length + 1];

                for (var i = 0; i < Count; i++)
                    dataAdd[i] = data[i];
                data = dataAdd;
                
            }
            data[Count] = value;
            Count++;
        }
        public void Add(int value, int index)
        {
            if (index > data.Length - 1)
            {
                Console.WriteLine("массив узкий");
                return;
            }
            if (Count >= data.Length || index <= Count -1)
            {
                int[] dataAdd = new int[data.Length +1];
                for (var i = 0; i < Count + 1; i++)
                {
                    if (i < index)
                    {
                        dataAdd[i] = data[i];
                    }
                    else if (i > index)
                    {
                        dataAdd[i] = data[i - 1];
                    }
                    else
                    {
                        dataAdd[index] = value;
                    }
                    
                }
                data = dataAdd;
            }
            else
            {
                data[index] = value;
            }
            Count++;


        }
        public void RemoveRange(int index, int range)
        {// проблемы при маленьких массивах
            int[] dataRemoveRange = new int[data.Length];
            for (var i = 0; i < Count - range; i++)
            {
                if (i < index)
                {
                    dataRemoveRange[i] = data[i];
                }
                else if (i >= index)
                {
                    dataRemoveRange[i] = data[i + range];
                }

            }
            data = dataRemoveRange;
            Count -= range;
        }
        public void Remove(int index)
        {
            int[] dataRemove = new int[data.Length];
            for (var i = 0; i < Count; i++)
            {
                if (i < index)
                {
                    dataRemove[i] = data[i];
                }
                else if (i >= index)
                {
                    dataRemove[i] = data[i + 1];
                }

            }
            data = dataRemove;
            Count--;
        }
        public int Count { get; set; }
        public int Capacity()
        {
            return data.Length;
        }

    }

}