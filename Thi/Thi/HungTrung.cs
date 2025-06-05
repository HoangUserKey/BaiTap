using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thi
{
    class HungTrung
    {
        static int basketPosition = 10;
        static int eggPositionX = new Random().Next(0, 20);
        static int eggPositionY = 0;

        static int score = 18;
        static int heath = 5;
        static int maxHeath = 10;

        static int eggSpeed = 200; // Ban đầu trứng rơi chậm
        static int highScore = 0;
        static bool gameOver = false;

        public static void Game()
        {
            Console.CursorVisible = false;
            while (!gameOver)
            {
                Console.Clear();


                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"|| Diem: {score} || So luot: {heath} ||");

                Console.SetCursorPosition(eggPositionX, eggPositionY);
                Console.Write("O");
                Console.SetCursorPosition(basketPosition, 20);
                Console.Write("[__]");

                eggPositionY++;

                if (eggPositionY == 20)
                {
                    if (eggPositionX >= basketPosition && eggPositionX < basketPosition + 3)
                    {
                        score++;
                        Console.WriteLine();
                        Console.WriteLine("\nGood!");

                        // **Tăng tốc độ rơi nếu đạt mốc điểm 5, 10, 15...**
                        if (score % 5 == 0)
                        {
                            eggSpeed = Math.Max(50, eggSpeed - 20); // Giảm thời gian nghỉ giữa các lần rơi, làm trứng rơi nhanh hơn
                            Console.WriteLine();
                            Console.WriteLine("\nTang Toc!");
                        }

                        // Thưởng thêm mạng nếu đạt mốc điểm 20, 40, 60...
                        if (score % 20 == 0 && heath < maxHeath)
                        {
                            heath++;
                            Console.WriteLine();
                            Console.WriteLine("\n+1 luot");
                        }
                    }
                    else
                    {
                        heath--;
                        Console.WriteLine();
                        Console.WriteLine("\nHung truot roi!");
                    }

                    if (score > highScore)
                    {
                        highScore = score;
                    }

                    if (heath <= 0)
                    {
                        Console.WriteLine("\n-------------------- | GAME OVER! | --------------------");
                        Console.WriteLine($"---------------- | Ban duoc: {highScore} diem | -----------------");

                        gameOver = true;
                    }

                    eggPositionX = new Random().Next(0, 20);
                    eggPositionY = 0;
                }

                Thread.Sleep(eggSpeed);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.LeftArrow && basketPosition > 0)
                        basketPosition--;
                    else if (key.Key == ConsoleKey.RightArrow && basketPosition < 17)
                        basketPosition++;
                }
            }
        }
    }

}
