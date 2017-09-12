using System;

namespace AbstractFactoryPattern
{
    /*
    This real-world code demonstrates the creation of different animal worlds for a computer game using different factories. 
    Although the animals created by the Continent factories are different, the interactions among the animals remain the same.  
    
    OUTPUT:
    Lion eats Wildebeest
    Wolf eats Bison
    */

    /// <summary>
    /// MainApp startup class for Real-World
    /// Abstract Factory Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            // Wait for user input
            Console.ReadKey();
        }
    }
}