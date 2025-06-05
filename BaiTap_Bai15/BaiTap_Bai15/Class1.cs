using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Bai15
{
    abstract class phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string newphone);
        public abstract void SearchPhone(string name);
        public abstract void Sort();
    }

    class PhoneBook : phone
    {
        private Dictionary<string, List<string>> PhoneList = new Dictionary<string, List<string>>();

        public override void InsertPhone(string name, string phone)
        {
            if (PhoneList.ContainsKey(name))
            {
                if (!PhoneList[name].Contains(phone))
                {
                    PhoneList[name].Add(phone);
                }
            }
            else
            {
                PhoneList[name] = new List<string> { phone };
            }
        }

        public override void RemovePhone(string name)
        {
            PhoneList.Remove(name);
        }

        public override void UpdatePhone(string name, string newphone)
        {
            if (PhoneList.ContainsKey(name))
            {
                PhoneList[name].Clear();
                PhoneList[name].Add(newphone);
            }
        }

        public override void SearchPhone(string name)
        {
            if (PhoneList.ContainsKey(name))
            {
                Console.WriteLine($"Name: {name}, SDT: {string.Join(", ", PhoneList[name])}");
            }
            else
            {
                Console.WriteLine("Khong tim thay so dien thoai");
            }
        }

        public override void Sort()
        {
            var sorted = new SortedDictionary<string, List<string>>(PhoneList);
            PhoneList = new Dictionary<string, List<string>>(sorted);
            Console.WriteLine("Danh ba da duoc xap xep");
        }
    }

}
