using System;
// Concrete class representing labor and delivery
public class LaborDelivery : IPregnancyStage
{
    public string Stage { get; set; } = "Third Trimester";
    public void MonitorHealth()
    {
        Console.WriteLine("Monitoring health during labor and delivery.");
    }
}
