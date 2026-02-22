class RemoteControlCar
{
    private int speed;
    private int battery;
    private int batteryDrain;
    private int distance;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.battery = 100;
        this.distance = 0;
    }
    // TODO: define the constructor for the 'RemoteControlCar' class

    public bool BatteryDrained()
    {
        return (this.battery <= 0) || (this.battery < this.batteryDrain);
    }

    public int DistanceDriven()
    {
        return this.distance;
    }

    public void Drive()
    {
        if (BatteryDrained())
        {
            return;
        }
        this.distance+=this.speed;
        this.battery-=this.batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new(50, 4);
    }
}

class RaceTrack
{
    private int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained() && car.DistanceDriven() < this.distance)
        {
            car.Drive();
        }
        if (car.DistanceDriven() >= this.distance ) return true;
        return false;
    }
}
