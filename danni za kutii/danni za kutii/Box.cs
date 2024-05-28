using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danni_za_kutii
{
	class Box
	{
		public int Length { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public int Weight { get; set; }
		public int Volume { get{ return Length * Width * Height; }  }
		public Box(string oneLineData)
		{
			int[] data = oneLineData.Split(' ').Select(x=>int.Parse(x)).ToArray();
			Length = data[0];
			Width = data[1];
			Height = data[2];
			Weight = data[3];
		}
		public override string ToString()
		{
			return $"Дължина: {Length};Ширина: {Width}; Височина: {Height};Тегло: {Weight};";
		}
	}
}
