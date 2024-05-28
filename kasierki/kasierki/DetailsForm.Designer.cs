namespace kasierki
{
    partial class DetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxNum = new TextBox();
            textBoxName = new TextBox();
            textBoxSal = new TextBox();
            textBoxExperience = new TextBox();
            textBoxSuppl = new TextBox();
            buttonPrev = new Button();
            buttonNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 0;
            label1.Text = "Данни за касиер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(187, 90);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 1;
            label2.Text = "No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(176, 125);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 2;
            label4.Text = "Име";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(147, 160);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 3;
            label6.Text = "Заплата";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(170, 195);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 3;
            label7.Text = "Стаж";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(142, 230);
            label8.Name = "label8";
            label8.Size = new Size(78, 21);
            label8.TabIndex = 3;
            label8.Text = "Добавка";
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(241, 87);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.ReadOnly = true;
            textBoxNum.Size = new Size(62, 29);
            textBoxNum.TabIndex = 4;
            textBoxNum.TextChanged += textBox1_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(241, 122);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(392, 29);
            textBoxName.TabIndex = 4;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSal
            // 
            textBoxSal.Location = new Point(241, 157);
            textBoxSal.Name = "textBoxSal";
            textBoxSal.ReadOnly = true;
            textBoxSal.Size = new Size(141, 29);
            textBoxSal.TabIndex = 4;
            textBoxSal.TextChanged += textBox1_TextChanged;
            // 
            // textBoxExperience
            // 
            textBoxExperience.Location = new Point(241, 192);
            textBoxExperience.Name = "textBoxExperience";
            textBoxExperience.ReadOnly = true;
            textBoxExperience.Size = new Size(92, 29);
            textBoxExperience.TabIndex = 4;
            textBoxExperience.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSuppl
            // 
            textBoxSuppl.Location = new Point(241, 227);
            textBoxSuppl.Name = "textBoxSuppl";
            textBoxSuppl.ReadOnly = true;
            textBoxSuppl.Size = new Size(141, 29);
            textBoxSuppl.TabIndex = 4;
            textBoxSuppl.TextChanged += textBox1_TextChanged;
            // 
            // buttonPrev
            // 
            buttonPrev.Location = new Point(241, 316);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(158, 40);
            buttonPrev.TabIndex = 5;
            buttonPrev.Text = "Предишен запис";
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(472, 316);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(151, 40);
            buttonNext.TabIndex = 5;
            buttonNext.Text = "Следващ запис";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 410);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrev);
            Controls.Add(textBoxSuppl);
            Controls.Add(textBoxExperience);
            Controls.Add(textBoxSal);
            Controls.Add(textBoxName);
            Controls.Add(textBoxNum);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "DetailsForm";
            Text = "DetailsForm";
            Load += DetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxNum;
        private TextBox textBoxName;
        private TextBox textBoxSal;
        private TextBox textBoxExperience;
        private TextBox textBoxSuppl;
        private Button buttonPrev;
        private Button buttonNext;
    }
}