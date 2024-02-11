class Program
{
    static void Main()
    {
        PregnantWoman pregnantWoman = new PregnantWoman();
        pregnantWoman.AddPregnancyStage(new Trimester());
        pregnantWoman.AddPregnancyStage(new LaborDelivery());

        Obstetrician obstetrician = new Obstetrician();
        pregnantWoman.ReceiveCheckup(obstetrician);
    }
}
