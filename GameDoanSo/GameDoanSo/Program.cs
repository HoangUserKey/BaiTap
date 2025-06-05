using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDoanSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int soNgauNhien = rnd.Next(1,101);

            int doan;
            int luot = 0;

            int maxDiem = 100;
            int truDiem = 20;

            //cong diem
            int ThoiGianCong = 3;
            int CongDiem = 2000;
            bool DoanDung = false;
            int diemSo = maxDiem;

            Console.WriteLine("TRO CHOI DOAN SO");
            Console.WriteLine("Hay thu doan 1 so ngau nhien tu 1 den 100");

            DateTime dateTime = DateTime.Now;

            while (diemSo > 0)
            {
                Console.Write("Nhap so cua ban: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input,out doan))
                {
                    Console.WriteLine("Vui long nhap mot so hop le");
                    continue;
                }
                luot++;
                if (doan < soNgauNhien)
                {
                    Console.WriteLine("Sai roi! Hay thu so lon hon");
                    diemSo = Math.Max(diemSo - truDiem, 0);
                    Console.WriteLine($"BAN BI TRU {truDiem} DIEM. DIEM HIEN TAI CUA BAN LA: {diemSo}");
                    Console.WriteLine();

                }
                else if(doan > soNgauNhien)
                {
                    Console.WriteLine("Sai roi! Hay thu so nho hon");
                    diemSo = Math.Max(diemSo - truDiem, 0);
                    Console.WriteLine($"BAN BI TRU {truDiem} DIEM. DIEM HIEN TAI CUA BAN LA: {diemSo}");
                    Console.WriteLine();
                }
                else
                {
                    DoanDung = true;
                    TimeSpan ts = DateTime.Now - dateTime;
                    //int truThoiGian = (int)ts.TotalSeconds * 10;
                    //int diem = Math.Max(maxDiem - (luot * truDiem), 0);

                    if (ts.TotalSeconds <= CongDiem)
                    {
                        diemSo += CongDiem;
                        Console.WriteLine($"Ban doan dung trong {ts.TotalSeconds:F2} giay.BAN DUOC CONG THEM 2000 DIEM");
                    }



                    Console.WriteLine();
                    Console.WriteLine($"Chuc mung! BAN DA DOAN DUNG  sau {luot} lan doan");
                    Console.WriteLine($"Thoi gian hoan thanh: {ts.TotalSeconds:F2} giay.");
                    Console.WriteLine($"Diem so cua ban dat duoc: {diemSo}");

                }
            }
            // Kiểm tra nếu điểm giảm xuống 0, kết thúc trò chơi
            if (diemSo == 0)
            {
                Console.WriteLine();
                Console.WriteLine("*************************|| GAME OVER ||*************************");
                return;
            }

        }
    }
}
