using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuaTiengViet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> questions = new Dictionary<string, string>()
        {
            { "Cay to la nho truyen hien non \n         An va ban lay tien ma tieu la cay gi?", "Cay tre" },
            { "Qua gi do tua bong hong\nTrong trang co dom den trong nhu me là qua gi?", "Thanh Long" },
            { "Con gi sing mui moc sung minh mac ao giap khoe khong ai bang la con gi?", "Te giac" }
        };

            Console.WriteLine("CHAO MUNG BAN DEN VOI VUA TIENG VIET");
            int score = 0;

            foreach (var question in questions)
            {
                Console.WriteLine("Cau hoi: " + question.Key);
                Console.Write("Tra loi: ");
                string answer = Console.ReadLine();

                if (answer.Trim().Equals(question.Value, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("dung!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Sai! Dap an dung la: " + question.Value);
                }
            }

            Console.WriteLine($"Ban da tra loi dung {score}/{questions.Count} cau hoi.");
            Console.WriteLine("Cam on ban da choi");

        }
    }
}
