using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Questions
{
    [Serializable]
    public class Question
    {
        public string _Question { get; set; } // Вопрос
        public List<string> Answers { get; set; } // Ответы
        public int[] Correct { get; set; } // Верные ответы
        public double MaxScore { get; set; } // Максимально баллов за один вопрос
        public Question(string q, string[] answ, int cor)
        {
            _Question = q;
            Correct = new int[] { cor };
            Answers = new List<string>(answ);
            MaxScore = 1;
        }

        public Question(string q, int max_score, string[] answ, int cor)
        {
            _Question = q;
            Correct = new int[] { cor };
            Answers = new List<string>(answ);
            MaxScore = max_score;
        }

        public Question(string q, string[] answ, params int[] cor)
        {
            _Question = q;
            Correct = cor;
            Answers = new List<string>(answ);
            MaxScore = 1;
        }

        public Question(string q, int max_score, string[] answ, params int[] cor)
        {
            _Question = q;
            Correct = cor;
            Answers = new List<string>(answ);
            MaxScore = max_score;
        }
     
    }
}
