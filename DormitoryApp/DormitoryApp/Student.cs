using Npgsql;

namespace DormitoryApp.Services
{
    public class Student
    {
        private NpgsqlConnection _databaseConnection;

        public Student()
        {
            string connectionString = "Host=localhost;Username=elizavetazhitnik;Password=;Database=DormitoryDataBase";
            _databaseConnection = new NpgsqlConnection(connectionString);
        }

        public void FindStudentByName()
        {
            string dormitory_number = "";
            bool dormitory_chosen = false;

            do
            {
                Console.WriteLine("Введите название общежития:");
                dormitory_number = Console.ReadLine();
                _databaseConnection.Open();  

                using var cmd = new NpgsqlCommand("SELECT * FROM students WHERE dormitory_number = @dormitory_number", _databaseConnection);
                cmd.Parameters.AddWithValue("dormitory_number", dormitory_number);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine($"Общежитие {dormitory_number} выбрано.");
                        dormitory_chosen = true;
                    }
                    else
                    {
                        Console.WriteLine("Общежитие с таким названием не найдено.");
                    }
                }
                _databaseConnection.Close();  

            } while (!dormitory_chosen);

            bool student_found = false;

            do
            {
                Console.WriteLine("Введите имя студента или 'back' для перехода обратно в меню:");
                string std_name = Console.ReadLine();

                if (std_name.ToLower() == "back")
                {
                    dormitory_chosen = false;
                    break;
                }

                _databaseConnection.Open();  
                using var cmd2 = new NpgsqlCommand("SELECT room FROM students WHERE std_name = @std_name AND dormitory_number = @dormitory_number", _databaseConnection);
                cmd2.Parameters.AddWithValue("std_name", std_name);
                cmd2.Parameters.AddWithValue("dormitory_number", dormitory_number);

                using (var reader2 = cmd2.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        string room = reader2.GetString(0);
                        Console.WriteLine($"Студент {std_name} живет в комнате номер {room}.");
                        student_found = true;
                    }
                    else
                    {
                        Console.WriteLine($"Студент с именем {std_name} не найден.");
                    }
                }
                _databaseConnection.Close();   

            } while (!student_found && dormitory_chosen);
        }

        public void FindStudentsByRoom()
        {
            string dormitory_number = "";
            bool dormitory_chosen = false;

            do
            {
                Console.WriteLine("Введите название общежития:");
                dormitory_number = Console.ReadLine();

                _databaseConnection.Open();   
                using var cmd = new NpgsqlCommand("SELECT * FROM students WHERE dormitory_number = @dormitory_number", _databaseConnection);
                cmd.Parameters.AddWithValue("dormitory_number", dormitory_number);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine($"Общежитие {dormitory_number} выбрано.");
                        dormitory_chosen = true;
                    }
                    else
                    {
                        Console.WriteLine("Общежитие с таким названием не найдено.");
                    }
                }
                _databaseConnection.Close();  

            } while (!dormitory_chosen);

            bool room_found = false;

            do
            {
                Console.WriteLine("Введите номер комнаты или 'back' для возврата в меню:");
                string room = Console.ReadLine();

                if (room.ToLower() == "back")
                {
                    dormitory_chosen = false;
                    break;
                }

                _databaseConnection.Open();   
                using var cmd2 = new NpgsqlCommand("SELECT std_name FROM students WHERE room = @room AND dormitory_number = @dormitory_number", _databaseConnection);
                cmd2.Parameters.AddWithValue("room", room);
                cmd2.Parameters.AddWithValue("dormitory_number", dormitory_number);

                using (var reader2 = cmd2.ExecuteReader())
                {
                    bool foundAny = false;

                    while (reader2.Read())
                    {
                        string std_name = reader2.GetString(0);
                        Console.WriteLine($"В комнате {room} общежития №{dormitory_number} живет {std_name}.");
                        foundAny = true;
                    }
                    if (foundAny)
                    {
                        room_found = true;
                    }
                    else
                    {
                        Console.WriteLine($"Студенты в комнате {room} общежития №{dormitory_number} не найдены.");
                    }
                }
                _databaseConnection.Close();   

            } while (!room_found && dormitory_chosen);
        }
    }
}