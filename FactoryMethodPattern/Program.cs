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
            ExecuteExample3();
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
    }
}
