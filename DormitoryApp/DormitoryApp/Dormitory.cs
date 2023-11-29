using Npgsql;

namespace DormitoryApp.Services
{
    public class Dormitory
    {
        private NpgsqlConnection _databaseConnection;

        public Dormitory()
        {
            string connectionString = "Host=localhost;Username=elizavetazhitnik;Password=;Database=DormitoryDataBase";
            _databaseConnection = new NpgsqlConnection(connectionString);
        }

        public void SelectDormitory()
        {
            Console.WriteLine("Введите название общежития:");
            string domitory_number = Console.ReadLine();

            _databaseConnection.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM Campus WHERE domitory_number = @domitory_number", _databaseConnection);
            cmd.Parameters.AddWithValue("@domitory_number", domitory_number);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Console.WriteLine($"Общежитие {domitory_number} выбрано.");
                Console.WriteLine("//потом сюда добавится расселенка по комнатам");
            }
            else
            {
                Console.WriteLine("Общежитие с таким названием не найдено.");
            }
            _databaseConnection.Close();
        }
    }
}
