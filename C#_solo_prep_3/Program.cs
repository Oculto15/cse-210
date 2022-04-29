Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 100);

int guess = 0;

while (number != guess)
{
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());
    if (number < guess){
    Console.WriteLine("Lower");
}
    else if (number > guess){
    Console.WriteLine("Grater");
}}

Console.WriteLine("You guessed it!");

