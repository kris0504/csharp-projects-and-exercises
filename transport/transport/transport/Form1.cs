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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormAdd formAdd = new FormAdd();
			formAdd.Show();
		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			using (var cntx = new TransportContext())
			{
				dataGridView1.DataSource = cntx.Cities.OrderBy(x=>x.SofiaDistance).ToList();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormEdit formEdit = new FormEdit();
			formEdit.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormRemove formRemove = new FormRemove();
			formRemove.Show();
		}
	}
}
