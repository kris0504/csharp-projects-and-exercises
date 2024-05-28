using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Честота
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			NewData();
		}
		private void NewData()
		{
			
			Random r = new Random();
			int[] numbers = new int[r.Next(5, 21)];

			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = r.Next(1, 11);

			}
			textBox1.Text = string.Join(", ", numbers);
			var result = from num in numbers
						 group num by num into grp
						 select new
						 {
							 Number = grp.Key,
							 Reps = grp.Count(),
							 Sum= grp.Sum()
						 };
			textBox2.Clear();
			foreach (var item in result)
			{
				textBox2.Text += $"{item.Number}\t\t\t{item.Sum}\t\t\t{item.Reps}{Environment.NewLine}";

			}
			
		}
	}
}
