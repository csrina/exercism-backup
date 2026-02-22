static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idl = id != null ? $"[{id}] - " : "";
        return $"{idl}{name} - {department?.ToUpper()?? "OWNER"}";
    }
}
