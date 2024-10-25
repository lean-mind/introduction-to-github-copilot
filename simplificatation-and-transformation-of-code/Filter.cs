namespace simplificatation_of_code;

public class Filter
{
    public List<int> FiltrarListaCompleja(List<int> lista)
    {
        List<int> resultado = new List<int>();
        foreach (var item in lista)
        {
            if (item % 2 == 0)
            {
                if (item > 10)
                {
                    if (item < 50)
                    {
                        resultado.Add(item);
                    }
                }
            }
        }

        List<int> resultadoFinal = new List<int>();
        foreach (var item in resultado)
        {
            if (item % 3 == 0)
            {
                resultadoFinal.Add(item);
            }
        }

        List<int> resultadoFinalFinal = new List<int>();
        foreach (var item in resultadoFinal)
        {
            if (item % 5 == 0)
            {
                resultadoFinalFinal.Add(item);
            }
        }

        return resultadoFinalFinal;
    }
}