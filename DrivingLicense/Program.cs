using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanuse
            //kui kasutja aon noorem kui 18, siis programm kuvab konsoolis "Oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis "Oled piisavalt vana, et juhilube saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis "Palju õnne! Nüüd sa saad juhilube taotleda"
            


            Console.WriteLine("Palun sisesta oma sünniaasta:");

            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2021 - yearOfBirth;

            if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et taotleda juhilube.");
            }
            else if (UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et taotleda juhilube.");
            }
            else
            {
                Console.WriteLine("PALJU ÕNNE! Oledki 18, nüüd saad endale juhilube taotleda.");
            }

            
        }
    }
}
