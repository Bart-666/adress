using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adress
{
	class Program
	{
		static void Main(string[] args)
		{
			string voornaam;
			voornaam = ("ken");
			Console.WriteLine("voornaam : ken ");
			string naam;
			naam = ("field");
			Console.WriteLine("Naam : field");
			Console.WriteLine("straat : stationstraat");
			Console.WriteLine("huisnummer : 1");
			Console.WriteLine("woonplaats : brussel");
			Console.WriteLine("postcode : 1000");
			Console.WriteLine();
			Console.WriteLine("naam : " + voornaam + " " + naam);
			string straat;
			straat = ("stationstraat");
			string huisnummer;
			huisnummer = ("1");
			string woonplaats;
			woonplaats = ("Brussel");
			string postcode; postcode = ("1000");
			Console.Write("Adress : " + straat + " " + huisnummer + "," + " " + postcode + " " + woonplaats);
			postcode = Console.ReadLine();
			Console.ReadLine();
		}
	}
}
