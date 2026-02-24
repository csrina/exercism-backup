public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        input = input.ToLower();
        if (input == "") return false;
        List<char> found = new();
        foreach(char ch in input)
        {
            if (char.IsLetter(ch))
            {
                if (!found.Contains(ch))
                    found.Add(ch);
                else 
                    return true;
            }
        }
        return false;
    }
}
