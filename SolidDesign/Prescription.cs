using System;
 // Concrete class representing a prescription
    public class Prescription : IPrescribable
    {
        public void ProvidePrescription()
        {
            Console.WriteLine("Providing prescription for medication.");
        }
    }
