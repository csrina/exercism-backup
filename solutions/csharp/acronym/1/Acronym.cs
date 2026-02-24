public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var splits = phrase.Split([' ', '-', '_']);
        string res = "";
        foreach(string w in splits)
        {
			if (w == "") continue;
            char first = w[0];
            if (char.IsLetter(first))
            {
                res = $"{res}{first.ToString().ToUpper()}";
            }
        }

        return res;
    }
}