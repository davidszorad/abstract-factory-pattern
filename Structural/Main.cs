using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Structural
{
    /*
    This structural code demonstrates the Abstract Factory pattern creating parallel hierarchies of objects. 
    Object creation has been abstracted and there is no need for hard-coded class names in the client code.
    
    OUTPUT:
    ProductB1 interacts with ProductA1
    ProductB2 interacts with ProductA2
    */

    /// <summary>
    /// Main startup class for Structural
    /// Abstract Factory Design Pattern.
    /// </summary>
    class Main
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void MainMethod()
        {
            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
