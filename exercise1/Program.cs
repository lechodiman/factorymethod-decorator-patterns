using System;
using System.Collections.Generic;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Number of iterations?: ");
            int numberOfIterations = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine($"Number of Iterations: {numberOfIterations}");
            Simulate(numberOfIterations);
        }

        public static void Simulate(int numberOfIterations)
        {
            var clientFactory = new UniformClientFactory();
            for (int i = 0; i < numberOfIterations; i++)
            {
                SimulateIteration(clientFactory);
            }
        }

        public static void SimulateIteration(UniformClientFactory clientFactory)
        {
            Random random = new Random();
            var numberOfClients = random.Next(11);
            for (int i = 0; i < numberOfClients; i++)
            {
                SimulateOrder(clientFactory);
            }
        }

        public static void SimulateOrder(UniformClientFactory clientFactory)
        {
            var client = clientFactory.CreateClient();
            var random = new Random();
            var combosOptions = new List<Order>
            {
                new OrderA(),
                new OrderB(),
                new OrderC(),
                new OrderD(),
                new OrderE(),
                new OrderF()
            };
            var order = combosOptions[random.Next(combosOptions.Count)];
            if (client.WantsBigCombo())
            {
                order = new BigComboDecorator(order);
            }
            if (client.WantsExtraCheese())
            {
                order = new ExtraCheeseDecorator(order);
            }
            if (client.WantsExtraMeat())
            {
                order = new ExtraMeatDecorator(order);
            }
            if (client.WantsNoVegetables())
            {
                order = new NoVegetablesDecorator(order);
            }
            if (client.WantsSauce())
            {
                if (client.WantsBBQ())
                {
                    order = new BBQDecorator(order);
                }
                else
                {
                    order = new BitterSweetSauceDecorator(order);
                }
            }
            if (client.WantsDessert())
            {
                if (client.WantsIceCream())
                {
                    order = new IceCreamDecorator(order);
                }
                else
                {
                    order = new ApplePieDecorator(order);
                }
            }

            Console.Write($"{client.GetDescription()} ordena ");
            Console.WriteLine(order.GetDescription());
        }

    }
}
