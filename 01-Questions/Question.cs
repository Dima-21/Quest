using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Questions
{
    class Question
    {
        public string question { get; set; }
        public List<string> answers { get; set; }
        public int[] correct { get; set; }
        public Question(string q, string[] answ, int cor)
        {
            question = q;
            correct = new int[] { cor };
            answers = new List<string>(answ);
        }

        public Question(string q, string[] answ, params int[] cor)
        {
            question = q;
            correct = cor;
            answers = new List<string>(answ);
        }
    }
}
