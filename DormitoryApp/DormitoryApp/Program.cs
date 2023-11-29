using Npgsql;

namespace DormitoryApp.Services
{
    public class Program
    {
        public NpgsqlConnection Conn { get; }

        public Program(string connectionString)
        {
            Conn = new NpgsqlConnection(connectionString);
            Conn.Open();
        }
    }
}
