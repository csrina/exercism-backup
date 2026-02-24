
public class Anagram
{
    string baseWord;
    int baseLength;
    Dictionary<char, int> dict;
    public Anagram(string baseWord)
    {
        baseWord = baseWord.ToLower();
        this.baseWord = baseWord;
        this.baseLength = baseWord.Length;
        this.dict = [];
        foreach(char ch in baseWord) {
            if(char.IsLetter(ch)) {
                if(this.dict.TryGetValue(ch, out int value)) {
                    this.dict[ch] = ++value;
                } else {
                    this.dict.Add(ch, 1);
                }
            }
        }
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> found = new();
        foreach (string opm in potentialMatches)
        {
            string pm = opm.ToLower();
            if (this.baseLength == pm.Length && pm != this.baseWord)
            {
                Dictionary<char, int> pmDict = [];
                foreach(char ch in pm) {
                    if(pmDict.TryGetValue(ch, out int value)) {
                        pmDict[ch] = ++value;
                    } else {
                        pmDict.Add(ch, 1);
                    }
                }
                int happyCount = 0;
                foreach (KeyValuePair<char, int> d in this.dict){
                    if(pmDict.TryGetValue(d.Key, out int value) && d.Value == value) {
                        happyCount++;
                    }
                }

                if (pmDict.Count == this.dict.Count && happyCount == this.dict.Count) {
                    found.Add(opm);
                }
            }
        }
        return [.. found];
    }
}