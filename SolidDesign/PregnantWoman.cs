using System.Collections.Generic;
// Class representing a pregnant woman
public class PregnantWoman
{
    private readonly List<IPregnancyStage> pregnancyStages;

    public PregnantWoman()
    {
        pregnancyStages = new List<IPregnancyStage>();
    }

    public void AddPregnancyStage(IPregnancyStage pregnancyStage)
    {
        pregnancyStages.Add(pregnancyStage);
    }

    public void ReceiveCheckup(MedicalProfessional medicalProfessional)
    {
        foreach (var stage in pregnancyStages)
        {
            medicalProfessional.PerformCheckup(stage);
        }
    }
}
