// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;
bool exit = false;
do
{
    try{

        // Calculate the sum of the even numbers between the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the value returned by AverageOfEvenNumbers in the console
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

        }

    catch(ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("An error has occurred.");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The lower bound is {lowerBound} and the upper bound is {upperBound}.");
        Console.WriteLine("Please enter a valid upper bound.");
        string? userResponse = Console.ReadLine();
        if(userResponse.ToLower().Contains("exit"))
        {
            exit = true;
        }
        else
        {
            exit = false;
            upperBound = int.Parse(userResponse);
        }
      
    }
}while(exit == false);  

// Wait for user input
Console.ReadLine();



static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    //Debbugging
    if(lowerBound >= upperBound)
    {
     throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeExxception: The upper bound must be greater than the lower bound.");   
    }
    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
}