using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGameRan
{
    internal class KeoBuaBao
    {
        public static void KEOBUABAO()
        {
            string[] choices = { "keo", "Bua", "Bao" };
            Random random = new Random();

            Console.WriteLine("CHAO MUNG BAN DEN VOI GAME OAN TU TI");
            Console.Write("Chon (Keo/Bua/Bao): ");
            string playerChoice = Console.ReadLine();

            if (Array.Exists(choices, choice => choice.Equals(playerChoice, StringComparison.OrdinalIgnoreCase)))
            {
                string computerChoice = choices[random.Next(choices.Length)];
                Console.WriteLine($"May chon: {computerChoice}");

                if (playerChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Hoa!");
                }
                else if ((playerChoice.Equals("Keo", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Bao")) ||
                         (playerChoice.Equals("Bua", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Keo")) ||
                         (playerChoice.Equals("Bao", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Bua")))
                {
                    Console.WriteLine("Ban thang");
                }
                else
                {
                    Console.WriteLine("Ban thua!");
                }
            }
            else
            {
                Console.WriteLine("Lua chon khong hop le. Vui long chon keo bua hoac Bao.");
            }

        }
    }
}
