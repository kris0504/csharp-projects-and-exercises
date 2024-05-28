
namespace Analiz_na_danni
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBoxStartList = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButtonNumMoviesByStLetter = new System.Windows.Forms.RadioButton();
			this.radioButtonNumMoviesByYears = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.radioButtonOrdByYearTitle = new System.Windows.Forms.RadioButton();
			this.radioButtonOrdByWords = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.radioButtonAvgNumWrdByStLetter = new System.Windows.Forms.RadioButton();
			this.radioButtonMaxMoviesYears = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBoxStartList
			// 
			this.listBoxStartList.FormattingEnabled = true;
			this.listBoxStartList.ItemHeight = 15;
			this.listBoxStartList.Location = new System.Drawing.Point(57, 42);
			this.listBoxStartList.Name = "listBoxStartList";
			this.listBoxStartList.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listBoxStartList.Size = new System.Drawing.Size(528, 94);
			this.listBoxStartList.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(264, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Начален списък";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.Controls.Add(this.radioButtonMaxMoviesYears);
			this.panel1.Controls.Add(this.radioButtonAvgNumWrdByStLetter);
			this.panel1.Controls.Add(this.radioButtonNumMoviesByStLetter);
			this.panel1.Controls.Add(this.radioButtonNumMoviesByYears);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.radioButtonOrdByYearTitle);
			this.panel1.Controls.Add(this.radioButtonOrdByWords);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(48, 169);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(301, 217);
			this.panel1.TabIndex = 2;
			// 
			// radioButtonNumMoviesByStLetter
			// 
			this.radioButtonNumMoviesByStLetter.AutoSize = true;
			this.radioButtonNumMoviesByStLetter.Location = new System.Drawing.Point(18, 107);
			this.radioButtonNumMoviesByStLetter.Name = "radioButtonNumMoviesByStLetter";
			this.radioButtonNumMoviesByStLetter.Size = new System.Drawing.Size(274, 19);
			this.radioButtonNumMoviesByStLetter.TabIndex = 5;
			this.radioButtonNumMoviesByStLetter.TabStop = true;
			this.radioButtonNumMoviesByStLetter.Text = "Брой филми по начална буква на заглавието";
			this.radioButtonNumMoviesByStLetter.UseVisualStyleBackColor = true;
			// 
			// radioButtonNumMoviesByYears
			// 
			this.radioButtonNumMoviesByYears.AutoSize = true;
			this.radioButtonNumMoviesByYears.Location = new System.Drawing.Point(18, 82);
			this.radioButtonNumMoviesByYears.Name = "radioButtonNumMoviesByYears";
			this.radioButtonNumMoviesByYears.Size = new System.Drawing.Size(154, 19);
			this.radioButtonNumMoviesByYears.TabIndex = 4;
			this.radioButtonNumMoviesByYears.TabStop = true;
			this.radioButtonNumMoviesByYears.Text = "Брой филми по години";
			this.radioButtonNumMoviesByYears.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(62, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Покажи информацията";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// radioButtonOrdByYearTitle
			// 
			this.radioButtonOrdByYearTitle.AutoSize = true;
			this.radioButtonOrdByYearTitle.Location = new System.Drawing.Point(18, 32);
			this.radioButtonOrdByYearTitle.Name = "radioButtonOrdByYearTitle";
			this.radioButtonOrdByYearTitle.Size = new System.Drawing.Size(231, 19);
			this.radioButtonOrdByYearTitle.TabIndex = 2;
			this.radioButtonOrdByYearTitle.TabStop = true;
			this.radioButtonOrdByYearTitle.Text = "Подреждане по година и азбучен ред";
			this.radioButtonOrdByYearTitle.UseVisualStyleBackColor = true;
			// 
			// radioButtonOrdByWords
			// 
			this.radioButtonOrdByWords.AutoSize = true;
			this.radioButtonOrdByWords.Location = new System.Drawing.Point(18, 57);
			this.radioButtonOrdByWords.Name = "radioButtonOrdByWords";
			this.radioButtonOrdByWords.Size = new System.Drawing.Size(245, 19);
			this.radioButtonOrdByWords.TabIndex = 1;
			this.radioButtonOrdByWords.TabStop = true;
			this.radioButtonOrdByWords.Text = "Подреждане по брой думи в заглавието";
			this.radioButtonOrdByWords.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(18, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Избор на възможности";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(355, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Резултат:";
			// 
			// textBoxResult
			// 
			this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxResult.Location = new System.Drawing.Point(355, 187);
			this.textBoxResult.Multiline = true;
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.ReadOnly = true;
			this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxResult.Size = new System.Drawing.Size(263, 199);
			this.textBoxResult.TabIndex = 4;
			// 
			// radioButtonAvgNumWrdByStLetter
			// 
			this.radioButtonAvgNumWrdByStLetter.AutoSize = true;
			this.radioButtonAvgNumWrdByStLetter.Location = new System.Drawing.Point(18, 132);
			this.radioButtonAvgNumWrdByStLetter.Name = "radioButtonAvgNumWrdByStLetter";
			this.radioButtonAvgNumWrdByStLetter.Size = new System.Drawing.Size(287, 19);
			this.radioButtonAvgNumWrdByStLetter.TabIndex = 6;
			this.radioButtonAvgNumWrdByStLetter.TabStop = true;
			this.radioButtonAvgNumWrdByStLetter.Text = "Среден брой думи в заглавие по начална буква";
			this.radioButtonAvgNumWrdByStLetter.UseVisualStyleBackColor = true;
			// 
			// radioButtonMaxMoviesYears
			// 
			this.radioButtonMaxMoviesYears.AutoSize = true;
			this.radioButtonMaxMoviesYears.Location = new System.Drawing.Point(18, 157);
			this.radioButtonMaxMoviesYears.Name = "radioButtonMaxMoviesYears";
			this.radioButtonMaxMoviesYears.Size = new System.Drawing.Size(230, 19);
			this.radioButtonMaxMoviesYears.TabIndex = 7;
			this.radioButtonMaxMoviesYears.TabStop = true;
			this.radioButtonMaxMoviesYears.Text = "Година/и с максимален брой филми";
			this.radioButtonMaxMoviesYears.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 450);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxStartList);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxStartList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radioButtonOrdByYearTitle;
		private System.Windows.Forms.RadioButton radioButtonOrdByWords;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxResult;
		private System.Windows.Forms.RadioButton radioButtonNumMoviesByStLetter;
		private System.Windows.Forms.RadioButton radioButtonNumMoviesByYears;
		private System.Windows.Forms.RadioButton radioButtonMaxMoviesYears;
		private System.Windows.Forms.RadioButton radioButtonAvgNumWrdByStLetter;
	}
}

