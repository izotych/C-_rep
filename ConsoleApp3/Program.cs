using System;
using System.Linq;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.NetworkInformation;






namespace Collections
{
     class Program
    {


        static void Main(string[] args)
        {
            Station Garage = new Station();
            Model Test = new Model();
            Day WorkingDay = new Day();
            Test.WorkingModeling(4, WorkingDay, Garage);

            Garage.ShowCollection();
            
            



            


            



        }

    }  
    public class Model
    {
        
        public void WorkingModeling(int x, Day day, Station Garage)
        {
            for(var dayNumber = 1; dayNumber <= x; dayNumber++)
            {
                day.DayImitation(Garage);
            }
        }
    }
    public class Day
    {
        
        public void DayImitation(Station Garage)
        {
            
            int f = 0;
            var CarArrival = new Random();

            for (var time = 0; time < 12; time++)
            {
                //Случайные события

                if (CarArrival.Next(0, 10) == 7)
                {
                    Garage.AddCar(new Car(87));
                    Console.WriteLine("Машина приехала");


                }

                else if (Garage.GetCount() > 0 && Garage.GimmeCar().State < 100)
                {
                    Garage.WorkingHallFirst.RepairCar(Garage.GimmeCar());
                    
                }

                if (Garage.GetCount() > 0 && Garage.GimmeCar().State == 100)
                {
                    Garage.RemoveCar(Garage.GimmeCar());
                    Console.WriteLine("Починил");
                }
                //Garage.WorkingHallFirst.RepairCar(car1);
            }



        }



    }



    public class Station
    {
        public Queue<Car> inside =  new Queue<Car>();
        Queue<Car> outside = new Queue<Car>();

        public WorkingHall WorkingHallFirst =  new WorkingHall();
        public int GetCount()
        {
            return inside.Count();
        }
        public Collections.Car GimmeCar()
        {
            return inside.Peek();
        }

        public void AddCar(Car car)
        {
            if (inside.Count < 2)
            {
                inside.Enqueue(car);
            }
            else
            {
                outside.Enqueue(car);
            }
        }

        public void RemoveCar(Car car)
        {
            if (car.State == 100)
            {
                inside.Dequeue();
            }
            else
            {
                Console.WriteLine("Поломка не устранена");
            }
        }

        public void ShowCollection()
        {
            foreach (Car c in inside)
            {
                Console.WriteLine($"Поломка: {c.State}%");
            }
        }
        public void ShowOutCollection()
        {
            foreach (Car c in outside)
            {
                Console.WriteLine($"Поломка: {c.State}%");
            }
        }

      

        public class  WorkingHall
        {
            
            public int RepairCar(Car BrokenCar)
            {
                int time = 0;

                BrokenCar.State += 1;
                time += 1;

                return time;
            }
        }
    }
    



    public class Car
    {
        
        public int State;
        public Car(int S)
        {
            
            State = S;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Состояние: {State}%");
        }

    }
}

    
    

