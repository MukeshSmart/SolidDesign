using System;
// Concrete class representing an obstetrician
public class Obstetrician :MedicalProfessional, IPrescribable
{
    public override void PerformCheckup(IPregnancyStage pregnancyStage)
    {
        Console.WriteLine($"Obstetrician performing a checkup during {pregnancyStage.Stage}.");
        pregnancyStage.MonitorHealth();
    }

    public void ProvidePrescription()
    {
        Console.WriteLine("Obstetrician providing a prescription.");
        new Prescription().ProvidePrescription();
    }
}
