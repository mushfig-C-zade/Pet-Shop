namespace Task_Done.Main;

public class PetShop
{
    public PetShop()
    {
        Cats = new[] {
            new Cat("Mestan",3,"Male",30,3000,1),
            new Cat("Mesi",3,"Male",30,3000,1)
        };

        Fishes = new[]{
            new Fish("F1",3,"Male",30,3000,1),
            new Fish("F2",3,"Male",30,3000,1),
            new Fish("F3",3,"Male",30,3000,1)
        };

        Birds = new[]
        {
            new Bird("B1",3,"Male",30,3000,1),
            new Bird("B2",3,"Male",30,3000,1),
            new Bird("B3",3,"Male",30,3000,1),
            new Bird("B",3,"Male",30,3000,1)
        };

        Dogs = new[]
        {
            new Dog("D1",3,"Male",30,3000,1),
            new Dog("D2",3,"Male",30,3000,1),
            new Dog("D1",3,"Male",30,3000,1),
            new Dog("D2",3,"Male",30,3000,1),
            new Dog("D3",3,"Male",30,3000,1),
            new Dog("D4",3,"Male",30,3000,1)
        };
    }

    public Cat[] Cats { get; private set; }
    public Fish[] Fishes { get; private set; }
    public Bird[] Birds { get; private set; }
    public Dog[] Dogs { get; private set; }


    public void AddCat(Cat cat)
    {
        Cat[] tmp = new Cat[Cats.Length + 1];

        for (int i = 0; i < tmp.Length - 1; i++)
        {
            tmp[i] = Cats[i];
        }

        tmp[^1] = cat;

        Cats = tmp;
    }

    public void AddFish(Fish fish)
    {
        Fish[] tmp = new Fish[Fishes.Length + 1];

        for (int i = 0; i < tmp.Length - 1; i++)
        {
            tmp[i] = Fishes[i];
        }

        tmp[^1] = fish;

        Fishes = tmp;
    }

    public void AddDog(Dog dog)
    {
        Dog[] tmp = new Dog[Dogs.Length + 1];

        for (int i = 0; i < tmp.Length - 1; i++)
        {
            tmp[i] = Dogs[i];
        }

        tmp[^1] = dog;

        Dogs = tmp;
    }

    public void AddBird(Bird bird)
    {
        Bird[] tmp = new Bird[Birds.Length + 1];

        for (int i = 0; i < tmp.Length - 1; i++)
        {
            tmp[i] = Birds[i];
        }

        tmp[^1] = bird;

        Birds = tmp;
    }

    public void Info()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is Dog");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (Dog dog in Dogs)
        {
            Console.WriteLine(dog);
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is Fish");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (Fish fish in Fishes)
        {
            Console.WriteLine(fish);
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is Cat");
        Console.ForegroundColor = ConsoleColor.Gray;
        ShowsAllCats();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is Bird");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (Bird bird in Birds)
        {
            Console.WriteLine(bird);
        }
    }

    public void ShowsAllCats()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is Cat");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (Cat cat in Cats)
        {
            Console.WriteLine(cat);
        }
    }
    public void dogInfo()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is Dog");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (Dog dog in Dogs)
        {
            Console.WriteLine(dog);
        }
    }

    public void fishInfo()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is Fish");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (Fish fish in Fishes)
        {
            Console.WriteLine(fish);
        }
    }

    public void birdInfo()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is Bird");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (Bird bird in Birds)
        {
            Console.WriteLine(bird);
        }
    }


}
