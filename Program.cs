using System;

namespace W5LP
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>(); // Our list

            Console.WriteLine("Bir araba üretmek ister misiniz? İstiyorsanız 'e' istemiyorsanız 'h' tuşlamanız yeterli");
            char userChoose;
            bool isValidChoose = char.TryParse(Console.ReadLine(), out userChoose);

            if (isValidChoose)
            {
                if (userChoose == 'e')
                {
                    CarMakingLine:  // For goto command

                    Car newCar = new Car();
                    newCar.ProductDate = DateTime.Now;

                    Console.WriteLine("Lütfen arabanın ismini girin:");
                    newCar.ProductId = Console.ReadLine();

                    Console.WriteLine("Lütfen arabanın marka ismini girin:");
                    newCar.ProductBrandName = Console.ReadLine();

                    Console.WriteLine("Lütfen arabanın modelini girin:");
                    newCar.ProductModel = Console.ReadLine();

                    Console.WriteLine("Lütfen arabanın rengini girin:");
                    newCar.ProductColor = Console.ReadLine();

                    DoorNumberRetry:

                    Console.WriteLine("Lütfen arabanın kapı sayısını girin:");
                    int doorNumber;
                    while (!int.TryParse(Console.ReadLine(), out doorNumber))
                    {
                        Console.WriteLine("Hatalı giriş!");
                        goto DoorNumberRetry;
                    }
                    if (doorNumber != 4 && doorNumber != 2) // Looking for 2 or 4 door amount
                    {
                        Console.WriteLine("Hatalı giriş! Kapı sayısı yalnızca 2 veya 4 olabilir.");
                        goto DoorNumberRetry;
                    }
                    else
                    {
                        newCar.ProductDoorNumber = doorNumber;
                    }


                    Console.WriteLine("\n Üretilen Araba:");
                    Console.WriteLine(newCar.ToString());

                    cars.Add(newCar);

                    Console.WriteLine("Başka araç üretmek için 'e' üretmemek için 'h' diyebilirsiniz");
                    char userSecondChoose = Convert.ToChar(Console.ReadLine());

                    if (userSecondChoose == 'e')
                    {
                        goto CarMakingLine;
                    }
                    else if (userSecondChoose == 'h')
                    {
                        Console.WriteLine("Araba üretimi yapılmadı!");
                    }
                }
                else if (userChoose == 'h')
                {
                    Console.WriteLine("Araba üretimi yapılmadı!");
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine("Ürettiğiniz araçlar:");
                Console.WriteLine(car);
            }
        }
    }
}