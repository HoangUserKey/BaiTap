using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    internal class SinhVien
    {
        public string Ten { get; set; }
        public int MaSV { get; set; }
        private double DiemToan;
        private double DiemLy;
        private double DiemHoa;

        public SinhVien() { }

        public SinhVien(string ten, int maSV)
        {
            Ten = ten;
            MaSV = maSV;
        }

        public void NhapDiem(double toan, double ly, double hoa)
        {
            DiemToan = toan;
            DiemLy = ly;
            DiemHoa = hoa;
        }

        public double TinhDiemTongKet()
        {
            return DiemToan + DiemLy + DiemHoa;
        }

        public string XetHocLuc()
        {
            double diemTongKet = TinhDiemTongKet();
            if (diemTongKet >= 29) return "Xuat sac";
            if (diemTongKet >= 27) return "Gioi";
            if (diemTongKet >= 24) return "Kha";
            if (diemTongKet >= 20) return "Trung binh";
            return "Yeu";
        }

        public static void xapXep()
        {

            // Khởi tạo đối tượng SV1 theo 3 cách
            //SinhVien SV1 = new SinhVien();
            //SinhVien SV2 = new SinhVien("Nguyen Van a", 12345);
            //SinhVien SV3;
            //SV3 = new SinhVien("Tran Van B", 67890);

            //// Nhập điểm cho SV1
            //SV1.NhapDiem(9, 8.5, 8);

            //// Tính điểm tổng kết của SV1z
            //double diemTongKet = SV1.TinhDiemTongKet();
            //Console.WriteLine($"Diem TK SV1: {diemTongKet}");

            //// Xét học lực của SV1
            //Console.WriteLine($"Hoc Luc cua SV1: {SV1.XetHocLuc()}");


            List<SinhVien> danhSachSinhVien = new List<SinhVien>();

            // Nhập thông tin sinh viên từ bàn phím
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Nhap thong tin sinh vien {i + 1}: ");
                Console.Write("ho ten: ");
                string ten = Console.ReadLine();
                Console.Write("MSV: ");
                int maSV = int.Parse(Console.ReadLine());
                Console.Write("Điem Toan: ");
                double diemToan = double.Parse(Console.ReadLine());
                Console.Write("Điem ly: ");
                double diemLy = double.Parse(Console.ReadLine());
                Console.Write("Điem hoa: ");
                double diemHoa = double.Parse(Console.ReadLine());

                SinhVien sv = new SinhVien(ten, maSV);
                sv.NhapDiem(diemToan, diemLy, diemHoa);
                sv.TinhDiemTongKet();
                sv.XetHocLuc();
                danhSachSinhVien.Add(sv);
            }

            // Sắp xếp danh sách sinh viên theo điểm tổng kết (giảm dần)
            danhSachSinhVien.Sort((sv1, sv2) => sv2.TinhDiemTongKet().CompareTo(sv1.TinhDiemTongKet()));

            // Hiển thị danh sách sau khi sắp xếp
            Console.WriteLine("Danh sach sinh sau khi sap xep:");
            foreach (var sv in danhSachSinhVien)
            {
                
                Console.WriteLine($"{sv.Ten} - diem tong ket: {sv.TinhDiemTongKet()}");
                Console.WriteLine("Hoc Luc: "+sv.XetHocLuc());
            }
            
        }
    }
}
