public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new();
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new()
        {
            {1, "United States of America"},
            {55, "Brazil"},
            {91, "India"},
        };
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        return new()
        {
            {countryCode, countryName},
        };
        
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (!CheckCodeExists(existingDictionary, countryCode))
        {
            return "";
        }
       return existingDictionary[countryCode];
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (!CheckCodeExists(existingDictionary, countryCode))
        {
            return existingDictionary;
        }
        existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (!CheckCodeExists(existingDictionary, countryCode))
        {
            return existingDictionary;
        }
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        var longest = "";
        foreach(KeyValuePair<int, string> c in  existingDictionary)
        {
            if (c.Value.Length > longest.Length)
            {
                longest = c.Value;
            }
        }
        return longest;
    }
}