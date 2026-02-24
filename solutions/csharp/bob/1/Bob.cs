public static class Bob
{
    public static string Response(string statement) {
        statement = statement.Trim();
        int letterCount = 0;
        int UpperCount = 0;
        foreach (char ch in statement)
        {
            if (char.IsLetter(ch))
            {
                letterCount++;
                if (char.IsUpper(ch))
                {
                    UpperCount++;
                }
            }
        }
        
        bool allCaps = letterCount!=0 && letterCount == UpperCount;
        bool question = statement.EndsWith('?');

        if (statement == "") return "Fine. Be that way!";
        if (allCaps && question) return "Calm down, I know what I'm doing!";
        if (allCaps) return "Whoa, chill out!";
        if (question) return "Sure.";
        return "Whatever.";
    }
}