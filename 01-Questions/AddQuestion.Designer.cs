namespace _01_Questions
{
    partial class AddQuestion
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
            this.BAddQuestion = new System.Windows.Forms.Button();
            this.TQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BAddAnswer = new System.Windows.Forms.Button();
            this.TAnswer1 = new System.Windows.Forms.TextBox();
            this.TAnswer2 = new System.Windows.Forms.TextBox();
            this.Correct1 = new System.Windows.Forms.CheckBox();
            this.Correct2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBMaxScore = new System.Windows.Forms.ComboBox();
            this.BCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAddQuestion
            // 
            this.BAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddQuestion.Location = new System.Drawing.Point(151, 270);
            this.BAddQuestion.Name = "BAddQuestion";
            this.BAddQuestion.Size = new System.Drawing.Size(93, 42);
            this.BAddQuestion.TabIndex = 0;
            this.BAddQuestion.Text = "Добавить";
            this.BAddQuestion.UseVisualStyleBackColor = true;
            this.BAddQuestion.Click += new System.EventHandler(this.BAddQuestion_Click);
            // 
            // TQuestion
            // 
            this.TQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TQuestion.Location = new System.Drawing.Point(12, 32);
            this.TQuestion.Multiline = true;
            this.TQuestion.Name = "TQuestion";
            this.TQuestion.Size = new System.Drawing.Size(325, 26);
            this.TQuestion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите вопрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ответы:";
            // 
            // BAddAnswer
            // 
            this.BAddAnswer.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddAnswer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BAddAnswer.Location = new System.Drawing.Point(43, 150);
            this.BAddAnswer.Name = "BAddAnswer";
            this.BAddAnswer.Size = new System.Drawing.Size(30, 30);
            this.BAddAnswer.TabIndex = 10;
            this.BAddAnswer.Text = "+";
            this.BAddAnswer.UseVisualStyleBackColor = true;
            this.BAddAnswer.Click += new System.EventHandler(this.BAddAnswer_Click);
            // 
            // TAnswer1
            // 
            this.TAnswer1.Location = new System.Drawing.Point(12, 90);
            this.TAnswer1.Name = "TAnswer1";
            this.TAnswer1.Size = new System.Drawing.Size(100, 20);
            this.TAnswer1.TabIndex = 2;
            // 
            // TAnswer2
            // 
            this.TAnswer2.Location = new System.Drawing.Point(12, 120);
            this.TAnswer2.Name = "TAnswer2";
            this.TAnswer2.Size = new System.Drawing.Size(100, 20);
            this.TAnswer2.TabIndex = 3;
            // 
            // Correct1
            // 
            this.Correct1.AutoSize = true;
            this.Correct1.Location = new System.Drawing.Point(117, 92);
            this.Correct1.Name = "Correct1";
            this.Correct1.Size = new System.Drawing.Size(15, 14);
            this.Correct1.TabIndex = 7;
            this.Correct1.UseVisualStyleBackColor = true;
            // 
            // Correct2
            // 
            this.Correct2.AutoSize = true;
            this.Correct2.Location = new System.Drawing.Point(117, 124);
            this.Correct2.Name = "Correct2";
            this.Correct2.Size = new System.Drawing.Size(15, 14);
            this.Correct2.TabIndex = 8;
            this.Correct2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(148, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Максимальное количество баллов за вопрос:";
            // 
            // CBMaxScore
            // 
            this.CBMaxScore.FormattingEnabled = true;
            this.CBMaxScore.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CBMaxScore.Location = new System.Drawing.Point(151, 124);
            this.CBMaxScore.Name = "CBMaxScore";
            this.CBMaxScore.Size = new System.Drawing.Size(121, 21);
            this.CBMaxScore.TabIndex = 9;
            // 
            // BCancel
            // 
            this.BCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCancel.Location = new System.Drawing.Point(250, 270);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(93, 42);
            this.BCancel.TabIndex = 12;
            this.BCancel.Text = "Отмена";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 324);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.CBMaxScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Correct2);
            this.Controls.Add(this.Correct1);
            this.Controls.Add(this.TAnswer2);
            this.Controls.Add(this.TAnswer1);
            this.Controls.Add(this.BAddAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TQuestion);
            this.Controls.Add(this.BAddQuestion);
            this.Name = "AddQuestion";
            this.Text = "Добавление вопроса";
            this.Resize += new System.EventHandler(this.AddQuestion_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAddQuestion;
        private System.Windows.Forms.TextBox TQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BAddAnswer;
        private System.Windows.Forms.TextBox TAnswer1;
        private System.Windows.Forms.TextBox TAnswer2;
        private System.Windows.Forms.CheckBox Correct1;
        private System.Windows.Forms.CheckBox Correct2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBMaxScore;
        private System.Windows.Forms.Button BCancel;
    }
}