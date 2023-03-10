using System;

namespace PracaDomowa
{
    internal class Tyd2Praca1
    {
        static void Main(string[] args)
        {
            //Zadanie 1

            string firstName = "Dariusz";
            string lastName = "Jóźwicki";
            int age = 64;
            string sex = "mężczyzna";
            string pesel = "59010122222";
            int nrEmpl = 16859;

            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Nr pracownika " + nrEmpl);
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine($"wiek {age}, płeć {sex}, PESEL: {pesel} \r\n");
            Console.ReadLine();


            //Zadanie 2
            char sign1 = 'A';
            char sign2 = 'B';
            char sign3 = 'C';

            Console.WriteLine("Zadanie 2");
            Console.WriteLine(sign3);
            Console.WriteLine(sign2);
            Console.WriteLine(sign1);
            Console.WriteLine();
            Console.ReadLine();


            //Zadanie 3

            double width;
            double length;
            double diagonal;

            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Podaj długość boku prostokąta");
            double.TryParse(Console.ReadLine(), out width);

            Console.WriteLine("Podaj szerokość boku prostokąta");
            double.TryParse(Console.ReadLine(), out length);

            diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));

            Console.WriteLine($"Długość przekątnej prostkąta o bokach {width} i {length}, wynosi: {diagonal} \r\n");
            Console.ReadLine();


            //Zadanie 4

            int value1;
            string value2;
            double value3;

            value1 = 10;
            value2 = "Szkoła Dotneta";
            value3 = 2.5;

            Console.WriteLine("Zadanie 4");
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine();
            Console.ReadLine();


            //Zadanie 5

            string FirstName;
            string LastName;
            string phoneNumber;
            string email;
            double height;
            double weight;

            Console.WriteLine("Zadanie 5");

            Console.WriteLine("Podaj swoje imię");
            FirstName = Console.ReadLine();

            Console.WriteLine("Podaj swoje nazwisko");
            LastName = Console.ReadLine();

            Console.WriteLine("Podaj swój numer telefonu");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("Podaj swój adres email");
            email = Console.ReadLine();

            Console.WriteLine("Podaj swój wzrost w cm");
            double.TryParse(Console.ReadLine(), out height);

            Console.WriteLine("Podaj swoją wagę w kg");
            double.TryParse(Console.ReadLine(), out weight);

            Console.WriteLine($"Cześć {FirstName} {LastName}. \r\n" +
                $"Podałeś następujące dane: \r\n" +
                $"  Numer telefonu: {phoneNumber} \r\n" +
                $"  Adres Email: {email} \r\n" +
                $"  Wzrost: {height} \r\n" +
                $"  Waga: {weight}");            
        }
    }
}
