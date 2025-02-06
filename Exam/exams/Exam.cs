using Exam.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.exams
{
    public abstract class Exam
    {
        #region property
        public int Duration { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }
        public int TotalMarks { get; set; }

        #endregion
        #region constructor
        protected Exam(int duration, int numberOfQuestions)
        {
            Duration = duration;
            NumberOfQuestions = numberOfQuestions;
            Questions = new List<Question>();
            TotalMarks = 0;
        }
        #endregion

        #region method
        public abstract void ShowExam();
        public abstract void StartExam();
        #endregion
    }
}
//

    

   


