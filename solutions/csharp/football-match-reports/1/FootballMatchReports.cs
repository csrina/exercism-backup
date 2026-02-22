public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => shirtNum switch
    {
        1 => "goalie",
        2 => "left back",
        3 or 4 => "center back",
        5 => "right back",
        6 or 7 or 8 => "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => "UNKNOWN",
    };

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case string:
                return (string)report;
            case Injury:
                return ((Injury)report).GetDescription();
            case Incident:
                return ((Incident)report).GetDescription();
            case int:
                return $"There are {report} supporters at the match.";
            case Manager:
                var m = (Manager)report;
                var c = m.Club == null ? "" : $" ({m.Club})";
                return $"{m.Name}{c}";
            default:
                return "";

        }
    }
}
