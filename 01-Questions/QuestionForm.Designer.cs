namespace _01_Questions
{
    partial class QuestionForm
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.BStart = new System.Windows.Forms.Button();
            this.BNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBox.Location = new System.Drawing.Point(12, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(412, 298);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Visible = false;
            // 
            // BStart
            // 
            this.BStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStart.Location = new System.Drawing.Point(113, 121);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(163, 78);
            this.BStart.TabIndex = 0;
            this.BStart.Text = "Start";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // BNext
            // 
            this.BNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BNext.Location = new System.Drawing.Point(325, 316);
            this.BNext.Name = "BNext";
            this.BNext.Size = new System.Drawing.Size(99, 33);
            this.BNext.TabIndex = 1;
            this.BNext.Text = "Next ->";
            this.BNext.UseVisualStyleBackColor = true;
            this.BNext.Visible = false;
            this.BNext.Click += new System.EventHandler(this.BNext_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 362);
            this.Controls.Add(this.BStart);
            this.Controls.Add(this.BNext);
            this.Controls.Add(this.GroupBox);
            this.Name = "QuestionForm";
            this.Text = "Тест";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button BNext;
        private System.Windows.Forms.Button BStart;
    }
}