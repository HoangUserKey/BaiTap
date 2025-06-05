using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Thi
{

    class DocGia
    {
        public string Ten { get; }
        public List<Sach> DanhSachSachMuon { get; }

        public DocGia(string ten)
        {
            Ten = ten;
            DanhSachSachMuon = new List<Sach>();
        }
        public void MuonSach(Sach sach)
        {
            if (DanhSachSachMuon.Count < 3)
                DanhSachSachMuon.Add(sach);
        }
        public void TraHetSach()
        {
            DanhSachSachMuon.Clear();
        }
    }
    class Sach
    {
        public string Ten { get; }

        public Sach(string ten)
        {
            Ten = ten;
        }
    }


    class QuanLyMuonSach
    {
        static List<DocGia> danhSachDocGia = new List<DocGia>();
        static void MuonSach()
        {
            Console.Write("Nhap ten doc gia: ");
            string ten = Console.ReadLine();
            DocGia docGia = danhSachDocGia.Find(dg => dg.Ten == ten);

            // Nếu độc giả chưa có, thêm mới vào danh sách
            if (docGia == null)
            {
                docGia = new DocGia(ten);
                danhSachDocGia.Add(docGia);
            }

            // Kiểm tra nếu đã mượn đủ 3 sách
            if (docGia.DanhSachSachMuon.Count >= 3)
            {
                Console.WriteLine("Ban da muon toi da 3 quyen sach khac nhau. Hay tra sach truoc khi muon tiep.");
                return;
            }

            Console.Write("Nhap ten sach muon: ");
            string tenSach = Console.ReadLine();

            // Kiểm tra nếu sách đã được mượn trước đó
            if (docGia.DanhSachSachMuon.Exists(s => s.Ten == tenSach))
            {
                Console.WriteLine("Ban da muon sach nay roi! Vui long chon quyen sach khac.");
                return;
            }

            // Nếu hợp lệ, thêm sách vào danh sách mượn
            Sach sach = new Sach(tenSach);
            docGia.MuonSach(sach);
            Console.WriteLine($"Da muon sach: {tenSach}");
        }

        static void TraSach()
        {
            Console.Write("Nhap ten doc gia: ");
            string ten = Console.ReadLine();
            DocGia docGia = danhSachDocGia.Find(dg => dg.Ten == ten);

            if (docGia == null || docGia.DanhSachSachMuon.Count == 0)
            {
                Console.WriteLine("Ban khong co sach de tra.");
                return;
            }

            docGia.TraHetSach();
            Console.WriteLine("Tra sach thanh cong!");
        }

        static void ThongKe()
        {
            Console.WriteLine($"So luong nguoi muon sach trong ngay: {danhSachDocGia.Count}");
            Dictionary<string, int> thongKeSach = new Dictionary<string, int>();

            foreach (var docGia in danhSachDocGia)
            {
                foreach (var sach in docGia.DanhSachSachMuon)
                {
                    if (thongKeSach.ContainsKey(sach.Ten))
                        thongKeSach[sach.Ten]++;
                    else
                        thongKeSach[sach.Ten] = 1;
                }
            }

            Console.WriteLine("The loai sach duoc ua thich:");
            foreach (var sach in thongKeSach)
            {
                Console.WriteLine($"- {sach.Key}: {sach.Value} luot muon");
            }
        }




        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\nQUAN LY MUON SACH");
                Console.WriteLine("1. Muon sach");
                Console.WriteLine("2. Tra sach");
                Console.WriteLine("3. Thong ke");
                Console.WriteLine("4. Thoat");
                Console.Write("Ban chin chuc nang: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: MuonSach(); break;
                    case 2: TraSach(); break;
                    case 3: ThongKe(); break;
                    case 4: return;
                    default: Console.WriteLine("Lua chon khong hop le"); break;
                }
            }

        }

    }
}
 
