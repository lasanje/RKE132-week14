Console.WriteLine("Name your dog");
string myDogName = Console.ReadLine();

Dog mydog = new Dog(myDogName);
Dog neigouboursdog = new Dog("Good girl");
Console.WriteLine($"My dog name is {mydog.Name}");
Console.WriteLine($"My neighbours dog name is {neigouboursdog.Name}");


mydog.Rename("Bad Boy");
while (mydog.LevelOfHapiness != 5)
{
    mydog.Bark();
}

mydog.WagTail();

class Dog
{
    private string _name;
    private int _levelOfHapiness;

    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has beed renamed to: {newName}");
    }
    public void Bark()
    {
        Console.WriteLine("woof-woof");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("woggle-wiggle");
    }
}

