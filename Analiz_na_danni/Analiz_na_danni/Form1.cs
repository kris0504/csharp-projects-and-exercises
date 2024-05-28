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

namespace Analiz_na_danni
{
	public partial class Form1 : Form
	{
		List<Movie> movies;
		public Form1()
		{
			InitializeComponent();
			movies = new List<Movie>();
			LoadMovies();
		}
		private void LoadMovies()
		{
			StreamReader sr = new StreamReader("data.txt");
			while (true)
			{
				string oneLine = sr.ReadLine();
				if (oneLine==null)
				{
					sr.Close();
					break;
				}
				movies.Add(new Movie(oneLine));

			}
			listBoxStartList.DataSource = movies;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (radioButtonOrdByYearTitle.Checked)
			{
				var orderedMovies= movies.OrderBy(x=>x.Year).ThenBy(x=>x.Title).Select(x=>x.ToString()).ToList();
				textBoxResult.Text = string.Join(Environment.NewLine, orderedMovies);
			}
			else if(radioButtonOrdByWords.Checked)
			{
				var orderedMovies= movies.OrderBy(x=> x.CountOfWords).ThenBy(x=>x.Title).Select(x=>x.ToString()).ToList();
				textBoxResult.Text = string.Join(Environment.NewLine, orderedMovies);
			}
			else if (radioButtonNumMoviesByYears.Checked)
			{
				var result = movies.GroupBy(x => x.Year).OrderBy(x=>x.Key).Select(x => $"Година: {x.Key}\t Брой филми:{x.Count()} ").ToList();
				textBoxResult.Text = string.Join(Environment.NewLine, result);

			}
			else if(radioButtonNumMoviesByStLetter.Checked)
			{
				var result = movies.GroupBy(x => x.Title[0]).OrderBy(x=>x.Key).Select(x => $"Буква: {x.Key}\t Брой филми:{x.Count()} ").ToList();
				textBoxResult.Text = string.Join(Environment.NewLine, result);
			}
			else if (radioButtonAvgNumWrdByStLetter.Checked)
			{
					var result = movies.GroupBy(x => x.Title[0]).OrderBy(x=>x.Key).Select(x => $"Буква: {x.Key}\t Среден брой думи:{x.Average(x=>x.CountOfWords):f1} ").ToList();
				textBoxResult.Text = string.Join(Environment.NewLine, result);
			}
			else if (radioButtonMaxMoviesYears.Checked)
			{
				var maxMovies = movies.GroupBy(x => x.Year).Select(x => x.Count()).Max();
				var result = movies.GroupBy(x => x.Year).OrderBy(x => x.Key).Where(x => x.Count() == maxMovies)
							.Select(x => $"Година: {x.Key}\t Брой:{x.Count()}");
				textBoxResult.Text = string.Join(Environment.NewLine, result);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
