using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Printer
    {
        public string Name;
        public string Appointment;
        public string Printing_technology;
        public int Buyers;
        public double YearIncome;
        public double Square;
        public bool HasPhotoprinting;
        public bool HasTwo_sided_printing;
        public double GetYearIncomePerInhabitant()
        {
            return YearIncome / Buyers;
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть назву принтера: ");
            string sName = Console.ReadLine();
            Console.Write("Введiть призначення: ");
            string sAppointment = Console.ReadLine();
            Console.Write("Введiть технологію друку: ");
            string sPrinting_technology = Console.ReadLine();
            Console.Write("Введiть кiлькiсть покупців: ");
            string sBuyers = Console.ReadLine();
            Console.Write("Введiть рiчний дохiд з продажу даного принтеру: ");
            string sYearIncome = Console.ReadLine();
            Console.Write("Введiть площу, м^2: ");
            string sSquare = Console.ReadLine();
            Console.Write("Чи є фотодрук? (y-так, n-нi): ");
            ConsoleKeyInfo keyHasPhotoprinting = Console.ReadKey();
            Console.WriteLine();
            Console.Write("Чи є двусторонній друк? (y-так, n-нi): ");
            ConsoleKeyInfo keyHasTwo_sided_printing = Console.ReadKey();
            Console.WriteLine();
            Printer OurPrinter = new Printer();
            OurPrinter.Name = sName;
            OurPrinter.Appointment = sAppointment;
            OurPrinter.Printing_technology = sPrinting_technology;
            OurPrinter.Buyers = int.Parse(sBuyers);
            OurPrinter.YearIncome = double.Parse(sYearIncome);
            OurPrinter.Square = double.Parse(sSquare);
            OurPrinter.HasPhotoprinting = keyHasPhotoprinting.Key == ConsoleKey.Y ? true : false;
            OurPrinter.HasTwo_sided_printing = keyHasTwo_sided_printing.Key == ConsoleKey.Y ? true : false;
            double YearIncomePerBuyer = OurPrinter.GetYearIncomePerInhabitant();
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("Данi про принтер: ");
            Console.WriteLine("------------------");
            Console.WriteLine("Назва: " + OurPrinter.Name);
            Console.WriteLine("Призначення: " + OurPrinter.Appointment);
            Console.WriteLine("Технологія друку: " + OurPrinter.Printing_technology);
            Console.WriteLine("Кiлькiсть покупців: " +
            OurPrinter.Buyers.ToString());
            Console.WriteLine("Рiчний дохiд: " +
            OurPrinter.YearIncome.ToString("0.00"));
            Console.WriteLine("Площа: " + OurPrinter.Square.ToString("0.000"));
            Console.WriteLine(OurPrinter.HasPhotoprinting ? "Принтер має фотодрук" :
            "Принтер не має фотодруку");
            Console.WriteLine(OurPrinter.HasTwo_sided_printing ? "Принтер має двусторонній друк" :
            "Принтер не має двустороннього друку");
            Console.WriteLine();
            Console.WriteLine("Середня річна витрата на одного покупця: " +
            YearIncomePerBuyer.ToString("0.00"));

Console.ReadKey();
        }
    }
}
