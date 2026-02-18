namespace InstituteApp;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("ВФ ВолГУ");
        Console.WriteLine("Группа ПМИ-231");
        Console.WriteLine();
        Student iluha = new Student("Ilya", "Kolbasenko", 11, "Standoff2");
        Student ivan = new Student("Ivan", "Zolochevsky", 21, "TWITCHSTRIMER");
        ivan.Introduce();
        ivan.Study();
        iluha.Introduce();
        iluha.Study();
    }
}