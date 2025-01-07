using FirstClassApp;

Person student1 = new Person();
student1.Name = "Botan";
student1.LastName = "Elveren";
student1.BirthOfDate = "30.06.1990";

Console.WriteLine($"Student1: {student1.Name} {student1.LastName} {student1.BirthOfDate}");

Person student2 = new Person();
student2.Name = "Mehmet";
student2.LastName = "Elveren";
student2.BirthOfDate = "1.02.1970"; 

Console.WriteLine($"Student2: {student2.Name} {student2.LastName} {student2.BirthOfDate}");

Person teacher1 = new Person();
teacher1.Name = "Ali";
teacher1.LastName = "Kaya";
teacher1.BirthOfDate = "1.02.1980";

Console.WriteLine($"Teacher1: {teacher1.Name} {teacher1.LastName} {teacher1.BirthOfDate}");

Person teacher2 = new Person();
teacher2.Name = "Veli";
teacher2.LastName = "Kahraman";
teacher2.BirthOfDate = "1.02.1973";

Console.WriteLine($"Teacher1: {teacher1.Name} {teacher1.LastName} {teacher1.BirthOfDate}");