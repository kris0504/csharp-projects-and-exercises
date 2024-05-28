
namespace test_reklama
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.radioButtonOverDouble = new System.Windows.Forms.RadioButton();
			this.radioButtonSpravka = new System.Windows.Forms.RadioButton();
			this.radioButtonAvgByMonth = new System.Windows.Forms.RadioButton();
			this.radioButtonSort = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(247, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(331, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Реализирани продажби в резултат от рекламна дейност";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.radioButtonOverDouble);
			this.panel1.Controls.Add(this.radioButtonSpravka);
			this.panel1.Controls.Add(this.radioButtonAvgByMonth);
			this.panel1.Controls.Add(this.radioButtonSort);
			this.panel1.Location = new System.Drawing.Point(51, 108);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(306, 247);
			this.panel1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 34);
			this.button1.TabIndex = 2;
			this.button1.Text = "Покажи справката!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(33, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Справки";
			// 
			// radioButtonOverDouble
			// 
			this.radioButtonOverDouble.AutoSize = true;
			this.radioButtonOverDouble.Location = new System.Drawing.Point(29, 128);
			this.radioButtonOverDouble.Name = "radioButtonOverDouble";
			this.radioButtonOverDouble.Size = new System.Drawing.Size(225, 19);
			this.radioButtonOverDouble.TabIndex = 0;
			this.radioButtonOverDouble.TabStop = true;
			this.radioButtonOverDouble.Text = "Над удвоената минимална стойност\r\n";
			this.radioButtonOverDouble.UseVisualStyleBackColor = true;
			// 
			// radioButtonSpravka
			// 
			this.radioButtonSpravka.AutoSize = true;
			this.radioButtonSpravka.Location = new System.Drawing.Point(29, 103);
			this.radioButtonSpravka.Name = "radioButtonSpravka";
			this.radioButtonSpravka.Size = new System.Drawing.Size(204, 19);
			this.radioButtonSpravka.TabIndex = 0;
			this.radioButtonSpravka.TabStop = true;
			this.radioButtonSpravka.Text = "Справка за януари [10000, 20000]";
			this.radioButtonSpravka.UseVisualStyleBackColor = true;
			// 
			// radioButtonAvgByMonth
			// 
			this.radioButtonAvgByMonth.AutoSize = true;
			this.radioButtonAvgByMonth.Location = new System.Drawing.Point(29, 78);
			this.radioButtonAvgByMonth.Name = "radioButtonAvgByMonth";
			this.radioButtonAvgByMonth.Size = new System.Drawing.Size(256, 19);
			this.radioButtonAvgByMonth.TabIndex = 0;
			this.radioButtonAvgByMonth.TabStop = true;
			this.radioButtonAvgByMonth.Text = "Средна стойност на приходите по месеци";
			this.radioButtonAvgByMonth.UseVisualStyleBackColor = true;
			// 
			// radioButtonSort
			// 
			this.radioButtonSort.AutoSize = true;
			this.radioButtonSort.Location = new System.Drawing.Point(29, 53);
			this.radioButtonSort.Name = "radioButtonSort";
			this.radioButtonSort.Size = new System.Drawing.Size(226, 19);
			this.radioButtonSort.TabIndex = 0;
			this.radioButtonSort.TabStop = true;
			this.radioButtonSort.Text = "Сортиране по месеци и по стойност\r\n";
			this.radioButtonSort.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(377, 132);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(333, 222);
			this.textBox1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(381, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 15);
			this.label3.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(471, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 15);
			this.label4.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(611, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 15);
			this.label5.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton radioButtonOverDouble;
		private System.Windows.Forms.RadioButton radioButtonSpravka;
		private System.Windows.Forms.RadioButton radioButtonAvgByMonth;
		private System.Windows.Forms.RadioButton radioButtonSort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

