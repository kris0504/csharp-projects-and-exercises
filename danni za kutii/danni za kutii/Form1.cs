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
namespace danni_za_kutii
{
	public partial class Form1 : Form
	{
		Box[] boxes;
		public Form1()
		{
			InitializeComponent();
			LoadBoxesData();
		}
		private void LoadBoxesData()
		{
			boxes = File.ReadAllLines("boxesData.txt").Select(x=>new Box(x)).ToArray();
			listBoxStartList.DataSource = boxes;
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioButtonOrdByLWHWg.Checked)
			{
				var orderedListByLWHWg = boxes.OrderBy(x => x.Length).ThenBy(x => x.Width).ThenBy(x => x.Height).ThenBy(x => x.Weight);
				textBox1.Text = string.Join(Environment.NewLine,orderedListByLWHWg);

			}
			else if (radioButtonOrdByVolDesc.Checked)
			{
				var orderedList = boxes.OrderByDescending(x => x.Volume).Select(x=>$"{x.ToString() } ; V: {x.Volume}");
				textBox1.Text = string.Join(Environment.NewLine,orderedList);
			}
			else if (radioButtonGroupByWeight.Checked)
			{
				var orderedList = boxes.GroupBy(x => x.Weight).OrderBy(x=>x.Key);
				StringBuilder sb = new StringBuilder();
				foreach (var box in orderedList)
				{
					sb.AppendLine($"{box.Key}");
					foreach (var item in box)
					{
						sb.AppendLine($"\t{item.ToString()}");
					}
				}

				textBox1.Text = sb.ToString();
			}
			else if (radioButtonAvgVolumeByWeight.Checked)
			{
				var orderedList = boxes.GroupBy(x => x.Weight).OrderBy(x => x.Key).Select(x=>$"Тегло: {x.Key};\t Среден обем:{x.Average(x=>x.Volume):f2}");
				textBox1.Text = string.Join(Environment.NewLine,orderedList);
				
			}
			else if (radioButtonMinWMinHByLen.Checked)
			{
					var orderedList = boxes.GroupBy(x => x.Length).OrderBy(x => x.Key).Select(x=>$"Дължина: {x.Key};\t Мин. ширина:{x.Min(x=>x.Width)}; Мин. височина:{x.Min(x=>x.Height)}");
				textBox1.Text = string.Join(Environment.NewLine,orderedList);
				
			}
			else if (radioButtonMaxWgMinWgParcels.Checked)
			{
				var orderedList = boxes.GroupBy(x => x.Weight).OrderBy(x=>x.Key);

				StringBuilder minbox = new StringBuilder();
				StringBuilder maxbox = new StringBuilder();
					foreach (var box in orderedList.Where(x=>x.Max(x=>x.Weight)==orderedList.Max(x=>x.Key)))
				{
					minbox.AppendLine($"{box.Key}");
					foreach (var item in box)
					{
						minbox.AppendLine($"{item.ToString()}");
					}
				}
				foreach (var box in orderedList.Where(x=>x.Min(x=>x.Weight)==orderedList.Min(x=>x.Key)))
				{
					minbox.AppendLine($"{box.Key}");
					foreach (var item in box)
					{
						minbox.AppendLine($"{item.ToString()}");
					}
				}
			
				textBox1.Text = $"{minbox.ToString()}";
			}
			else if (radioButtonNumParcelsByHeight.Checked)
			{
				var orderedList = boxes.GroupBy(x => x.Height).OrderBy(x=>x.Key).Select(x=>$"{x.Key}\t{x.Count()}");
				textBox1.Text = string.Join(Environment.NewLine,orderedList);
			}
			else if (radioButtonSumWgtByLen.Checked)
			{
				var orderedList = boxes.GroupBy(x => x.Length).OrderBy(x=>x.Key).Select(x=>$"{x.Key}\t{x.Sum(x=>x.Weight)}");
				textBox1.Text = string.Join(Environment.NewLine,orderedList);
			}
		}
	}
}
