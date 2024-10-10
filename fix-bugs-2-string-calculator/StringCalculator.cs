namespace fix_bugs_2_string_calculator;

public class StringCalculator
{
    public string Add(string numbers)
    {
        string delimiter = ",";
        if (numbers.StartsWith("//"))
        {
            int delimiterEndIndex = numbers.IndexOf('\n');
            delimiter = numbers.Substring(2, delimiterEndIndex - 2);
            numbers = numbers.Substring(delimiterEndIndex + 1);
        }

        string[] numberArray = numbers.Split([delimiter, "\n"], StringSplitOptions.None);
        double sum = 0;

        foreach (string number in numberArray)
        {
            if (!string.IsNullOrEmpty(number))
            {
                sum += double.Parse(number);
            }
        }

        return sum.ToString();
    }
}