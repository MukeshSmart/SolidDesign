using System;
// Concrete class representing an obstetrician
public class Obstetrician : MedicalProfessional
{
    public override void PerformCheckup(IPregnancyStage pregnancyStage)
    {
        Console.WriteLine("Obstetrician performing a checkup.");
        pregnancyStage.MonitorHealth();
    }
}
