using DormitoryApp.Services;
using Dapper;

namespace DormitoryApp
{
    class Menu
    {
        static void Main(string[] args)
        {
            var dormitoryService = new Dormitory();
            var studentService = new Student();
            var studentRegister = new StudentRegistration();

            while (true)
            {
                Console.WriteLine("Добро пожаловать в систему общежитий!");
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Выбрать общежитие для просмотра комнат");
                Console.WriteLine("2. Найти комнату, в которой живет студент");
                Console.WriteLine("3. Найти студента по комнате");
                Console.WriteLine("4. Зарегистрировать студента");
                Console.WriteLine("5. Выйти");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("выбор 1");
                        dormitoryService.SelectDormitory();
                        break;
                    case "2":
                        Console.WriteLine("выбор 2");
                        studentService.FindStudentByName();
                        break;
                    case "3":
                        Console.WriteLine("выбор 3");
                        studentService.FindStudentsByRoom();
                        break;
                    case "4":
                        Console.WriteLine("выбор 5");
                        studentRegister.InteractiveRegisterStudent();   
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неправильный выбор. Пожалуйста, выберите существующее действие.");
                        break;
                }
            }
        }
    }
}
