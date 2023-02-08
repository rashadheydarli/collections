using System;
namespace collection
{
    public class Program
    {
        static void Main()
        {
            List<Group> groups = new List<Group>();
            var group = new Group
            {
                Name = "Rashad",
            };
            AddGroup(groups, group);

            var group1 = new Group
            {
                Name = "Rashad",
            };
            AddGroup(groups, group1);

            foreach (var listGroup in groups)
            {
                Console.WriteLine(listGroup.GetDetails());
            }

        }

        static void AddGroup(List<Group> groups, Group group)
        {
            var isDuplicatedName = groups.Any(n => n.Name == group.Name);
            if (!isDuplicatedName)
            {
                groups.Add(group);
            }
        }

    }

    public class Group
    {
        public string Name { get; set; }

        public string GetDetails()
        {
            return $" Name: {Name}";
        }
    }
}

//using System;
//namespace collection
//{
//    public class Program
//    {
//        static void Main()
//        {
//            List<Student> students = new List<Student>();
//            var student = new Student
//            {
//                Name = "Rashad",
//                Surname = "Heydarli",
//                PIN = 123,
//            };
//            AddStudent(students, student);
//            CountA(students, student);

//            var student1 = new Student
//            {
//                Name = "Eli",
//                Surname="Nabiyev",
//                PIN=456,
//            };
//            AddStudent(students, student1);

//            foreach (var listStudent in students)
//            {
//                Console.WriteLine(listStudent.GetDetails());
//            }

//            static void AddStudent(List<Student> students, Student student)
//            {
//                var isDuplicatedPIN = students.Any(p => p.PIN == student.PIN);
//                if (!isDuplicatedPIN)
//                {
//                    students.Add(student);
//                }
//            }
//            static void CountA(List<Student> students, Student student)
//            {

//                //int count = 0;


//                var isContainA = students.Any(a => a.Name == 'a');
//                if (isContainA)
//                {
//                    count++;
//                }
//            }

//        }
//    }
//    public class Student
//    {
//        public string Name { get; set; }
//        public string Surname { get; set; }
//        public int PIN { get; set; }

//        public string  GetDetails()
//        {
//             return $"Name: {Name}, Surname: {Surname}, Pin: {PIN}\n Count: {count}";
//        }
//    }
//}



