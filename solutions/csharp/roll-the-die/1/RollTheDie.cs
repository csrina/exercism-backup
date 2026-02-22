public class Player
{
    Random rand = new();
    public int RollDie()
    {
        return rand.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        return rand.NextDouble();
    }
}
