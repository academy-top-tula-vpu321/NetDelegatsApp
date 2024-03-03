Opers<int> operInt = SumInt;
Opers<float> operFloat = SumFloat;

Console.WriteLine(Calc(10, 20, MultInt));

var o = OperFactrio('+');
Console.WriteLine(o(30, 50));



T Calc<T>(T a, T b, Opers<T> oper)
{
    return oper.Invoke(a, b);
}


Opers<int> OperFactrio(char sign)
{
    if (sign == '+')
        return new Opers<int>(SumInt);
    else
        return new Opers<int>(MultInt);
}

void DelegateWelcome()
{
    PrintMessage print1, print2, print3;
    PrintName printName;

    print1 = PrintHello;
    //print = new PrintMessage(PrintHello);

    //print();

    print2 = new Message().PrintHelloUser;
    //print();

    print3 = print1 + print2;
    print3();


    //printName = PrintHelloName;
    ////printName("Bobby");

    //Message message = new Message();

    //printName += message.PrintHelloUserName;
    //printName.Invoke("Tommy");
    //Console.WriteLine();

    //printName -= PrintHelloName;
    //printName?.Invoke("Billy");

    //printName -= message.PrintHelloUserName;
    //printName?.Invoke("Sammy");
}
void PrintHello()
{
    Console.WriteLine("Hello world");
}
void PrintHelloName(string name)
{
    Console.WriteLine($"Hello {name}");
}

int SumInt(int a, int b) { Console.WriteLine("Sum"); return a + b; }
int MultInt(int a, int b) { Console.WriteLine("Mult"); return a * b; }
float SumFloat(float a, float b) { return a + b; }


class MyMath<T>
{
    public static T Sum(T a, T b) { return a + b; }
}


delegate T Opers<T>(T a, T b);

delegate void PrintMessage();
delegate void PrintName(string name);

class Message
{
    public void PrintHelloUser()
    {
        Console.WriteLine("Hello user");
    }

    public void PrintHelloUserName(string name)
    {
        Console.WriteLine($"Hello user {name}");
    }

}