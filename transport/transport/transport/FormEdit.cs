using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transport.Models;
namespace transport
{
	public partial class FormEdit : Form
	{
		TransportContext cntx = new TransportContext();
		public City GetCity { get; set; }
		public FormEdit()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
			
				 GetCity = cntx.Cities.FirstOrDefault(x => x.Destination == textBox1.Text);
				button3.Enabled = false;
			button1.Enabled = true;
				textBox3.Text = GetCity.Destination;
				textBox2.Text = $"{GetCity.SofiaDistance}";
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
				string newDest = textBox3.Text;
			int newSofiaDist =int.Parse( textBox2.Text);
			GetCity.Destination = newDest;
			GetCity.SofiaDistance = newSofiaDist;
			if (cntx.SaveChanges()==1)
			{
					button1.Enabled = false;
					button3.Enabled = true;
			}
			
			

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Dispose();
			Form1 form1 = new Form1();
			form1.Show();
		}
	}
}
