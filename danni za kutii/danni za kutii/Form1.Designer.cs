
namespace danni_za_kutii
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
			this.listBoxStartList = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.radioButtonNumParcelsByHeight = new System.Windows.Forms.RadioButton();
			this.radioButtonSumWgtByLen = new System.Windows.Forms.RadioButton();
			this.radioButtonMinWMinHByLen = new System.Windows.Forms.RadioButton();
			this.radioButtonMaxWgMinWgParcels = new System.Windows.Forms.RadioButton();
			this.radioButtonAvgVolumeByWeight = new System.Windows.Forms.RadioButton();
			this.radioButtonOrdByVolDesc = new System.Windows.Forms.RadioButton();
			this.radioButtonGroupByWeight = new System.Windows.Forms.RadioButton();
			this.radioButtonOrdByLWHWg = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(281, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Начален списък";
			// 
			// listBoxStartList
			// 
			this.listBoxStartList.FormattingEnabled = true;
			this.listBoxStartList.ItemHeight = 15;
			this.listBoxStartList.Location = new System.Drawing.Point(60, 43);
			this.listBoxStartList.Name = "listBoxStartList";
			this.listBoxStartList.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listBoxStartList.Size = new System.Drawing.Size(516, 94);
			this.listBoxStartList.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(340, 172);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(430, 206);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(342, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Резултат";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.radioButtonNumParcelsByHeight);
			this.panel1.Controls.Add(this.radioButtonSumWgtByLen);
			this.panel1.Controls.Add(this.radioButtonMinWMinHByLen);
			this.panel1.Controls.Add(this.radioButtonMaxWgMinWgParcels);
			this.panel1.Controls.Add(this.radioButtonAvgVolumeByWeight);
			this.panel1.Controls.Add(this.radioButtonOrdByVolDesc);
			this.panel1.Controls.Add(this.radioButtonGroupByWeight);
			this.panel1.Controls.Add(this.radioButtonOrdByLWHWg);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(12, 166);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(296, 272);
			this.panel1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(121, 246);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// radioButtonNumParcelsByHeight
			// 
			this.radioButtonNumParcelsByHeight.AutoSize = true;
			this.radioButtonNumParcelsByHeight.Location = new System.Drawing.Point(22, 195);
			this.radioButtonNumParcelsByHeight.Name = "radioButtonNumParcelsByHeight";
			this.radioButtonNumParcelsByHeight.Size = new System.Drawing.Size(207, 19);
			this.radioButtonNumParcelsByHeight.TabIndex = 13;
			this.radioButtonNumParcelsByHeight.TabStop = true;
			this.radioButtonNumParcelsByHeight.Text = "Брой пратки с еднакви височини";
			this.radioButtonNumParcelsByHeight.UseVisualStyleBackColor = true;
			this.radioButtonNumParcelsByHeight.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// radioButtonSumWgtByLen
			// 
			this.radioButtonSumWgtByLen.AutoSize = true;
			this.radioButtonSumWgtByLen.Location = new System.Drawing.Point(22, 220);
			this.radioButtonSumWgtByLen.Name = "radioButtonSumWgtByLen";
			this.radioButtonSumWgtByLen.Size = new System.Drawing.Size(287, 19);
			this.radioButtonSumWgtByLen.TabIndex = 12;
			this.radioButtonSumWgtByLen.TabStop = true;
			this.radioButtonSumWgtByLen.Text = "Суми от теглата на пратките според дължините";
			this.radioButtonSumWgtByLen.UseVisualStyleBackColor = true;
			// 
			// radioButtonMinWMinHByLen
			// 
			this.radioButtonMinWMinHByLen.AutoSize = true;
			this.radioButtonMinWMinHByLen.Location = new System.Drawing.Point(22, 145);
			this.radioButtonMinWMinHByLen.Name = "radioButtonMinWMinHByLen";
			this.radioButtonMinWMinHByLen.Size = new System.Drawing.Size(311, 19);
			this.radioButtonMinWMinHByLen.TabIndex = 11;
			this.radioButtonMinWMinHByLen.TabStop = true;
			this.radioButtonMinWMinHByLen.Text = "Минимална ширина и височина според дължината";
			this.radioButtonMinWMinHByLen.UseVisualStyleBackColor = true;
			// 
			// radioButtonMaxWgMinWgParcels
			// 
			this.radioButtonMaxWgMinWgParcels.AutoSize = true;
			this.radioButtonMaxWgMinWgParcels.Location = new System.Drawing.Point(22, 170);
			this.radioButtonMaxWgMinWgParcels.Name = "radioButtonMaxWgMinWgParcels";
			this.radioButtonMaxWgMinWgParcels.Size = new System.Drawing.Size(270, 19);
			this.radioButtonMaxWgMinWgParcels.TabIndex = 10;
			this.radioButtonMaxWgMinWgParcels.TabStop = true;
			this.radioButtonMaxWgMinWgParcels.Text = "Пратките с максимално и минимално тегло";
			this.radioButtonMaxWgMinWgParcels.UseVisualStyleBackColor = true;
			// 
			// radioButtonAvgVolumeByWeight
			// 
			this.radioButtonAvgVolumeByWeight.AutoSize = true;
			this.radioButtonAvgVolumeByWeight.Location = new System.Drawing.Point(22, 120);
			this.radioButtonAvgVolumeByWeight.Name = "radioButtonAvgVolumeByWeight";
			this.radioButtonAvgVolumeByWeight.Size = new System.Drawing.Size(184, 19);
			this.radioButtonAvgVolumeByWeight.TabIndex = 9;
			this.radioButtonAvgVolumeByWeight.TabStop = true;
			this.radioButtonAvgVolumeByWeight.Text = "Среден обем според теглото";
			this.radioButtonAvgVolumeByWeight.UseVisualStyleBackColor = true;
			// 
			// radioButtonOrdByVolDesc
			// 
			this.radioButtonOrdByVolDesc.AutoSize = true;
			this.radioButtonOrdByVolDesc.Location = new System.Drawing.Point(22, 70);
			this.radioButtonOrdByVolDesc.Name = "radioButtonOrdByVolDesc";
			this.radioButtonOrdByVolDesc.Size = new System.Drawing.Size(241, 19);
			this.radioButtonOrdByVolDesc.TabIndex = 8;
			this.radioButtonOrdByVolDesc.TabStop = true;
			this.radioButtonOrdByVolDesc.Text = "Подреждане по обем в намаляващ ред";
			this.radioButtonOrdByVolDesc.UseVisualStyleBackColor = true;
			// 
			// radioButtonGroupByWeight
			// 
			this.radioButtonGroupByWeight.AutoSize = true;
			this.radioButtonGroupByWeight.Location = new System.Drawing.Point(22, 95);
			this.radioButtonGroupByWeight.Name = "radioButtonGroupByWeight";
			this.radioButtonGroupByWeight.Size = new System.Drawing.Size(134, 19);
			this.radioButtonGroupByWeight.TabIndex = 7;
			this.radioButtonGroupByWeight.TabStop = true;
			this.radioButtonGroupByWeight.Text = "Групиране по тегло";
			this.radioButtonGroupByWeight.UseVisualStyleBackColor = true;
			// 
			// radioButtonOrdByLWHWg
			// 
			this.radioButtonOrdByLWHWg.AutoSize = true;
			this.radioButtonOrdByLWHWg.Location = new System.Drawing.Point(22, 45);
			this.radioButtonOrdByLWHWg.Name = "radioButtonOrdByLWHWg";
			this.radioButtonOrdByLWHWg.Size = new System.Drawing.Size(309, 19);
			this.radioButtonOrdByLWHWg.TabIndex = 6;
			this.radioButtonOrdByLWHWg.TabStop = true;
			this.radioButtonOrdByLWHWg.Text = "Подреждане по дължина, ширина, височина, тегло";
			this.radioButtonOrdByLWHWg.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Начален списък";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listBoxStartList);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBoxStartList;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButtonNumParcelsByHeight;
		private System.Windows.Forms.RadioButton radioButtonSumWgtByLen;
		private System.Windows.Forms.RadioButton radioButtonMinWMinHByLen;
		private System.Windows.Forms.RadioButton radioButtonMaxWgMinWgParcels;
		private System.Windows.Forms.RadioButton radioButtonAvgVolumeByWeight;
		private System.Windows.Forms.RadioButton radioButtonOrdByVolDesc;
		private System.Windows.Forms.RadioButton radioButtonGroupByWeight;
		private System.Windows.Forms.RadioButton radioButtonOrdByLWHWg;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}

