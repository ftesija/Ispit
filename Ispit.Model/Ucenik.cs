using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Ucenik 
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public double Prosjek { get; set; }


        public int Starost() 
        {
            DateTime upravo = DateTime.Today;
            int godine = upravo.Year - DatumRodjenja.Year;
            Console.WriteLine($"Ucenik ima {godine} godina.");
            return godine;
            
            
        }

        

        public void IspisProsjeka() 
        {
            double ocjena = Prosjek;

            if (ocjena > 1.0 && ocjena <= 1.49)
            {
                Console.WriteLine("Ocjena je nedovoljan!");
            }
            else if (ocjena >= 1.5 && ocjena <= 2.49)
            {
                Console.WriteLine("Ocjena je dovoljan!");
            }
            else if (ocjena >= 2.5 && ocjena <= 3.49)
            {
                Console.WriteLine("Ocjena je dobar!");
            }
            else if (ocjena >= 3.5 && ocjena <= 4.49)
            {
                Console.WriteLine("Ocjena je vrlo dobar!");
            }
            else if (ocjena >= 4.5 && ocjena <= 5.0)
            {
                Console.WriteLine("Ocjena je odličan!");
            }
            else 
            {
                Console.WriteLine("Krivi unos!");
            }
        }

    }
}
