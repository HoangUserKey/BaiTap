using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiecNonKiDIeu
{
    class MagicWheelGame
    {
        static string[] words = { "VIETNAM", "QuaTao", "Code", "LapTrinh" };
        static Random rand = new Random();
        static int playerScore = 0;

        static void Main()
        {
            string word = words[rand.Next(words.Length)];
            char[] hiddenWord = new string('_', word.Length).ToCharArray();
            Console.WriteLine("CHAO MUNG BAN DEN VOI CHIEC NON KI DIEU");

            while (new string(hiddenWord) != word)
            {
                Console.WriteLine($"\nTu can doan: {new string(hiddenWord)}");
                Console.WriteLine($"Diem hien tai: {playerScore}");
                Console.Write("Nhap mot chu cai: ");
                char guess = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (word.Contains(guess))
                {
                    for (int i = 0; i < word.Length; i++)
                        if (word[i] == guess) hiddenWord[i] = guess;

                    Console.WriteLine("✅ Dung!");
                    playerScore += rand.Next(10, 50);
                }
                else
                {
                    Console.WriteLine("❌ Sai! Mat luot.");
                }
            }

            Console.WriteLine($"🎉 Chuc mung! Ban da doan dung: {word}");
            Console.WriteLine($"Tong diem: {playerScore}");
        }
    }

}
