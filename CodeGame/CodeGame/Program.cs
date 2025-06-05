using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>
        {
            new Question("Thu do viet nam o dau?", new string[] { "Ha Noi", "Ho Chi Minh", "Da Nang", "Hue" }, 0),
            new Question("AI la viet tat cua tu nao?", new string[] { "Artificial Intelligence", "Automated Integration", "Advanced Information", "Algorithmic Innovation" }, 0),
            new Question("Nguyen to hoa hoc nao co ky hieu la 'O'?", new string[] { "Oxy", "Vang", "Bac", "Sat" }, 0)
        };

            int score = 0;

            foreach (var q in questions)
            {
                Console.WriteLine(q.Text);
                foreach (var ans in q.Answers)
                {
                    Console.WriteLine(ans);
                }

                Console.Write("Dap an cua ban la: (1-4): ");
                int userAnswer;
                if (int.TryParse(Console.ReadLine(), out userAnswer) && userAnswer - 1 == q.CorrectAnswerIndex)
                {
                    Console.WriteLine("Chinh xac!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("Cau tra loi cua ban sai. Dap an dung la: " + q.Answers[q.CorrectAnswerIndex] + "\n");
                }
            }


            Console.WriteLine($"Ban da tra loi dung {score}/{questions.Count} Cau.");

    }
}

    class Question
    {
        public string Text { get; }
        public string[] Answers { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string text, string[] answers, int correctAnswerIndex)
        {
            Text = text;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }

}
