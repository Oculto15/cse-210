// See https://aka.ms/new-console-template for more information
Console.Write("what is you grade percentage? ");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);
string letter = "";

if (number >= 90)
{
    letter = "A";
}
else if (number >= 80)
{
    letter = "B";
}
else if (number >= 70)
{
    letter = "C";
}
else if (number >= 60)
{
    letter = "D";
}
else
{
    letter = "F";
}

Console.WriteLine($"Your grade is {letter}");


if (number >= 70)
{
    Console.WriteLine("Congratulations, you pass the class!");
}
else
{
    Console.WriteLine("Don't worry, you can do it next time!");
}