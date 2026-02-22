public static class Languages
{
    public static List<string> NewList()
    {
        return new();
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> b = NewList();
        b.Add("C#");
        b.Add("Clojure");
        b.Add("Elm");

        return b;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        return (languages.Count > 0 && languages[0] == "C#") || (languages.Count > 1 && languages.Count < 4 && languages[1] == "C#");
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        List<string> uniq = new();
        foreach( string l in languages)
        {
            if (uniq.Contains(l))
            {
                return false;
            }
            uniq.Add(l);
        }
        return true;
    }
}
