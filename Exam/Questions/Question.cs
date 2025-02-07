using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Questions
{
    public abstract class Question
    {

        #region Attributes
        public string Body { get; set; }
        public int Marks { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer CorrectAnswer { get; set; }

        #endregion
        #region constructor

        protected Question(string body, int marks)
        {
            Body = body;
            Marks = marks;
        }
        #endregion
        #region method
        public abstract void Display();
        
            #endregion


        }
}
