namespace Regex;

public class RegexUtils
{
    public bool IsSomething(string possibleSomething)
    {
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return System.Text.RegularExpressions.Regex.IsMatch(possibleSomething, pattern);
    }

    public bool IsSomethingElse(string possibleSomethingElse)
    {
        string pattern = @"^\+?[1-9]\d{1,14}$";
        return System.Text.RegularExpressions.Regex.IsMatch(possibleSomethingElse, pattern);
    }

    public bool IsAnotherThing(string possibleAnotherThing)
    {
        string pattern = @"^(https?|ftp)://[^\s/$.?#].[^\s]*$";
        return System.Text.RegularExpressions.Regex.IsMatch(possibleAnotherThing, pattern);
    }

    public bool IsYetAnotherThing(string possibleYetAnotherThing)
    {
        string pattern = @"^#?([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$";
        return System.Text.RegularExpressions.Regex.IsMatch(possibleYetAnotherThing, pattern);
    }

    public bool IsDifferentThing(string possibleDifferentThing)
    {
        string pattern =
            @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        return System.Text.RegularExpressions.Regex.IsMatch(possibleDifferentThing, pattern);
    }

    public bool IsSomeOtherThing(string possibleSomeOtherThing)
    {
        string pattern = @"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/\d{4}$";
        return System.Text.RegularExpressions.Regex.IsMatch(possibleSomeOtherThing, pattern);
    }
}