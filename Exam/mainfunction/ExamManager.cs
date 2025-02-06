using Exam.exams;
using Exam.Questions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.mainfunction
{
    public static class ExamManager
    {
        public static void CreateFinalExam()
        {
            int time, questionCount;

            // Ask for time of exam
            do
            {
                Console.WriteLine("Please enter the time for the exam (30-180 minutes):");
            } while (!int.TryParse(Console.ReadLine(), out time) || time < 30 || time > 180);

            // Ask for number of questions
            do
            {
                Console.WriteLine("Please enter the number of questions (max 5):");
            } while (!int.TryParse(Console.ReadLine(), out questionCount) || questionCount <= 0 || questionCount > 5);

            // Create final exam
            FinalExam fexam = new FinalExam(time, questionCount);
            AddQuestionsToFinalExam(fexam, questionCount);
            fexam.StartExam();
        }

        public static void CreatePracticalExam()
        {
            int time, questionCount;

            // Ask for time of practical exam
            do
            {
                Console.WriteLine("Please enter the time for the practical exam (30-180 minutes):");
            } while (!int.TryParse(Console.ReadLine(), out time) || time < 30 || time > 180);

            // Ask for number of questions
            do
            {
                Console.WriteLine("Please enter the number of questions (max 5):");
            } while (!int.TryParse(Console.ReadLine(), out questionCount) || questionCount <= 0 || questionCount > 5);

            // Create practical exam
            PracticalExam pexam = new PracticalExam(time, questionCount);
            AddQuestionsToPracticalExam(pexam, questionCount);
            pexam.StartExam();
        }

        private static void AddQuestionsToFinalExam(FinalExam exam, int questionCount)
        {
            for (int i = 0; i < questionCount; i++)
            {
                Console.WriteLine($"\nAdding Question {i + 1}:");
                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();


                int marks; 
               
                int start;
                do
                {
                    Console.Write("Enter Question Mark: ");

                } while (!int.TryParse(Console.ReadLine(), out marks) );

                // Ask for type of question
                int type;
                do
                {
                    Console.WriteLine("Please Enter the Type of Question (1 for MCQ | 2 for True | False):");
                } while (!int.TryParse(Console.ReadLine(), out type) || (type != 1 && type != 2));

                if (type == 1)
                {
                    MCQQuestion question = new MCQQuestion(body, marks);
                    Console.WriteLine("Enter answer choices:");
                    question.AnswerList = new Answer[3]; // Let's say 3 choices

                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Enter Answer {j + 1}: ");
                        string answerText = Console.ReadLine();
                        question.AnswerList[j] = new Answer(j + 1, answerText);
                    }

                    Console.Write("Please Enter the right answer id: ");
                    int correctAnswerId = int.Parse(Console.ReadLine());
                    question.CorrectAnswer = question.AnswerList[correctAnswerId - 1]; // Set correct answer

                    exam.Questions.Add(question);
                }
                else if (type == 2)
                {
                    TrueOrFalseQuestion question = new TrueOrFalseQuestion(body, marks);
                    Console.Write("Please Enter the right answer id (1 for True | 2 for False): ");
                    int correctAnswerId = int.Parse(Console.ReadLine());
                    question.CorrectAnswer = new Answer(correctAnswerId, correctAnswerId == 1 ? "True" : "False");

                    exam.Questions.Add(question);
                }
            }
        }

        private static void AddQuestionsToPracticalExam(PracticalExam exam, int questionCount)
        {
            for (int i = 0; i < questionCount; i++)
            {
                Console.WriteLine($"\nAdding Practical Question {i + 1}:");
                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark: ");
                int marks = int.Parse(Console.ReadLine());

                // Ask for type of question
                int type;
                do
                {
                    Console.WriteLine("Please Enter the Type of Question (1 for MCQ | 2 for True | False):");
                } while (!int.TryParse(Console.ReadLine(), out type) || (type != 1 && type != 2));

                if (type == 1)
                {
                    MCQQuestion question = new MCQQuestion(body, marks);
                    Console.WriteLine("Enter answer choices:");
                    question.AnswerList = new Answer[3]; // Let's say 3 choices

                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Enter Answer {j + 1}: ");
                        string answerText = Console.ReadLine();
                        question.AnswerList[j] = new Answer(j + 1, answerText);
                    }

                    Console.Write("Please Enter the right answer id: ");
                    int correctAnswerId = int.Parse(Console.ReadLine());
                    question.CorrectAnswer = question.AnswerList[correctAnswerId - 1]; // Set correct answer

                    exam.Questions.Add(question);
                }
                else if (type == 2)
                {
                    TrueOrFalseQuestion question = new TrueOrFalseQuestion(body, marks);
                    int correctAnswerId;

                    do
                    {
                        Console.Write("Please Enter the right answer id (1 for True | 2 for False): ");

                    } while (!int.TryParse(Console.ReadLine(), out correctAnswerId) || (correctAnswerId != 1 && correctAnswerId != 2));
                    question.CorrectAnswer = new Answer(correctAnswerId, correctAnswerId == 1 ? "True" : "False");

                    exam.Questions.Add(question);
                }
            }
        }
    }
}
