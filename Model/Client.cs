using BarberAPI.Model.Enums;

namespace BarberAPI.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Gender Gender { get;set; }
        public int Number { get; set; }

        public Client() { }
        public Client(string name, Gender gender, int number)
        {
            Name = name;
            Gender = gender;
            Number = number;
        }
    }
}
