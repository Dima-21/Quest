using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Questions
{
    public partial class AddQuestion : Form
    {
        public Dictionary<TextBox, CheckBox> TextAnswers = new Dictionary<TextBox, CheckBox>();
        public Question NewQuestion
        {
            get
            {
                return new Question(TQuestion.Text, MaxScore, Answers, Corrects);
            }
        }

        public String[] Answers
        {
            get { return TextAnswers.Select(x => x.Key.Text).ToArray(); }
        }

        public int[] Corrects
        {
            get
            {
                List<int> x = new List<int>();
                for (int i = 0; i < TextAnswers.Count; i++)
                {
                    if (TextAnswers.ElementAt(i).Value.Checked)
                        x.Add(i+1);
                }
                return x.ToArray();
            }
        }

        public int MaxScore
        {
            get
            {
                return Convert.ToInt32(CBMaxScore.SelectedItem);
            }
        }

        public AddQuestion()
        {
            InitializeComponent();
            TextAnswers.Add(this.TAnswer1, this.Correct1);
            TextAnswers.Add(this.TAnswer2, this.Correct2);
        }

        private void AddQuestion_Resize(object sender, EventArgs e)
        {
            this.BCancel.Location = new Point(this.ClientSize.Width - BCancel.Width - 10, ClientSize.Height - BCancel.Height - 10);
            this.BAddQuestion.Location = new Point(BCancel.Location.X - BAddQuestion.Size.Width - 5, ClientSize.Height - BAddQuestion.Height - 10);
        }

        private void NewAnswer()
        {
            TextBox newAnswer = new TextBox();
            newAnswer.Location = new Point(TextAnswers.Last().Key.Location.X, TextAnswers.Last().Key.Location.Y + 30);
            newAnswer.Size = new Size(100, 20);
            newAnswer.TabIndex = TextAnswers.Last().Key.TabIndex + 1;
            newAnswer.Parent = this;
            newAnswer.Show();

            CheckBox newCheckBox = new CheckBox();
            newCheckBox.Location = new Point(newAnswer.Location.X + newAnswer.Size.Width + 5, newAnswer.Location.Y);
            newCheckBox.Parent = this;
            newCheckBox.Show();
            TextAnswers.Add(newAnswer, newCheckBox);

            this.BAddAnswer.Location = new Point(newAnswer.Location.X + newAnswer.Size.Width / 2 - this.BAddAnswer.Size.Width, newAnswer.Location.Y + 30);
            this.BRemoveAnswer.Location = new Point( BAddAnswer.Location.X + this.BRemoveAnswer.Size.Width +5, BAddAnswer.Location.Y);
        }

        private void BAddAnswer_Click(object sender, EventArgs e)
        {
            if (TextAnswers.Count > 4)
                BAddAnswer.Enabled = false;
            BRemoveAnswer.Enabled = true;
            NewAnswer();
        }

        private void BAddQuestion_Click(object sender, EventArgs e)
        {
            if (Check())
                this.DialogResult = DialogResult.OK;
            else
                this.TextError.Visible = true;
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BRemoveAnswer_Click(object sender, EventArgs e)
        {
            if (TextAnswers.Count > 2)
            {
                BAddAnswer.Enabled = true;
                TextAnswers.Last().Key.Visible = false;
                TextAnswers.Last().Value.Visible = false;
                TextAnswers.Remove(TextAnswers.Last().Key);
                this.BAddAnswer.Location = new Point(TextAnswers.Last().Key.Location.X + TextAnswers.Last().Key.Size.Width / 2 - this.BAddAnswer.Size.Width, TextAnswers.Last().Key.Location.Y + 30);
                this.BRemoveAnswer.Location = new Point(BAddAnswer.Location.X + this.BRemoveAnswer.Size.Width + 5, BAddAnswer.Location.Y);
            }
            if(TextAnswers.Count < 3)
                BRemoveAnswer.Enabled = false;
        }
        private bool Check()
        {
            if (this.TQuestion.Text == "")
                return false;
          
            try
            {
                if (TextAnswers.Where(x => x.Key.Text == "").Count() > 0)
                    return false;
                if (TextAnswers.Where(x => x.Value.Checked == true).Count() == 0)
                    return false;
            }
            catch(Exception e)
            { return true; }
            return true;
        }
    }
}
