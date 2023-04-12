int number = 5;

while(true)
{
    Console.Write("Enter a guess:");
    int guess = int.Parse(Console.ReadLine());

    //using if
    if(guess==number){
        Console.WriteLine("You guessed the number!");
        break;
    } else {
        Console.WriteLine("Nope, that is not the number. Try again!");
    }
}

