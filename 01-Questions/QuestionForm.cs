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
    public partial class QuestionForm : Form
    {
        List<Question> q = new List<Question>();
        int num = 0;
        int correctanswers = 0;
        public QuestionForm()
        {
            InitializeComponent();
            q.Add(new Question("2+2*2=", new string[] { "2", "4", "6", "8" }, 3));
            q.Add(new Question("Сколько байтов занимает int?", new string[] { "8", "4", "3", "6" }, 2));
            q.Add(new Question("Число Pi", new string[] { "3.12", "3.13", "3.14", "3.15" }, 3));
            q.Add(new Question("Сколько лет Чумаку?", new string[] { "18", "27", "25", "26" }, 3, 2));
        }

        private void BNext_Click(object sender, EventArgs e)
        {
            if (q.Count != num)
                ShowQuestion(num);
            //Check(num-1);
            if (q.Count == num)
                Finish();
            else
                num++;
            //Answer1.Checked = Answer2.Checked = Answer3.Checked = Answer4.Checked = false;
        }

        private void ShowQuestion(int num)
        {
            GroupBox.Text = q[num].question;

            if (q[num].correct.Length == 1)
            {
                RadioButton Answer1 = new RadioButton();
                RadioButton Answer2 = new RadioButton();
                RadioButton Answer3 = new RadioButton();
                RadioButton Answer4 = new RadioButton();
                Answer1.Location = new Point(6, 40);
                Answer2.Location = new Point(6, 80);
                Answer3.Location = new Point(6, 120);
                Answer4.Location = new Point(6, 160);
                Answer1.Text = q[num].answers[0];
                Answer2.Text = q[num].answers[1];
                Answer3.Text = q[num].answers[2];
                Answer4.Text = q[num].answers[3];
                GroupBox.Controls.Add(Answer1);
            }
            else
            {
                CheckBox Answer1 = new CheckBox();
                CheckBox Answer2 = new CheckBox();
                CheckBox Answer3 = new CheckBox();
                CheckBox Answer4 = new CheckBox();
                Answer1.Location = new Point(6, 40);
                Answer2.Location = new Point(6, 80);
                Answer3.Location = new Point(6, 120);
                Answer4.Location = new Point(6, 160);
                Answer1.Text = q[num].answers[0];
                Answer2.Text = q[num].answers[1];
                Answer3.Text = q[num].answers[2];
                Answer4.Text = q[num].answers[3];
            }
  
            
        }
        

        //private void Check(int num)
        //{
        //    if (Answer1.Checked && q[num].correct == 1)
        //        correctanswers++;
        //    else if (Answer2.Checked && q[num].correct == 2)
        //        correctanswers++;
        //    else if (Answer3.Checked && q[num].correct == 3)
        //        correctanswers++;
        //    else if (Answer4.Checked && q[num].correct == 4)
        //        correctanswers++;
        //}

        private void Finish()
        {
            MessageBox.Show($"Правильных ответов: {correctanswers}/{q.Count}");
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            BNext.Visible = true;
            BStart.Visible = false;
            GroupBox.Visible = true;
            ShowQuestion(num++);
        }
    }
}
