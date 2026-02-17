using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new(identifier);
        sb.Replace(' ', '_');
        sb.Replace("\0", "CTRL");
        StringBuilder sb2 = new StringBuilder("", sb.Length);
        var atDash = false;
        for (int ctr = 0; ctr < sb.Length; ctr++)
        {
            char ch = sb[ctr];
            if (ch == '-')
            {
                atDash = true;
            }
            else if (Char.IsLetter(ch) || ch == '_')
            {
                if (atDash)
                {
                    atDash = false;
                    sb2.Append(Char.ToUpper(ch));
                } else {
                    bool isGreekLetter = Regex.IsMatch(ch.ToString(), @"^[α-ω]$");
                    if (!isGreekLetter)
                    {
                        sb2.Append(ch);   
                    }
                }
            }
        }
        return sb2.ToString();
    }
}

