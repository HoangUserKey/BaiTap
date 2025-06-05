using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngVienTuyenDung
{
    abstract class CandidateFilter
    {
        public abstract bool IsQualified(Candidate candidate);
    }

    // Lớp lọc danh sách Ưu tiên
    class PriorityListFilter : CandidateFilter
    {
        public override bool IsQualified(Candidate candidate) =>
            candidate.OverallScore >= 8 && candidate.Skill >= 6 &&
            candidate.Experience >= 7 && candidate.Education >= 9;
    }

    // Lớp lọc danh sách Chờ
    class WaitingListFilter : CandidateFilter
    {
        public override bool IsQualified(Candidate candidate) =>
            candidate.OverallScore >= 7 && candidate.Skill >= 7 &&
            candidate.Experience >= 8 && candidate.Education >= 6;
    }

    // Lớp lọc danh sách Tiềm năng
    class PotentialListFilter : CandidateFilter
    {
        public override bool IsQualified(Candidate candidate) =>
            candidate.OverallScore >= 8 && candidate.Skill >= 9 &&
            candidate.Experience >= 5 && candidate.Education >= 8;
    }

    // Lớp đại diện cho ứng viên
    class Candidate
    {
        public string Name { get; }
        public int Age { get; }
        public string Gender { get; }
        public int OverallScore { get; }
        public int Skill { get; }
        public int Experience { get; }
        public int Education { get; }
        public string Department { get; }

        public Candidate(string name, int age, string gender, int overallScore, int skill, int experience, int education, string department)
        {
            Name = name;
            Age = age;
            Gender = gender;
            OverallScore = overallScore;
            Skill = skill;
            Experience = experience;
            Education = education;
            Department = department;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Department: {Department}");
            Console.WriteLine();
            Console.WriteLine($"OverallScore: {OverallScore}, Skill: {Skill},Experience: {Experience}, Education: {Education}");
            Console.WriteLine();
        }

    }

    class Manager
    {
        public static void manager() {
            List<Candidate> candidates = new List<Candidate>();

            Console.Write("Nhap so luong ung vien: ");
            int candidateCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < candidateCount; i++)
            {
                Console.WriteLine($"\nNhap thong tin ung vien thu {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Gender: ");
                string gender = Console.ReadLine();
                Console.Write("OverallScore: ");
                int overallScore = int.Parse(Console.ReadLine());
                Console.Write("Skill: ");
                int skill = int.Parse(Console.ReadLine());
                Console.Write("Experience: ");
                int experience = int.Parse(Console.ReadLine());
                Console.Write("Education: ");
                int education = int.Parse(Console.ReadLine());
                Console.Write("Department: ");
                string department = Console.ReadLine();

                candidates.Add(new Candidate(name, age, gender, overallScore, skill, experience, education, department));
            }

            List<(string, CandidateFilter)> filters = new List<(string, CandidateFilter)>
        {
            ("Uu tien", new PriorityListFilter()),
            ("Cho", new WaitingListFilter()),
            ("Tiem nang", new PotentialListFilter())


        };
            
            Console.WriteLine("\nKet qua loc ung vien:");
            foreach (var candidate in candidates)
            {

                candidate.ShowInfo();
                foreach (var (category, filter) in filters)
                {
                    if (filter.IsQualified(candidate))
                    {
                        Console.WriteLine($"{candidate.Name} thuoc danh sach {category}");
                        break;
                    }
                }
            }


        }
    }
}
