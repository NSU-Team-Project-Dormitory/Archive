using Dapper;
using Npgsql;
using System;

namespace DormitoryApp
{
    public class StudentRegistration
    {
        private NpgsqlConnection _databaseConnection;
        private string _connectionString;

        public StudentRegistration()
        {
            _connectionString = "Host=localhost;Username=elizavetazhitnik;Password=;Database=DormitoryDataBase";
            _databaseConnection = new NpgsqlConnection(_connectionString);
        }

        public void InteractiveRegisterStudent()
        {
            Console.WriteLine("Введите имя студента:");
            string std_name = Console.ReadLine();

            Console.WriteLine("Введите номер общежития для заселения:");
            string dormitory_number = Console.ReadLine();

            Console.WriteLine("Введите номер комнаты студента:");
            string room = Console.ReadLine();

            Console.WriteLine("Введите номер договора студента:");
            string treaty = Console.ReadLine();

            Console.WriteLine("Введите срок действия договора:");
            string contractual_effect = Console.ReadLine();

            Console.WriteLine("Введите факультет студента:");
            string faculty = Console.ReadLine();

            Console.WriteLine("Есть ли у студента замечания?:");
            string remarks = Console.ReadLine();

            Console.WriteLine("Есть ли у студента заявления?:");
            string declaration = Console.ReadLine();

            RegisterStudent(std_name, dormitory_number, room, treaty, contractual_effect, faculty, remarks, declaration);
        }

        public void RegisterStudent(string std_name, string dormitory_number, string room, string treaty, string contractual_effect, string faculty, string remarks, string declaration)
        {
            // Создаем новую модель студента
            var humanstudent = new HumanStudent { Name = std_name, DormitoryNumber = dormitory_number, Room = room, Treaty = treaty, Contractual_effect = contractual_effect, Faculty = faculty, Remarks = remarks, Declaration = declaration };

            // Затем сохраняем его в базу данных
            SaveStudentToDatabase(humanstudent);
            Console.WriteLine($"Студент {std_name} успешно зарегистрирован в комнате {room}.");
        }


        private void SaveStudentToDatabase(HumanStudent student)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                // Используем Dapper для выполнения запроса
                connection.Execute("INSERT INTO students(std_name, dormitory_number, room, treaty, contractual_effect, faculty, remarks, declaration) VALUES (@Name, @DormitoryNumber, @Room, @Treaty, @Contractual_effect, @Faculty, @Remarks, @Declaration)", student);

                connection.Close();
            }
        }
    }
}
