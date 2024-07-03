using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // IMIĘ ///////////////////////////////////////////////////////////////////////////////

            string name = string.Empty;

            while (true)
            {

                Console.WriteLine("Wpisz imię");

                name = Console.ReadLine();

                if (name.Length > 15)
                {
                    Console.WriteLine("Zbyt duża ilość znaków");
                    Console.WriteLine("Czy chcesz wprowadzić imię ponownie? TAK/NIE");
                    string odpwoeidz = Console.ReadLine().ToUpper();

                    if (odpwoeidz != "TAK")
                    {
                        Console.WriteLine("Formularz nie został uzupełniony");
                        return;
                    }


                }
                else if (name.Length <= 1)
                {
                    Console.WriteLine("Za mała ilość znaków");
                    Console.WriteLine("Czy chcesz wprowadzić imię ponownie? TAK/NIE");
                    string odpwoeidz = Console.ReadLine().ToUpper();
                    if (odpwoeidz != "TAK")
                    {
                        Console.WriteLine("Formularz nie został uzupełniony");
                        return;
                    }

                }
                else
                {
                    break;
                }

             }

            // NAZWISKO //////////////////////////////////////////////////////////////////////////

            string secondName = string.Empty ;

            while (true)
            {

                Console.WriteLine("Wpisz nazwisko");

                secondName = Console.ReadLine();

                if (secondName.Length > 20)
                {
                    Console.WriteLine("Zbyt duża ilość znaków");
                    Console.WriteLine("Czy chcesz wprowadzić nazwisko ponownie? TAK/NIE");
                    string odpwoeidz = Console.ReadLine().ToUpper();

                    if (odpwoeidz != "TAK")
                    {
                        Console.WriteLine("Formularz nie został uzupełniony");
                        return;
                    }


                }
                else if (secondName.Length <= 1)
                {
                    Console.WriteLine("Za mała ilość znaków");
                    Console.WriteLine("Czy chcesz wprowadzić nazwisko ponownie? TAK/NIE");
                    string odpwoeidz = Console.ReadLine().ToUpper();
                    if (odpwoeidz != "TAK")
                    {
                        Console.WriteLine("Formularz nie został uzupełniony");
                        return;
                    }

                }
                else
                {
                    break;
                }

            }


            // MIASTO////////////////////////////////////////////////////////////////////////////////

            string city = string.Empty;

            while (true)

            {

                Console.WriteLine("Wpisz miasto - dostępne miasta to: Kraków, Warszawa");
                city = Console.ReadLine();

                List<string> cities = new List<string>
                {

                "Kraków",
                "Warszawa"

                };

                if (!cities.Contains(city))
                {
                    Console.WriteLine("Nieobsługiwane misto.");
                    Console.WriteLine("Czy chcesz wprowadzić miasto ponownie? TAK/NIE");
                    string odpwoeidz = Console.ReadLine().ToUpper();

                    if (odpwoeidz != "TAK")
                    {
                        Console.WriteLine("Formularz nie został uzupełniony");
                        return;
                    }

                }
                else
                { 
                    break ;
                }

            }

            // KOD POCZTOWY ///////////////////////////////////////////////////////////////////////////////

            string code = string.Empty;

            while (true)
            {

                Console.WriteLine("Wpisz kod pocztowy");

                code = (Console.ReadLine());

                if (code.Length > 6)
                {
                    Console.WriteLine("Zbyt duża ilość znaków");
                    Console.WriteLine("Czy chcesz wprowadzić kod pocztowy ponownie? TAK/NIE");
                    string odpwoeidz = Console.ReadLine().ToUpper();

                    if (odpwoeidz != "TAK")
                    {
                        Console.WriteLine("Formularz nie został uzupełniony");
                        return;
                    }


                }
                else if (secondName.Length < 6)
                {
                    Console.WriteLine("Za mała ilość znaków");
                    Console.WriteLine("Czy chcesz wprowadzić kod pocztowy ponownie? TAK/NIE");
                    string odpwoeidz = Console.ReadLine().ToUpper();
                    if (odpwoeidz != "TAK")
                    {
                        Console.WriteLine("Formularz nie został uzupełniony");
                        return;
                    }

                }
                else
                {
                    break;
                }

            }



            // NAZWA ULICY ///////////////////////////////////////////////////////////////////////////////

            string street = string.Empty;

            while (true)
            {

                Console.WriteLine("Wpisz ulicę");

                street = Console.ReadLine();

                if (street.Length > 20)
                {
                    Console.WriteLine("Zbyt duża ilość znaków");
                    Console.WriteLine("Czy chcesz wprowadzić nazwę ulicy ponownie? TAK/NIE");
                    string odpwoeidz = Console.ReadLine().ToUpper();

                    if (odpwoeidz != "TAK")
                    {
                        Console.WriteLine("Formularz nie został uzupełniony");
                        return;
                    }


                }
                else if (street.Length <= 1)
                {
                    Console.WriteLine("Za mała ilość znaków");
                    Console.WriteLine("Czy chcesz wprowadzić nazwę ulicy ponownie? TAK/NIE");
                    string odpwoeidz = Console.ReadLine().ToUpper();
                    if (odpwoeidz != "TAK")
                    {
                        Console.WriteLine("Formularz nie został uzupełniony");
                        return;
                    }

                }
                else
                {
                    break;
                }

            }

            // NUMER BUDYNKU ///////////////////////////////////////////////////////////////////////////////

            string number = string.Empty;

            while (true)
            {

                Console.WriteLine("Wpisz ulicę");

                number = Console.ReadLine();

                if (number.Length > 5)
                {
                    Console.WriteLine("Zbyt duża ilość znaków");
                    Console.WriteLine("Czy chcesz wprowadzić numer budynku ponownie? TAK/NIE");
                    string odpwoeidz = Console.ReadLine().ToUpper();

                    if (odpwoeidz != "TAK")
                    {
                        Console.WriteLine("Formularz nie został uzupełniony");
                        return;
                    }


                }
                else if (street.Length <= 1)
                {
                    Console.WriteLine("Za mała ilość znaków");
                    Console.WriteLine("Czy chcesz wprowadzić numer budynku ponownie? TAK/NIE");
                    string odpwoeidz = Console.ReadLine().ToUpper();
                    if (odpwoeidz != "TAK")
                    {
                        Console.WriteLine("Formularz nie został uzupełniony");
                        return;
                    }

                }
                else
                {
                    break;
                }

            }


            // PESEL ///////////////////////////////////////////////////////////////////////////////////

            string pesel = string.Empty;

            while (true)
            {

                Console.WriteLine("Wpisz PESEL");
            
             pesel = Console.ReadLine();

                if (pesel.Length > 11)
                {
                    Console.WriteLine("Zbyt duża ilość znaków");
                    

                }
                else if (pesel.Length < 11)
                {
                    Console.WriteLine("Za mała ilość znaków");
                    
                }
                else
                {
                    break;
                    
                }

                Console.WriteLine("Czy chcesz wprowadzić PESEL ponownie? TAK/NIE");
                string odpwoeidz = Console.ReadLine();

                if (odpwoeidz != "TAK")
                {
                    Console.WriteLine("Formularz nie został uzupełniony");
                    break;
                }



            }

           Console.WriteLine("Podsumowanie: ");
            Console.WriteLine();
            Console.WriteLine($"Imię: {name}");
            Console.WriteLine($"Nazwisko: {secondName}");
            Console.WriteLine($"Miasto: {city}");
            Console.WriteLine($"Kod pocztowy: {code}");
            Console.WriteLine($"Ulica: {street}");
            Console.WriteLine($"Numer bodynku: {number}");
            Console.WriteLine($"PESEL: {pesel}");
            Console.WriteLine();
            Console.WriteLine("Dziękuje za wypełnienie formularza");








        }
            
    }
}

