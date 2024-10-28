namespace ArtifactToDocument;


public class MyMathLibrary
{
    public double CalculateMedian(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            throw new ArgumentException("The list cannot be empty.");
        }

        var sortedNumbers = numbers.OrderBy(n => n).ToList();
        int count = sortedNumbers.Count;
        if (count % 2 == 0)
        {
            return (sortedNumbers[count / 2 - 1] + sortedNumbers[count / 2]) / 2.0;
        }

        return sortedNumbers[count / 2];
    }

    public int CalculateSum(List<int> numbers)
    {
        return numbers.Sum();
    }

    public double CalculateAverage(List<int> numbers)
    {
        if (!numbers.Any())
        {
            throw new ArgumentException("The list cannot be empty.");
        }

        return numbers.Average();
    }

    public List<int> GetPrimeNumbers(int limit)
    {
        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }

        return primes;
    }

    private bool IsPrime(int number)
    {
        if (number < 2) return false;
        
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}