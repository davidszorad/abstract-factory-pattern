using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Structural
{
    /// <summary>
    /// The 'AbstractProductA' abstract class
    /// </summary>
    abstract class AbstractProductA
    {
    }

    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }


    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    class ProductA1 : AbstractProductA
    {
    }

    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }

    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    class ProductA2 : AbstractProductA
    {
    }

    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}
