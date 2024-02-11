using System;
// Concrete class representing a trimester
public class FirstTrimester : IPregnancyStage
{
    public string Stage { get; set; } = "First Trimester";

    public void MonitorHealth()
    {
        Console.WriteLine("Monitoring health during first trimester.");
    }
}
