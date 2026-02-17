static class LogLine
{
    public static string Message(string logLine)
    {
        var splits = logLine.Split("]:", StringSplitOptions.TrimEntries);
        return splits[1];
    }

    public static string LogLevel(string logLine)
    {
        var splits = logLine.Split(['[', ']'], StringSplitOptions.RemoveEmptyEntries);
        return splits[0].ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
