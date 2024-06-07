using Ispit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucenik ucenik1 = new Ucenik();
            Console.WriteLine("Upišite ime učenika: ");
            ucenik1.Ime = Console.ReadLine();
            Console.WriteLine("Upišite prezime učenika: ");
            ucenik1.Prezime = Console.ReadLine();
            Console.WriteLine("Upišite datum rođenja učenika(MM-dd-yyyy): ");
            ucenik1.DatumRodjenja = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Upišite prosjek učenika: ");
            ucenik1.Prosjek = Convert.ToDouble(Console.ReadLine());

            Ucenik ucenik2 = new Ucenik();
            Console.WriteLine("Upišite ime učenika: ");
            ucenik2.Ime = Console.ReadLine();
            Console.WriteLine("Upišite prezime učenika: ");
            ucenik2.Prezime = Console.ReadLine();
            Console.WriteLine("Upišite datum rođenja učenika(MM-dd-yyyy): ");
            ucenik2.DatumRodjenja = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Upišite prosjek učenika: ");
            ucenik2.Prosjek = Convert.ToDouble(Console.ReadLine());

            Ucenik ucenik3 = new Ucenik();
            Console.WriteLine("Upišite ime učenika: ");
            ucenik3.Ime = Console.ReadLine();
            Console.WriteLine("Upišite prezime učenika: ");
            ucenik3.Prezime = Console.ReadLine();
            Console.WriteLine("Upišite datum rođenja učenika(MM-dd-yyyy): ");
            ucenik3.DatumRodjenja = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Upišite prosjek učenika: ");
            ucenik3.Prosjek = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Ime: {ucenik1.Ime}");
            Console.WriteLine($"Ime: {ucenik1.Prezime}");
            ucenik1.Starost();
            ucenik1.IspisProsjeka();
            
            Console.WriteLine($"Ime: {ucenik2.Ime}");
            Console.WriteLine($"Ime: {ucenik2.Prezime}");
            ucenik2.Starost();
            ucenik2.IspisProsjeka();

            Console.WriteLine($"Ime: {ucenik3.Ime}");
            Console.WriteLine($"Ime: {ucenik3.Prezime}");
            ucenik3.Starost();
            ucenik3.IspisProsjeka();
            
            Console.ReadKey();

        }
    }
}
