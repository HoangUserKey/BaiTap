using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Bai15
{
    interface INews
    {
        void Display();
    }

    class News : INews
    {
        List<int> RateList = new List<int>();
        public int ID {  get; set; }
        public string titl {  get; set; }
        public string PublishDate {  get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public float AverageRate { get; private set; }

        public News() { }
        public News(int iD, string titl, string publishDate, string author, string content )
        {
            ID = iD;
            this.titl = titl;
            PublishDate = publishDate;
            Author = author;
            Content = content;

        }

        public void CalculateAverageRate()
        {
            if (RateList.Count > 0) {
                AverageRate = (float)RateList.Sum() / RateList.Count;
            }
        }

        public void AddRating(int rate)
        {
            RateList.Add(rate);
            CalculateAverageRate();
        }

        public void Display() {
            Console.WriteLine("ID: "+ID);
            Console.WriteLine("PublishDate: "+PublishDate);
            Console.WriteLine("Content: "+Content);
            Console.WriteLine("AverageRate: "+AverageRate);
        }
    }

    class NewManager
    {
        List<News> ListNew = new List<News>();

        public void InsertNew()
        {
            Console.WriteLine("Nhap ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Nhap PublishDate: ");
            string publishDate = Console.ReadLine();
            Console.WriteLine("Nhap Author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Nhap Content: ");
            string content = Console.ReadLine();

            News news = new News(id,title,publishDate,author,content);
            ListNew.Add(news);
            Console.WriteLine("Them thanh cong");
        }

        public void ViewListNew()
        {
            if (ListNew.Count == 0)
            {
                Console.WriteLine("danh sach trong");
            }
            foreach (var v in ListNew)
            {
                v.Display();
            }
        }
        public void RateNews()
        {
            Console.Write("Nhap id tintuc can danh gia: ");
            int id = int.Parse(Console.ReadLine());

            var news = ListNew.Find(n => n.ID == id);
            if (news != null)
            {
                Console.Write("Nhhap danh gia: ");
                int rate = int.Parse(Console.ReadLine());
                news.AddRating(rate);
                Console.WriteLine("danh gia thanh cong");
            }
            else
            {
                Console.WriteLine("khong tim thay tin tuc");
            }
        }

    }
}
