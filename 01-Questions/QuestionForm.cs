using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _01_Questions
{
    public partial class QuestionForm : Form
    {
        List<Question> q = new List<Question>();
        List<Control> controls = new List<Control>();
        int num = 0;
        double Score = 0;

        public QuestionForm()
        {
            InitializeComponent();
            //q.Add(new Question("2+2*2=", new string[] { "2", "4", "6", "8" }, 3));
            //q.Add(new Question("Сколько байтов занимает int?", new string[] { "8", "4", "3", "6" }, 2));
            //q.Add(new Question("Число Pi", new string[] { "3.12", "3.13", "3.14", "3.15" }, 3));
            //q.Add(new Question("Сколько лет Чумаку?", new string[] { "18", "27", "25", "26" }, 3, 1));
            //Serialize();
            DeSerialize();
        }


        private void BNext_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (q.Count != num)
                    ShowQuestion(num);

                if (q.Count == num)
                    Finish();
                else
                    num++;
            }
        }
        private void Start()
        {
            num = 0;
            BNext.Visible = true;
            BStart.Visible = false;
            Question.Visible = true;
            ShowQuestion(num++);
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            Start(); 
        }
        private void ShowQuestion(int num)
        {
            var quest = q[num];
            Question.Text = quest._Question;
            foreach (var item in controls)
                item.Dispose();
            controls.Clear();
            Invalidate();
            if (quest.Correct.Length == 1)
            {
                for (int i = 0; i < quest.Answers.Count; i++)
                {
                    RadioButton rb = new RadioButton();
                    controls.Add(rb);
                    rb.Parent = this;
                    rb.Location = new Point(15, Question.Size.Height + 20 + 30 * i);
                    rb.AutoSize = true;
                    rb.Font = Question.Font;
                    rb.Text = quest.Answers[i];
                    if (quest.Correct[0]-1 == i)
                        rb.Tag = true;
                    else
                        rb.Tag = false;
                }
            }
            else
            {
                for (int i = 0; i < quest.Answers.Count; i++)
                {
                    CheckBox cb = new CheckBox();
                    controls.Add(cb);
                    cb.Parent = this;
                    cb.Location = new Point(15, Question.Size.Height + 20 + 30 * i);
                    cb.AutoSize = true;
                    cb.Font = Question.Font;
                    cb.Text = quest.Answers[i];
                    if (quest.Correct.FirstOrDefault(x=> x-1 == i) != 0)
                        cb.Tag = true;
                    else
                        cb.Tag = false;
                    cb.CheckedChanged += Cb_CheckedChanged;               
                }
            }

        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            int CountCheched = 0;
            var cb = controls.OfType<CheckBox>().ToList();
            foreach (var check in cb)
                if (check.Checked)
                    CountCheched++;
            if (q[num - 1].Correct.Length == CountCheched)
            {
                foreach (var check in cb)
                    if (!check.Checked)
                        check.Enabled = false;
            }
            else
                foreach (var check in cb)
                    check.Enabled = true;              
        }

        private bool Check()
        {
            bool check = false;
            var rb = controls.OfType<RadioButton>().ToList();
            var cb = controls.OfType<CheckBox>().ToList();
            if (cb.Count == 0)
            {
                foreach (var item in rb)
                {
                    if (item.Checked == true)
                    {
                        check = true;
                        if (item.Checked == (bool)item.Tag)
                            Score += q[num - 1].MaxScore;
                    }
                }
            }
            else
            {
                double score = q[num-1].MaxScore / q[num - 1].Correct.Length;
                foreach (var item in cb)
                {
                    if (item.Checked == true)
                    {
                        check = true;
                        if (item.Checked == (bool)item.Tag)
                            Score += score;
                    }
                }
            }
                        
            return check;
        }

        private void Finish()
        {
            MessageBox.Show($"{Score}/{ MaxScore().ToString()}");
            
        }

        private double MaxScore()
        {
            double maxscore = 0;
            foreach (var item in q)
                maxscore += item.MaxScore;         
            return maxscore;
        }

        private void Serialize()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var fs = new FileStream("Questions.quest", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, q);
            }
        }

        private void DeSerialize()
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists("Questions.quest"))
            {
                using (var fs = new FileStream("Questions.quest", FileMode.Open))
                {
                    q = bf.Deserialize(fs) as List<Question>;
                }
            }
        }

        private void QuestionForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2) ,0, Question.Location.Y+ Question.Size.Height+5, Question.Location.X+Question.Size.Width, Question.Location.Y + Question.Size.Height+5);
        }
    }
}
