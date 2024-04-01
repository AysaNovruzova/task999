namespace task_999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static Student CreateStudent()
            {
                Console.Write("Tələbənin tam adını daxil et: ");
                string fullName = Console.ReadLine();
                Console.Write("Tələbənin qrup nömrəsini daxil et: ");
                string groupNo = Console.ReadLine();
                Console.Write("Tələbənin orta ballını daxil et: ");
                double avgPoint = Convert.ToDouble(Console.ReadLine());
                return new Student { FullName = fullName, GroupNo = groupNo, AvgPoint = avgPoint };
            }

            static Group CreateGroup()
            {
                string groupNo;
                while (true)
                {
                    Console.Write("AB475 ");
                    groupNo = Console.ReadLine();
                    if (groupNo.Length == 5 && Char.IsLetter(groupNo[0]) && Char.IsLetter(groupNo[1]) && Char.IsDigit(groupNo[2]) && Char.IsDigit(groupNo[3]) && Char.IsDigit(groupNo[4]))
                        break;
                    else
                        Console.WriteLine("Düzgün formatda qrup nömrəsini daxil et.");
                }

                int studentLimit;
                while (true)
                {
                    Console.Write("Qrupun tələbə limitini daxil edin (0-20): ");
                    studentLimit = Convert.ToInt32(Console.ReadLine());
                    if (studentLimit >= 0 && studentLimit <= 20)
                        break;
                    else
                        Console.WriteLine("Tələbə limiti 0-dan kiçik və ya 20-dən böyük ola bilməz.");
                }

                return new Group(groupNo, studentLimit);
            }

            static void Main(string[] args)
            {
                Group group = CreateGroup();

                while (true)
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Tələbə əlavə et");
                    Console.WriteLine("2. Bütün tələbələrə bax");
                    Console.WriteLine("3. Tələbələr üzrə axtarış et");
                    Console.WriteLine("0. Proqramı bitir");

                    Console.Write("Seçiminizi daxil edin: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Student student = CreateStudent();
                            group.AddStudent(student);
                            break;
                        case "2":
                            for (int i = 0; i < group.StudentCount; i++)
                            {
                                Console.WriteLine($"{group.Students[i].FullName} - Qrup: {group.Students[i].GroupNo}, Ortalama bali: {group.Students[i].AvgPoint}");
                            }
                            break;
                        case "3":
                            Console.Write("Axtardığın tələbənin adını daxil et: ");
                            string searchName = Console.ReadLine();
                            for (int i = 0; i < group.StudentCount; i++)
                            {
                                if (group.Students[i].FullName.ToLower().Contains(searchName.ToLower()))
                                {
                                    Console.WriteLine($"{group.Students[i].FullName} - Qrup: {group.Students[i].GroupNo}, Ortalama bali: {group.Students[i].AvgPoint}");
                                }
                            }
                            break;
                        case "0":
                            Console.WriteLine("Proqram bitdi.");
                            return;
                        default:
                            Console.WriteLine("Yanlış seçim. Düzgün daxilb et.");
                            break;
                    }
                }
            }
        }
    }
}
