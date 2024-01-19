namespace BarberAPI.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Client() { }
        public Client(string name)
        {
            Name = name;
        }
    }
}
