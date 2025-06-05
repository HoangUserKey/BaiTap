using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGameRan
{
    internal class GameSoThich
    {
        public static void ThuGame()
        {
            // Tạo từ điển khớp từ khóa với thể loại game
            Dictionary<string, string> gameGenres = new Dictionary<string, string>
        {
            { "ban sung", "Hanh dong" },
            { "phieu luu", "Phieu luu" },
            { "chien thuat", "Chien thuat" },
            { "giai do", "Giai do" },
            { "mo phong", "Mo phong" }
        };

            Console.WriteLine("Nhap so thich cua ban (ví dụ: ban sung, phieu luu, chien thuat, giai do, mo phong):");
            string userInput = Console.ReadLine()?.ToLower();

            if (gameGenres.ContainsKey(userInput))
            {
                Console.WriteLine($"The loai game ohu hop voi ban la: {gameGenres[userInput]}");
            }
            else
            {
                Console.WriteLine("khong tim thay the loai game phu hop. Hay thu lai the loai khac.");
            }

        }
    }





    class OChuBiMat
    {
        public static void BiMat()
        {
            string[] wordList = { "Tran Viet Hoang", "Lap trinh C#", "Tro choi thu vi" }; // Danh sách câu bí mật
            int score = 0;
            foreach (var originalSecretWord in wordList)
            {
                string secretWord = originalSecretWord.Replace(" ", "").ToLower();
                // string secretWord = "Tran Viet Hoang"; // Từ bí mật
                HashSet<char> guessedLetters = new HashSet<char>(); // Lưu chữ cái đã đoán
                int maxAttempts = 6; // Số lần đoán sai tối đa
                int wrongAttempts = 0; // Số lần đoán sai

                Random random = new Random();
                int hintCount = Math.Max(1, secretWord.Length / 4); // Số chữ gợi ý (khoảng 25% số chữ)
                while (guessedLetters.Count < hintCount)
                {
                    guessedLetters.Add(secretWord[random.Next(secretWord.Length)]);
                }


                Console.WriteLine("Chao mun den vs tro choi bi mat");
                Console.WriteLine($"Ban co {maxAttempts} lan doan truoc khi thua.");

                while (true)
                {
                    DisplayWord(secretWord, guessedLetters);

                    Console.Write("\nNhap chu cai cau ban: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input) || input.Length > 1)
                    {
                        Console.WriteLine("Vui lòng nhập một ký tự hợp lệ!");
                        continue;
                    }


                    char guess = input[0];


                    if (guessedLetters.Contains(guess))
                    {
                        Console.WriteLine("Ban da doan chu nay truoc do. Thu chu khac!");
                        continue;
                    }

                    guessedLetters.Add(guess);

                    if (secretWord.Contains(guess))
                    {
                        Console.WriteLine("Good! ban da doan dung.");
                    }
                    else
                    {
                        wrongAttempts++;
                        Console.WriteLine($"Sai ! Ban con {maxAttempts - wrongAttempts} lan doan.");
                    }

                    if (IsWordGuessed(secretWord, guessedLetters))
                    {
                        Console.WriteLine($"Chuc mung Ban da doan dung tu bi mat: {secretWord}");
                        score++;
                        break;
                    }

                    if (wrongAttempts >= maxAttempts)
                    {
                        Console.WriteLine($"Ban da het luot doan. Tu bi mat là: {secretWord}");
                        Console.WriteLine("GAME OVER");
                        return;
                    }
                }

            }
            

        }

        static void DisplayWord(string originalWord, HashSet<char> guessedLetters)
        {
            foreach (char c in originalWord)
            {
                if (c == ' ')
                {
                    Console.Write("  "); // Giữ khoảng trắng để dễ đọc
                }
                else if (guessedLetters.Contains(char.ToLower(c)))
                {
                    Console.Write(c + " "); // Hiển thị chữ cái đã đoán đúng
                }
                else
                {
                    Console.Write("_ "); // Hiển thị dấu gạch nếu chưa đoán được
                }
            }
            Console.WriteLine();
        }

        /// Kiểm tra xem tất cả các ký tự trong từ bí mật đã được đoán chưa.
    
        /// <param /name = "word" > Từ bí mật không có dấu cách.</param>
        /// <param /name = "guessedLetters" > Danh sách chữ cái đã đoán.</param>
        /// <returns>true nếu toàn bộ từ đã đoán đúng, ngược lại false.</returns>
        static bool IsWordGuessed(string word, HashSet<char> guessedLetters)
        {
            return word.All(c => guessedLetters.Contains(c));
        }



    }
}
