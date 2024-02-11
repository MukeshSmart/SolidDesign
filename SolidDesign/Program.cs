using System;

//testing
public class Program
{
    //testing code push3
    static void Main()
    {
        PregnantWoman pregnantWoman = new PregnantWoman();
        pregnantWoman.AddPregnancyStage(new FirstTrimester());
        pregnantWoman.AddPregnancyStage(new SecondTrimester());
        pregnantWoman.AddPregnancyStage(new LaborDelivery());

        Obstetrician obstetrician = new Obstetrician();
        pregnantWoman.ReceiveCheckup(obstetrician);
        obstetrician.ProvidePrescription();

        Console.ReadLine(); 
    }
}
