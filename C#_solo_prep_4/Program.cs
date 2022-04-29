using System.Collections.Generic;

Console.WriteLine("Enter a list of numbers, type 0 when finished.");

List<int> numbers = new List<int>();
int input_num = -1;

while (input_num != 0)
{
    Console.Write("Enter number: ");
    string response = Console.ReadLine();
    input_num = int.Parse(response);
                
    numbers.Add(input_num);
}


int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine($"The sum is: {sum}");

int Length = numbers.Count -1;
float average = sum/ Length;

Console.WriteLine($"The average is: {average}");

int largest_num = numbers[0];

foreach (int number in numbers)
{
    if( number > largest_num){
        largest_num = number;
    }
}
Console.WriteLine($"The largest number is: {largest_num}");

int smallest_num = numbers[0];

foreach (int number in numbers)
{
    if( number <= smallest_num){
        smallest_num = number;
    }
}
Console.WriteLine($"The smallest number is: {smallest_num}");

numbers.Sort();
numbers.Reverse();
numbers.ForEach(Console.WriteLine);