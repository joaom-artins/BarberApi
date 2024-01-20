namespace BarberAPI.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public char Gender { get; set; }

        public Client() { }
        public Client(string name, char gender)
        {
            Name = name;
            Gender = gender;
        }
    }
}
