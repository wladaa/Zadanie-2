using System;
interface AnimalActions //Definition of the interface "AnimalActions"
{
    void Eat();
    void Sleep();
    void Voice();
    void Move();
}



class Cat: AnimalActions //Implementation of the Cat class
{
    //Functions for the Cat class
    public void Eat()
    {
        Console.WriteLine("The cat is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("The cat is sleeping.");
    }

    public void Voice()
    {
        Console.WriteLine("The cat meows.");
    }

    public void Move()
    {
        Console.WriteLine("The cat jumps.");
    }

    //Two local functions for the Cat class

    public void Scratch()
    {
        Console.WriteLine("The cat is scratching.");
    }

    public void WashesItself()
    {
        Console.WriteLine("The cat washes itself.");
    }
}




class Dog: AnimalActions //Implementation of the Dog class
{
    //Functions for the Dog class
    public void Eat()
    {
        Console.WriteLine("The dog is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("The dog is sleeping.");
    }

    public void Voice()
    {
        Console.WriteLine("The dog is barking.");
    }

    public void Move()
    {
        Console.WriteLine("The dog runs.");
    }

    // Two local functions for the Dog class

    public void Fetch()
    {
        Console.WriteLine("The dog is fetching.");
    }

    public void TailWagging()
    {
        Console.WriteLine("The dog wags his tail.");
    }
}




class Program
{
    static void Main(string[] args)
    {
       
        Cat Cat = new Cat();
        Cat.Eat();
        Cat.Sleep();
        Cat.Voice();
        Cat.Move();
        Cat.Scratch();
        Cat.WashesItself();

        Console.WriteLine();

        Dog Dog = new Dog();
        Dog.Eat();
        Dog.Sleep();
        Dog.Voice();
        Dog.Move();
        Dog.Fetch();
        Dog.TailWagging();
    }
}

