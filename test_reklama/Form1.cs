using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test_reklama
{
	public partial class Form1 : Form
	{
		List<Reklama> reklamas;
		public Form1()
		{
			InitializeComponent();
			string[] lines = File.ReadAllLines("reklama.txt");
			reklamas = new List<Reklama>();
			Load_Reklami();
		}
		public void Load_Reklami()
		{
			StreamReader sr = new StreamReader("reklama.txt");
			while (true)
			{
				string oneLine = sr.ReadLine();
				if (oneLine==null)
				{
					sr.Close();
					break;
				}
				reklamas.Add(new Reklama(oneLine));
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioButtonSort.Checked)
			{
				label3.Text = "Месец";
				label4.Text = "Канал";
				label5.Text = "Стойност";
				textBox1.Text = string.Join(Environment.NewLine, reklamas.OrderBy(x=>x.Mesec).ThenByDescending(x=>x.Suma).Select(x =>  $"{x.Mesec,-12}{x.Kanal,-20}{x.Suma:f2} лв."));
			}
			else if (radioButtonAvgByMonth.Checked)
			{
				label3.Text = "Месец";
				label4.Text = "Стойност";
				textBox1.Text = string.Join(Environment.NewLine, reklamas.GroupBy(x=>x.Mesec).Select(x =>$"{x.Key,-10}{x.Average(y=>y.Suma):f2} лв."));
			}
			else if (radioButtonSpravka.Checked)
			{
				label3.Text = "Месец";
				label4.Text = "Канал";
				label5.Text = "Стойност";
				textBox1.Text = string.Join(Environment.NewLine, reklamas.Where(x=>x.Mesec==1 && x.Suma>10000 && x.Suma<20000).Select(x =>$"{x.Mesec}\t\t{x.Kanal}\t\t{x.Suma:f2} лв."));
			}
			else if (radioButtonOverDouble.Checked)
			{
				label3.Text = "Месец";
				label4.Text = "Канал";
				label5.Text = "Стойност";
				double minsum = reklamas.Min(x => x.Suma);
				textBox1.Text = string.Join(Environment.NewLine, reklamas.Where(x=>x.Suma>minsum*2).OrderBy(x=>x.Suma).Select(x=>$"{x.Mesec,-12}{x.Kanal,-20}{x.Suma:f2} лв."));
			}
			
		}
	}
}
