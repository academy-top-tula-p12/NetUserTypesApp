using NetUserTypesApp;

Company yandex = new() { Title = "Yandex" };
Person tom = new() { Name = "Tom", 
                     Age = 28, 
                     Company = yandex };

Person sam = new() { Name = "Sam", 
                     Age = 31,
                     Company = new() { Title = "Ozon" }
                    };


Account acc1 = new() { Login = "Bobby_user", Code = 123 };
Account acc2 = new() { Login = "Bobby_user", Code = 123 };
Account acc3 = acc1;

Console.WriteLine(acc1.Equals(acc3));
Console.WriteLine(acc1.Equals(acc2));


void ClassOneExample()
{
    Employee employee = new() { Name = "Sammy", Age = 25 };
    employee.Print();

    Employee bob = new("Bob", 36);
    Employee anonim25 = new(25);
    Employee Tom0 = new("Tom");
    Employee anonim0 = new();

    Employee leo = new("Leo", 28);
    Employee leo2 = leo;

    //leo.Print();
    //leo2.Print();

    //leo2.Name = "Leopold";

    //leo.Print();
    //leo2.Print();

    Employee leo3 = new("Leo", 28);

    Console.WriteLine(leo.Equals(leo2));
    Console.WriteLine(leo.Equals(leo3));

    User user = new("User1", 55);
    user.Print();
}

void StructExample()
{
    UserAccount account = new UserAccount();
    account.name = "Bob";
    account.age = 34;
    account.Print();

    UserAccount user = account;
    user.name = "Sam";
    user.Print();
    account.Print();

    UserAccount tom = new UserAccount("Tom", 25);
    UserAccount leo = new UserAccount() { name = "Leo", age = 33 };

    var joe = new UserAccount();
    UserAccount ron = new() { name = "Ron", age = 41 };

    UserAccount tim = tom with { name = "Tim" };

    Console.WriteLine(account.Equals(user));
}

void EnumExample()
{
    WayType way;
    way = WayType.Bottom;

    way = WayType.Left;


}

enum WayType
{
    Left = 10,
    Right,
    Top = 10,
    Bottom
}

struct UserAccount
{
    public string name;
    public int age;

    public UserAccount() : this("Anomim", 1)
    {
        //this.name = "Anonim";
        //this.age = 1;
    }

    public UserAccount(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Print()
    {
        Console.WriteLine(name);
    }
}

