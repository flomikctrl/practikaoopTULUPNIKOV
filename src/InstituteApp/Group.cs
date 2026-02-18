namespace InstituteApp {
    class Group {
        public string GroupName;
        public string Direction;
        public List<Student> Students;

        public Group(string groupname, string direction) {
            GroupName = groupname;
            Direction = direction;
            Students = new List<Student>();
        }

        public void AddStudent(Student student) {
            Students.Add(student);
            Console.WriteLine($"✔✔✔ Студент {student.FirstName} {student.LastName} добавлен в группу {GroupName}");
        }

        public void ShowAllStudents() {
            Console.WriteLine($"Студенты группы {GroupName}");
            Console.WriteLine($"Направления {Direction}");
            for (int i = 0; i < Students.Count; i++) {
                Console.Write($"{i+1}.");
                Students[i].Introduce();
            }
        }

        public void ShowCount() {
            Console.WriteLine($"Всего студентов в группе {GroupName}: {Students.Count}");
        }
    }
}