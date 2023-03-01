
int sum = Add(5,10);
Console.WriteLine(sum);


sum = Add(20000000,1000);
Console.WriteLine(sum);

Console.WriteLine(Add(1,1));

PrintHelloWorld();

GreetThePerson("Erik");
GreetThePerson("Eric");
GreetThePerson("Osman");
GreetThePerson("Justin");

//here are some methods you have already used
/***
tryParse()
ToLower()
ToUpper()
Console.Write()
Console.WriteLine() ... gasp!!!
**/


/**
This method takes two numbers, add them up and return the results
**/
int Add(int number1, int number2)
{
    int result = number1+ number2;

    return result;
}

/**
This method prints hello world to the console
**/
void PrintHelloWorld()
{
    Console.WriteLine("Hello World");
}


/**
This method greets a person base on their name
**/
void GreetThePerson(string name)
{
    Console.WriteLine($"Hello {name}\n. I am Jarvis. I will be your AI for today");
}
