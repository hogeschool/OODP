static class Part1_Enums
{
    public static void Start()
    {
        // Season.Winter = 5; // See Season.cs: seasons go from 1-4, so this results in an error
        
        Season favoriteSeason = Season.Spring; // Enum member assignment
        
        string asString = favoriteSeason.ToString(); // Convert to string => "Spring"
        int asInt = (int)favoriteSeason; // Convert to int (int) => 2

        Season current = Season.Winter;
        // Can change int value to change to another enum member
        Season next = current + 1; // Summer

        // Cycle through the seasons GetNextSeason
        Season afterSpring = GetNextSeason(Season.Spring);
        Season afterAutumn = GetNextSeason(Season.Autumn);

        // Get all enum members Enum.GetValues
        PrintAllSeasons();

        // Switch with enums
        string winterTemp = GetTemperature(Season.Winter);

        // string to Enum TryParse()
        bool checkWinter = CheckValidSeason("Winter");
        bool checkRainySeason = CheckValidSeason("Rainy Season");
    }

    private static Season GetNextSeason(Season currentSeason) // Cycles from 1 to 4, then back to 1
    {
        if (currentSeason == Season.Autumn)
            return Season.Winter;
        return currentSeason + 1;
    }

    private static void PrintAllSeasons()
    {
        /*  
            Enum.GetValues(typeof(EnumName))
            returns an Array
            https://learn.microsoft.com/en-us/dotnet/api/system.enum.getvalues
        */
        // Array weird = Enum.GetValues(typeof(Season));
        foreach (Season season in Enum.GetValues<Season>())
        {
            Console.WriteLine($"Season {(int)season}: {season}");
        }
    }

    private static string GetTemperature(Season season)
    {
        /*
            use switch expression to get information about the enum.
            SYNTAX REMINDER: 
            value switch{
                1 => "a",
                2 => "b",
                _ => "default"
            }
        */
        // W: Cold, Sp: Cool, Su: Hot, A: Mild
        string result = season switch
        {
            Season.Winter => "Cold",
            Season.Spring => "Cool",
            Season.Summer => "Hot",
            Season.Autumn => "Mild",
            _ => "Not a season"
        };
        return result;
    }

    private static bool CheckValidSeason(string seasonStr)
    {
        /* 
           Enum.IsDefined(typeof(Enumtype), valueToCheck)
           note this can possibly result in an exception, 
           see Enum.TryParse for safer way
           https://learn.microsoft.com/en-us/dotnet/api/system.enum.isdefined
        */
        return Enum.IsDefined(typeof(Season), seasonStr);
    }

    private static string CheckValidSeason2(string seasonStr)
    {
        /* 
            Enum.TryParse(stringToCheck, out Enumtype variableName) 
            note that the stringToCheck is case sensitive
            https://learn.microsoft.com/en-us/dotnet/api/system.enum.tryparse
        */
        if (Enum.TryParse(seasonStr, out Season season))
        {
            return $"Valid, it is season number {(int)season}";
        }
        return "Invalid Season!!!!";
    }
}