class clock
{
    public delegate void AlarmHandler(object sender);
    public event AlarmHandler tick;
    public event AlarmHandler alarm;
    public void Tick()
    {
        tick(this);
    }
    public void Alarm()
    {
        alarm(this);
    }
}

class timer
{
    public clock clock1 = new clock();
    public timer()
    {
        clock1.tick += TickHandler;
        clock1.alarm += AlarmHandler;
    }
    void TickHandler(object sender)
    {
        Console.WriteLine("Tick");
    }
    void AlarmHandler(object sender)
    {
        Console.WriteLine("Alarm");
    }
}

class Program
{
    static void Main(string[] args)
    {
        timer timer1 = new timer();
        timer1.clock1.Tick();
        timer1.clock1.Tick();
        timer1.clock1.Tick();
        timer1.clock1.Alarm();
        timer1.clock1.Tick();
    }
}