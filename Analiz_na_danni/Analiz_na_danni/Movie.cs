using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analiz_na_danni
{
	class Movie
	{
		public int Year { get; set; }
		public string Title { get; set; }
		public int CountOfWords { get{
				int n = 0;
				foreach (var c in Title)
				{
					if (c==' ')
					{
						n++;
					}
				}
				return n+1; } }
		public Movie(string dataLine)
		{
			string[] data = dataLine.Split('/');
			Title = data[0];
			Year = int.Parse(data[1]);
		}
		public override string ToString()
		{
			return $"{Title}/*{Year}*/";
		}
	}
}
