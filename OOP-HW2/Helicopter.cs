using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OOP_HW2
{
    class Helicopter : IDisposable
    {
        private Type type;
        private int ownerAge;
        private int fuel;
        private int mileage;
        private int price;//тыщ долларов США
        public int OwnerAge
        {
            get { return ownerAge; }
            private set
            {
                if (value < 21 && value > 60)
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
        

        public int Mileage { get; set; }
        

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
        public virtual void GetFuel()
        {
            int fuel = Convert.ToInt32(Console.ReadLine());
            this.Fuel += fuel;
            Console.WriteLine($"Вы заправились на {fuel} литров");
        }

        public virtual void TravelTo()
        {
            Console.WriteLine("Полететь в Чолпон-Ату - 1, в Алмату - 2, в Москву - 3, в Париж - 4");
            Console.WriteLine("Круто, ожидайте...");
            switch (Console.ReadLine())
            {
                case "1":
                    mileage += 250;
                    fuel -= 50;
                    Thread.Sleep(2000);
                    break;
                case "2":
                    mileage += 400;
                    fuel -= 80;
                    Thread.Sleep(3000);
                    break;
                case "3":
                    mileage += 3000;
                    fuel -= 600;
                    Thread.Sleep(6000);
                    break;
                case "4":
                    mileage += 5000;
                    fuel -= 1000;
                    Thread.Sleep(9000);
                    break;
            }

            if (fuel < 0)
            {
                Console.WriteLine("Вы неправильно расчитали топливо, и поэтому не смогли долететь и разбились.\nВ следующей жизни будьте осторожнее");
                fuel += 1000;
            }
            if (mileage > 20000)
            {
                Console.WriteLine("Ваш вертолет устарел ");
            }
            Console.WriteLine("Прилетели...");
        }

        public void Repair()
        {
            mileage -= 500;
            price += 2000;
        }

        public void Repair(int mileage)
        {
            this.mileage -= mileage;
            price += mileage * 4;
            fuel += 500;
        }

        public void Sell(int yourPrice)
        {
            if(yourPrice > price)
            {
                Console.WriteLine("Вы ждали 100 лет и все равно не продали свою фигню");
            }
            else if(yourPrice < price && yourPrice > 0.6 * price)
            {
                Thread.Sleep(5000);
                Console.WriteLine($"Вы продали свой вертолет за {yourPrice} долларов");
            }
            else
            {
                Console.WriteLine($"Вы продали свой вертолет за {yourPrice} долларов");
            }
        }

        public void Start()
        {
            Console.WriteLine("Путешествовать - 1, заправиться - 2, ремонт - 3, продвинутый ремонт - 4, продать вертолет - 5");
            switch (Console.ReadLine())
            {
                case "1":
                    TravelTo();
                    Start();
                    break;
                case "2":
                    GetFuel();
                    Start();
                    break;
                case "3":
                    Repair();
                    Start();
                    break;
                case "4":
                    Console.WriteLine("Введите кол-во уменьшаемого пробега");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Repair(i);
                    Start();
                    break;
                case "5":
                    Console.WriteLine("Введите желаемую стоимость");
                    int j = Convert.ToInt32(Console.ReadLine());
                    Sell(j);
                    Start();
                    break;
                default:
                    Console.WriteLine("До свидания");
                    break;
            }
        }

        public static void Greetings()
        {
            Console.WriteLine("Хелло, как дела?");
        }

        public void Dispose()
        {
            Console.WriteLine("Deleted!");
        }

        ~Helicopter()
        {
            Console.WriteLine("Deleted!!!");
        }
    }

    //public enum Destinations
    //{
    //    CholponAta,
    //    Almaty,
    //    Moscow,
    //    Paris
    //}

    public enum Type
    {
        New,
        Used,
        SuperOld
    }
}
