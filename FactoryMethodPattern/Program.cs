using FactoryMethodPattern.Examples;
using System;
using System.Collections.Generic;

namespace FactoryMethodPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            //RealLife Example
            //ExecuteRealLifeExample();

            // Example 1
            //ExecuteExample1();

            // Example 3
            //ExecuteExample3();

            //Problem 2
            //ExecuteProblem2FactoryPattern();

            //Problem 2 Solution
            ExecuteProblem2Solution();

            Console.ReadKey();
        }
        static void ExecuteExample1()
        {
            // An array of creators

            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }
        }

        static void ExecuteRealLifeExample()
        {
            // Note: constructors call Factory Method

            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }

        static void ExecuteExample3()
        {
            List<CardFactory> cardList = new List<CardFactory>
            {
                new MoneyBackFactory(5000, 0),
                new TitaniumFactory(5000, 500),
                new PlatinumFactory(5000, 1000)
            };

            Console.WriteLine("\nYour card details are below : \n");
            cardList.ForEach(x => PrintDetails(x));
        }
        static void PrintDetails(CardFactory factory)
        {
            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.WriteLine();
        }

        static void ExecuteProblem2FactoryPattern()
        {
            Honda objHonda = new Honda();
            objHonda.GetCarModel();

            BMW objBMW = new BMW();
            objBMW.GetCarModel();

            // If we want to add new class then we need to modify client code also.
            Nano objNano = new Nano();
            objNano.GetCarModel();
        }
        static void ExecuteProblem2Solution()
        {
            ICarSupplier cs1 = CarFactory.GetCarInstance(0);
            ICarSupplier cs2 = CarFactory.GetCarInstance(1);
            ICarSupplier cs3 = CarFactory.GetCarInstance(2);
            ICarSupplier cs4 = CarFactory.GetCarInstance(3);

            List<ICarSupplier> carSuppliers = new List<ICarSupplier> { cs1, cs2, cs3, cs4 };

            carSuppliers.ForEach(x=> {
                x.GetCarModel();
                Console.WriteLine("And Coloar is " + x.CarColor);
                Console.WriteLine();
            });
            
        }
    }
}
