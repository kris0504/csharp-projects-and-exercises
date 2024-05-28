using System.Security.Cryptography.X509Certificates;
using System.IO;
namespace kasierki
{
    public partial class Form1 : Form
    {
        public Cashier[] cashiers { get; set; }
        DetailsForm detailsForm;
        public Form1()
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
             detailsForm = new DetailsForm();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Print(string fileName)
        {
            textBox1.Visible = true;
            textBox1.Text = string.Join(Environment.NewLine, cashiers.Select(x => $"N:{x.Id};{x.Name};Заплата: {x.Salary:f2} ; Стаж: {x.Experience};Добавка{x.Supplement():f2}"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print("data.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            detailsForm.Show();
        }
    }
}