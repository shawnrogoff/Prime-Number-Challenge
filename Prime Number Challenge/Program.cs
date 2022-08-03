
List<int> testInputs = new() { 1,2,3,4,5,6,7,8,9,10,11,12,13 };

foreach (var input in testInputs)
{
    bool numberIsPrime;

    numberIsPrime = CheckIfNumberIsPrime(input);

    if (numberIsPrime)
    {
        Console.WriteLine($"The number {input} is prime.");
        Console.WriteLine("Prime numbers have no factors.");
    }
    else
    {
        Console.WriteLine($"The number {input} is NOT prime.");

        List<int> factors = GetFactors(input);
        Console.WriteLine($"The number of factors is {factors.Count}.");
        if (factors.Count > 0)
        {
            Console.Write($"They are: ");
            foreach (var factor in factors)
                Console.Write($"{factor} ");

            Console.WriteLine();
            List<int> primeFactors = GetPrimeFactors(factors);
            Console.WriteLine($"The number of prime factors is {primeFactors.Count}.");
            if (primeFactors.Count > 0)
            {
                Console.Write($"They are: ");
                foreach (var primeFactor in primeFactors)
                    Console.Write($"{primeFactor} ");
            }

            Console.WriteLine();
        }
    }
    Console.WriteLine("===================================================");
}

Console.ReadKey();


bool CheckIfNumberIsPrime(int input)
{
    List<bool> numberIsPrimeResults = new();

    if (input == 1)
        return false;

    for (var i = 2; i < input; i++)
    {
        if (input % i == 0)
            numberIsPrimeResults.Add(false);
        else
            numberIsPrimeResults.Add(true);
    }

    if (numberIsPrimeResults.Contains(false))
        return false;
    else
        return true;
}

List<int> GetFactors(int input)
{
    List<int> factors = new();
    for (var i = 2; i < input; i++)
    {
        if (input % i == 0)
            factors.Add(i);
    }
    return factors;
}

List<int> GetPrimeFactors(List<int> inputs)
{
    List<int> primeFactors = new();
    foreach (var input in inputs)
    {
        if (CheckIfNumberIsPrime(input))
            primeFactors.Add(input);
    }
    return primeFactors;
}