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
namespace klasirane
{
	public partial class Form1 : Form
	{
		Student[] students;
		public Form1()
		{
			InitializeComponent();
			string[] data = File.ReadAllLines("data.txt");
			students = new Student[data.Length / 3];
			for (int i = 0; i < students.Length; i++)
			{
				students[i] = new Student
				{
					StId = int.Parse(data[i * 3]),
					StName = data[i * 3 + 1],
					Points = int.Parse(data[i * 3 + 2])
				};
			}
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text=="")
			{
				textBox2.Text = string.Join(Environment.NewLine, from s in students
																 select $"N:{s.StId}; Ime: {s.StName}; Polucheni tochki: {s.Points} ");
			}
			else
			{
				var result = from s in students
							 group s by s.Points into grp
							 orderby grp.Key descending
							 select grp;
				int countOfGroups = result.Count();
				int nthResult = int.Parse(textBox1.Text);
				if (nthResult<1||nthResult>countOfGroups)
				{
					textBox2.Text = "Невалидна стойност!";
					return;

				}
				var searchedGroup = result.ElementAt(nthResult - 1);
				textBox2.Text = string.Join(Environment.NewLine, from s in searchedGroup
																 select $"N:{s.StId}; Ime: {s.StName}; Poluchil: {s.Points};");
			}
		}
	}
}
