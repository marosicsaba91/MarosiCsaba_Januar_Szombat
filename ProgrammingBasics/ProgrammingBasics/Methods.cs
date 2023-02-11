// WriteCounting(10);
// WriteCounting(5);
// WriteCounting(16);

WriteFirstNPrime(10);
WriteFirstNPrime(100);
WriteFirstNPrime(1000);


float Abs(float input) 
{
    if (input < 0)
        input = input * -1;
    
    return input;
}

void WriteCounting(int n) 
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i);
    }
}

bool IsPrime(int number) 
{
    for (int i = 2; i <= number / 2; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}

void WriteFirstNPrime(int n) 
{
    int found = 0;

    for (int i = 2; found < n; i++)
    {
        if (IsPrime(i))
        {
            found++;
            Console.WriteLine(found + " " +i);
        }
    }
}