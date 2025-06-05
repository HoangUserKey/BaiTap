using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ran
{
    class SnakeGame
    {
        static List<(int x, int y)> snake = new List<(int, int)> { (10, 10) };
        static (int x, int y) food = (15, 10);
        static int direction = 1; // 0: Left, 1: Right, 2: Up, 3: Down
        static bool isRunning = true;
        static int score = 0;

        static void Main()
        {
            Console.CursorVisible = false;
            while (isRunning)
            {
                Draw();
                Update();
                Thread.Sleep(100);
            }
            Console.Clear();
            Console.WriteLine("Game Over!");
            Console.WriteLine($"Diem cua ban: {score}");
            Console.WriteLine();

        }

        static void Draw()
        {
            Console.Clear();
            foreach (var part in snake)
            {
                Console.SetCursorPosition(part.x, part.y);
                Console.Write("*");
            }
            Console.SetCursorPosition(food.x, food.y);
            Console.Write("o");
        }

        static void Update()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.LeftArrow && direction != 1) direction = 0;
                if (key == ConsoleKey.RightArrow && direction != 0) direction = 1;
                if (key == ConsoleKey.UpArrow && direction != 3) direction = 2;
                if (key == ConsoleKey.DownArrow && direction != 2) direction = 3;
            }

            var head = snake[0];
            (int x, int y) newHead = head;
            if (direction == 0) newHead.x--;
            if (direction == 1) newHead.x++;
            if (direction == 2) newHead.y--;
            if (direction == 3) newHead.y++;

            if (newHead.x < 0 || newHead.x >= Console.WindowWidth || newHead.y < 0 || newHead.y >= Console.WindowHeight || snake.Contains(newHead))
            {
                isRunning = false;
                return;
            }

            snake.Insert(0, newHead);
            if (newHead == food)
            {
                Random rnd = new Random();
                food = (rnd.Next(0, Console.WindowWidth), rnd.Next(0, Console.WindowHeight));
                score++;
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }
        }
    }

}