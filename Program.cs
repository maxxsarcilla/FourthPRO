int [] numbersTocheck = {1,2,3,4,5,6,7,8,9,10};

foreach(int number in numbersTocheck)
{
    if (number % 2 == 0)
{
    Console.WriteLine($"Number {number} is even!");
}

    else
{
    Console.WriteLine($"Number {number} is not even!");
}
}