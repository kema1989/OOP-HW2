using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOP_HW2
{
    class Helicopter
    {
        private Type type;
        private int ownerAge;
        private int weightLift;
        private int fuel;
        private int mileage;
        private int price;//тыщ долларов США
        public int OwnerAge
        {
            get { return ownerAge; }
            private set
            {
                if(value < 21 && value > 60)
                {
                    Console.WriteLine("Летать на вертолете могут только люди от 21 до 60 лет");
                }
                else
                {
                    ownerAge = value;
                }
            }
        }
        public int Fuel
        {
            get { return fuel; }
            set
            {
                if (value < 50 && value > 500)
                {
                    Console.WriteLine("Заправляться можно только от 50 до 500 литрами");
                }
                else
                {
                    fuel = value;
                }
            }
        }

        private int WeightLift
        {
            get { return weightLift; }
            set
            {

            }
        }

        public Helicopter(string destination)
        {
            
        }

        public Helicopter(Type type)
        {
            switch (type)
            {
                case Type.New:
                    fuel = 0;
                    mileage = 0;
                    price = 250;
                    break;
                case Type.Used:
                    fuel = 1000;
                    mileage = 5000;
                    price = 120;
                    break;
                case Type.SuperOld:
                    fuel = 500;
                    mileage = 12000;
                    price = 50;
                    break;
            }
        }
        public virtual void GetFuel(int fuel)
        {
            this.Fuel += fuel;
            Console.WriteLine($"Вы заправились на {fuel} литров");
        }

        public virtual void TravelTo(Destinations destination)
        {
            Console.WriteLine("");
            switch (destination)
            {
                case Destinations.CholponAta:
                    mileage += 250;
                    fuel -= 50;
                    Thread.Sleep(2000);
                    break;
                case Destinations.Almaty:
                    mileage += 400;
                    fuel -= 80;
                    Thread.Sleep(3000);
                    break;
                case Destinations.Moscow:
                    mileage += 3000;
                    fuel -= 600;
                    Thread.Sleep(6000);
                    break;
                case Destinations.Paris:
                    mileage += 5000;
                    fuel -= 1000;
                    Thread.Sleep(9000);
                    break;
            }

            if(fuel < 0)
            {
                Console.WriteLine("Вы неправильно расчитали топливо, и поэтому не смогли долететь и разбились.\nВ следующей жизни будьте осторожнее");
                fuel += 1000;
            }
            if(mileage > 20000)
            {
                Console.WriteLine("Ваш вертолет устарел ");
            }
        }

        public void Repair()
        {

        }

        public void Sell(int yourPrice)
        {

        }

    }

    public enum Destinations
    {
        CholponAta,
        Almaty,
        Moscow,
        Paris
    }

    public enum Type
    {
        New,
        Used,
        SuperOld
    }
}
