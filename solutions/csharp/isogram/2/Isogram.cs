public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        if (word == "") return true;
        List<char> found = new();
        foreach(char ch in word)
        {
            if (char.IsLetter(ch))
            {
                if (!found.Contains(ch))
                    found.Add(ch);
                else 
                    return false;
            }
        }
        return true;
    }
}
