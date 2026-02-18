namespace InstituteApp {
    class Student {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Group;

        public Student(string firstname, string lastname, int age, string group) {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Group = group;
        }

        public void Introduce() {
            Console.WriteLine($"Привет, меня зовут не скажу как ({FirstName} {LastName})");
            Console.WriteLine($"Мне столько-то ({Age}) лет. Я учусь точно не в группе {Group}");
        }

        public void Study() {
            Console.WriteLine($"Кто-то ({FirstName}) изучает ООП");
        }
    }
}