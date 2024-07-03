using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task.1
public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void Speak();
    public virtual void Move()
    {
        Console.WriteLine($"{Name} is moving.");
    }
}

public class Reptile : Animal
{
    public bool IsColdBlooded { get; set; }

    public Reptile(string name, int age, bool isColdBlooded) : base(name, age)
    {
        IsColdBlooded = isColdBlooded;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} is hissing.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is slithering.");
    }
}

public class Mammal : Animal
{
    public bool HasFur { get; set; }

    public Mammal(string name, int age, bool hasFur) : base(name, age)
    {
        HasFur = hasFur;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} is making a sound.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is walking.");
    }
}

public class Bird : Animal
{
    public bool CanFly { get; set; }

    public Bird(string name, int age, bool canFly) : base(name, age)
    {
        CanFly = canFly;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} is chirping.");
    }

    public override void Move()
    {
        if (CanFly)
        {
            Console.WriteLine($"{Name} is flying.");
        }
        else
        {
            Console.WriteLine($"{Name} is walking.");
        }
    }
}

public class Fish : Animal
{
    public bool IsFreshWater { get; set; }

    public Fish(string name, int age, bool isFreshWater) : base(name, age)
    {
        IsFreshWater = isFreshWater;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} is bubbling.");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is swimming.");
    }
}

public class Bear : Mammal
{
    public string Color { get; set; }

    public Bear(string name, int age, bool hasFur, string color) : base(name, age, hasFur)
    {
        Color = color;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} is growling.");
    }
}

public class Frog : Reptile
{
    public string Species { get; set; }

    public Frog(string name, int age, bool isColdBlooded, string species) : base(name, age, isColdBlooded)
    {
        Species = species;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} is croaking.");
    }
}

public class Dolphin : Mammal
{
    public bool IsFriendly { get; set; }

    public Dolphin(string name, int age, bool hasFur, bool isFriendly) : base(name, age, hasFur)
    {
        IsFriendly = isFriendly;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} is clicking.");
    }
}

public class Carp : Fish
{
    public string Color { get; set; }

    public Carp(string name, int age, bool isFreshWater, string color) : base(name, age, isFreshWater)
    {
        Color = color;
    }
}

public class Eagle : Bird
{
    public int WingSpan { get; set; }

    public Eagle(string name, int age, bool canFly, int wingSpan) : base(name, age, canFly)
    {
        WingSpan = wingSpan;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} is screeching.");
    }
}

//Task2
public class Zoo
{
    private List<Animal> animals;

    public Zoo()
    {
        animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void RollCall()
    {
        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.Name}, Age: {animal.Age}");
            animal.Speak();
            animal.Move();
        }
    }
}

public class Program
{
    public static void Main()
    {
        Zoo zoo = new Zoo();

        zoo.AddAnimal(new Bear("Yogi", 5, true, "Brown"));
        zoo.AddAnimal(new Frog("Kermit", 2, true, "Tree Frog"));
        zoo.AddAnimal(new Dolphin("Flipper", 7, false, true));
        zoo.AddAnimal(new Carp("Goldie", 1, true, "Gold"));
        zoo.AddAnimal(new Eagle("Baldy", 4, true, 7));

        zoo.RollCall();
    }
}
