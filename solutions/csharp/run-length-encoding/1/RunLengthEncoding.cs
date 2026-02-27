public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (input == "") return input;
        string final ="";
        char curChr = '\0';
        int curCount = 0;
        foreach(char ch in input)
        {
            if (ch == curChr)
            {
                curCount++;
            } else
            {
                if (curChr != '\0')
                {
                    if (curCount == 1 )
                    {
                        final=$"{final}{curChr}";
                        
                    } else
                    {
                        final=$"{final}{curCount}{curChr}";
                    }
                    curChr = ch;
                    curCount = 1;
                } else
                {
                    curChr = ch;
                    curCount = 1;
                }
            }
        }
        if (curCount == 1 )
        {
            final=$"{final}{curChr}";
            
        } else
        {
            final=$"{final}{curCount}{curChr}";
        }
        return final;
    }

    public static string Decode(string input)
    {
        if (input == "") return input;
        string final = "";
        string strCount = "";
        bool previousIsNumber = false;
        foreach(char ch in input)
        {
            if (char.IsLetter(ch)|| ch == ' ')
            {
                if (previousIsNumber == true)
                {
                    int count = Int32.Parse(strCount);
                    for (int i = 0; i < count; i++)
                    {
                        final = $"{final}{ch}";
                    }
                    previousIsNumber = false;
                } else
                {
                    final = $"{final}{ch}";
                }
                
            }
            if (char.IsNumber(ch))
            {
                if (previousIsNumber == false)
                {
                    previousIsNumber = true;
                    strCount = $"{ch}";
                } else
                {
                    strCount = $"{strCount}{ch}";
                }
            }
        }
        return final;
    }
}
