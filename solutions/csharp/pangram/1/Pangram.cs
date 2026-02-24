public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.ToLower();
        if (input == "") return false;
        List<char> found = new();
        foreach(char ch in input)
        {
            if (char.IsLetter(ch) && !found.Contains(ch))
            {
                found.Add(ch);
            }
        }
        return found.Count == 26;
    }
}
