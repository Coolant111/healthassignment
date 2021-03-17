// program to test out the class


using System;

class HealthProfileTest
{
    public static void Main(string[] args)
    {
        HealthProfile hpm1 = new HealthProfile(null, null, 0, 0, 0, 0, 0, null);

        Console.Write("Enter First Name: ");
        hpm1.FirstName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Last Name: ");
        hpm1.LastName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Day of Birth: ");
        hpm1.DayOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Month of Birth: ");
        hpm1.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Year of Birth: ");
        hpm1.YearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Weight in pounds: ");
        hpm1.WeightInPounds = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Height in inches: ");
        hpm1.HeightInInches = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Gender: ");
        hpm1.Gender = Convert.ToString(Console.ReadLine());

        
        
        hpm1.DisplayFirstName();
        hpm1.DisplayLastName();
        hpm1.DisplayDayOfBirth();
        hpm1.DisplayMonthOfBirth();
        hpm1.DisplayYearOfBirth();
        hpm1.DisplayWeightInPounds();
        hpm1.DisplayHeightInInches();
        hpm1.DisplayGender();
        hpm1.DisplayYearsOfAgeSimple();
        hpm1.DisplayMaxHeartRate();
        hpm1.DisplayTargetHeartRate();
        hpm1.DisplayBodyMassIndex();
        hpm1.DisplayBMIOutput();
        hpm1.DisplayBMIChart();        
    }
}