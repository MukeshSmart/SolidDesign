using System;
// Concrete class representing a trimester
public class SecondTrimester : IPregnancyStage
{
    public string Stage { get; set; } = "Second Trimester";
    public void MonitorHealth()
    {
        Console.WriteLine("Monitoring health during second trimester.");
    }
}
