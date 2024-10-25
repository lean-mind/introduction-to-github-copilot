namespace simplificatation_of_code;

public interface IRandomGenerator
{
    int Next(int minValue, int maxValue);
}

public interface IConsoleOutput
{
    void WriteLine(string message);
}

public class RandomGenerator : IRandomGenerator
{
    private readonly Random _random = new Random();
    public int Next(int minValue, int maxValue) => _random.Next(minValue, maxValue);
}

public class ConsoleOutput : IConsoleOutput
{
    public void WriteLine(string message) => Console.WriteLine(message);
}

public class Simulator
{
    private readonly IRandomGenerator _randomGenerator;
    private readonly IConsoleOutput _consoleOutput;

    public Simulator(IRandomGenerator randomGenerator, IConsoleOutput consoleOutput)
    {
        _randomGenerator = randomGenerator;
        _consoleOutput = consoleOutput;
    }

    public void SimWeather(int iniTemp, int iniRainPercentage, int numDays = 7)
    {
        int minTemp = iniTemp;
        int maxTemp = iniTemp;
        int rainPercentage = iniRainPercentage;
        int rainDays = 0;
        int temperatureToday = iniTemp;
        int temperaturePreviousDay = temperatureToday;
        int temperatureNextDay = temperatureToday;

        for (int day = 1; day <= numDays; day++)
        {
            bool isRaining = false;
            temperaturePreviousDay = temperatureToday;
            temperatureToday = temperatureNextDay;

            _consoleOutput.WriteLine("Temperature on day " + day + " is " + temperatureToday);
            // Adjust min and max temperature
            if (temperatureToday < minTemp)
            {
                minTemp = temperatureToday;
            }
            else if (temperatureToday > maxTemp)
            {
                maxTemp = temperatureToday;
            }

            // Generate a random number to check if it will rain
            int randomChance = _randomGenerator.Next(0, 100);
            if (randomChance <= rainPercentage)
            {
                // It will rain
                isRaining = true;
                rainDays++;
                _consoleOutput.WriteLine("It will rain");
            }
            else
            {
                _consoleOutput.WriteLine("It won't rain");
            }

            if (temperatureToday > 25)
            {
                // Temperature is greater than 25 so we increase rain percentage by 20%
                rainPercentage += 20;
            }

            if (temperaturePreviousDay - temperatureToday >= 5)
            {
                // Temperature decrease by 5 degrees or more
                rainPercentage -= 20;
            }

            if (isRaining)
            {
                // If it's raining, temperature will decrease by 1 degree
                temperatureNextDay = temperatureToday - 1;
            }
            else
            {
                // There is a 10% chance of changing temperature
                randomChance = _randomGenerator.Next(0, 100);
                if (randomChance < 10)
                {
                    // Temperature will change and new random will be generated to know if it will increase or decrease
                    int tempChange = _randomGenerator.Next(0, 2) == 0 ? 2 : -2;
                    temperatureNextDay = temperatureToday + tempChange;
                }
                else
                {
                    temperatureNextDay = temperatureToday;
                }
            }
        }

        _consoleOutput.WriteLine("Number of days with rain: " + rainDays);
        _consoleOutput.WriteLine("Max temperature expected: " + maxTemp + ", min temperature expected: " + minTemp);
    }
}