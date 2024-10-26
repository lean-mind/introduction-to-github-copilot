namespace simplificatation_of_code;

public class Filter
{
public List<int> FilterComplexList(List<int> list)
{
    List<int> result = new List<int>();
    foreach (var item in list)
    {
        if (item % 2 == 0)
        {
            if (item > 10)
            {
                if (item < 50)
                {
                    result.Add(item);
                }
            }
        }
    }

    List<int> finalResult = new List<int>();
    foreach (var item in result)
    {
        if (item % 3 == 0)
        {
            finalResult.Add(item);
        }
    }

    List<int> finalFinalResult = new List<int>();
    foreach (var item in finalResult)
    {
        if (item % 5 == 0)
        {
            finalFinalResult.Add(item);
        }
    }

    return finalFinalResult;
}
}