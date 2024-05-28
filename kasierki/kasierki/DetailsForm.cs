using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasierki
{
    public partial class DetailsForm : Form
    {
        Cashier[] cashiers;
        int n;
        public DetailsForm()
        {
            InitializeComponent();
            string[] data = File.ReadAllLines("data.txt");
            cashiers = new Cashier[data.Length / 3];
            string[] thirdline;
            for (int i = 0; i < cashiers.Length; i++)
            {
                thirdline = data[i * 3 + 2].Split(' ');
                cashiers[i] = new Cashier
                {
                    Id = int.Parse(data[i * 3]),
                    Name = data[i * 3 + 1],
                    Salary = int.Parse(thirdline[0]),
                    Experience = int.Parse(thirdline[1])


                };
            }
            n = 0;
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            ChangeData(n);

        }
        public void ChangeData(int n)
        {
            textBoxNum.Text = $"{cashiers[n].Id}";
            textBoxName.Text = $"{cashiers[n].Name}";
            textBoxSal.Text = $"{cashiers[n].Salary}";
            textBoxExperience.Text = $"{cashiers[n].Experience}";
            textBoxSuppl.Text = $"{cashiers[n].Supplement()}";
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            n++;
            ChangeData(n);
            if (n == cashiers.Length - 1)
            {
                
                buttonNext.Enabled = false;
            }
            buttonPrev.Enabled = true;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            n--;
            ChangeData(n);
            if (n ==0)
            {
                
                buttonPrev.Enabled = false;
            }
            buttonNext.Enabled = true;
        }
    }
}
