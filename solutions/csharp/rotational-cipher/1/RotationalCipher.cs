public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string finalText = "";
        foreach( char c in text)
        {
            if (!char.IsLetter(c))
            {
                finalText+= c;
            } else {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                var withShift = c+ shiftKey;
                var withShiftOffset = withShift-offset;
                var limit = withShiftOffset % 26;
                var final = limit +offset;
                finalText+= (char)final;
            }
        }
        return finalText;

    }
}