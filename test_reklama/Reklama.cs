using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_reklama
{
	public class Reklama
	{
		public int Mesec { get; set; }
		public string Kanal { get; set; }
		public double Suma { get; set; }
		public Reklama(string line)
		{ 
			string[] props = line.Split(' ');
			Mesec =int.Parse(props[0]);
			Kanal = props[1];
			Suma =double.Parse(props[2]);

		}
		
	}
}
