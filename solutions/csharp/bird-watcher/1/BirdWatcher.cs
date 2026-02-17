class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] t = {0, 2, 5, 3,7, 8,4};
        return t ;
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]+=1;
    }

    public bool HasDayWithoutBirds()
    {
        var first = Array.FindIndex(birdsPerDay, b => b == 0);
        return first != -1;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            total+=birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        var busy = Array.FindAll(birdsPerDay, b => b >= 5);
        return busy.Length;
    }
}
