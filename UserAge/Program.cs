using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaasta konsoolis;
            //"oled sündinud aastal {yearOfBirth}"

            Console.WriteLine("Palun sisesta oma vanus:");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - UserAge;

            //Console.WriteLine("Oled " + userAge + " aastat vana.");
            //string interpolation

            Console.WriteLine($"Oled {YearOfBirth} aastal sündinud.");
        }

    }
}
