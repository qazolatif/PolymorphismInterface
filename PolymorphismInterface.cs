using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Nama : Khias Nurlatif Ari Subekti");
			Console.WriteLine("NIM  : 19.11.2776");
			Console.WriteLine("Kelas: IF 03\n");
			
			IPrinterWindows printer = new PrinterWindows();
			
			printerNumberInput:
			Console.WriteLine("Choose a Printer: ");
			Console.WriteLine("1. Epson");
			Console.WriteLine("2. Canon");
			Console.WriteLine("3. LaserJet");
   
			Console.Write("Printer Number[1..3]: ");
			int printerNumber = Convert.ToInt32(Console.ReadLine());
			
			if (printerNumber == 1)
			{
				printer = new Epson();
			}
			else if (printerNumber == 2)
			{
				printer = new Canon();
			}
			else if (printerNumber == 3)
			{
				printer = new LaserJet();
			}
			else
			{
			Console.WriteLine("Sorry. The number you input has not been recorded. Please try again.\n");
			goto printerNumberInput;
			}
   
			printer.Show();
			printer.Print();
	   
			Console.ReadKey();
		}
	}
	
	public interface IPrinterWindows
	{
		void Show();
		void Print();
	}
	
	public class PrinterWindows : IPrinterWindows
	{
		public virtual void Show()
		{
			Console.WriteLine("Printer Windows display dimension: ");
		}
		
		public virtual void Print()
		{
			Console.WriteLine("Printer is printing....");
		}
	}
	
	public class Epson : IPrinterWindows
	{
		public void Show()
		{
			Console.WriteLine("Printer Epson display dimension: 10 * 11");
		}
		
		public void Print()
		{
			Console.WriteLine("Epson printer is printing....");
		}
	}

	public class Canon : IPrinterWindows
	{
		public void Show()
		{
			Console.WriteLine("Printer Canon display dimension: 9.5 * 12");
		}
		
		public void Print()
		{
			Console.WriteLine("Canon printer is printing....");
		}
	}
	
	public class LaserJet : IPrinterWindows
	{
		public void Show()
		{
			Console.WriteLine("Printer LaserJet display dimension: 12 * 12");
		}
		
		public void Print()
		{
			Console.WriteLine("LaserJet printer is printing....");
		}
	}
}
