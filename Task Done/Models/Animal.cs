using Task_Done.Exceptions;

namespace Task_Done.Main;

public abstract class Animal
{
    private string nickname;
    private int age;
    private string gender;
    private int energy;
    private int price;
    private int mealQuantity;

    public Animal(string nickname, int age, string gender, int energy, int price, int mealQuantity)
    {
        this.nickname = nickname;
        this.age = age;
        this.gender = gender;
        this.energy = energy;
        this.price = price;
        this.mealQuantity = mealQuantity;
    }

    public override string ToString()
    {
        return $"{nickname} {age} {gender} {energy} {price} {mealQuantity}";
    }
    public string Nickname
    {
        get => nickname;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                nickname = value;
            }
            else
            {
                throw new NicknameIsNullException();
            }
        }
    }
    public int Age
    {
        get => age;
        set
        {
            if (age<0)
            {
                throw new AgeLowerThanZeroException();
            }
            if (age>500)
            {
                throw new AgeUpperThanFiveHundred();
            }
            age=value;            
        }
    }
    public string Gender
    {
        get => gender;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                gender = value;
            }
            else
            {
                throw new GenderIsNullException();
            }
        }
    }
    public int Energy
    {
        get => energy;
        set
        {
            if (energy < 0)
                throw new EnergyLowerThanZeroException();

            if (energy > 100)
                throw new EnergyUpperThanHundredException();

            energy = value;

        }
    }

    public int Price
    {
        get => price;
        set
        {
            if (value >= 0)
            {
                price = value;
            }
            else
            {
                throw new PriceLowerThanZeroException();
            }
        }
    }

    public int MealQuantity
    {
        get => mealQuantity;
        set
        {
            if (mealQuantity<0)
            {
                throw new MealQuantityLowerThanZeroException();
            }
            if (mealQuantity >100)
            {
                throw new MealQuantityUpperThanHundredException();
            }
           mealQuantity = value;
        }
    }

    public void Eat()
    {
        Energy += 10;
        Console.WriteLine("I've eaten.");
    }
    public void Sleep()
    {
        Energy += 30;
        Console.WriteLine("I've sleepless.");
    }
    public void Play()
    {
        Energy -= 20;
        Console.WriteLine("I've Tired.");
    }

}
