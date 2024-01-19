using System.Text.Json.Serialization;

namespace BarberAPI.Model
{
    public class HairCut
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        [JsonIgnore]
        public Client? Client { get; set; }
        public DateTime ScheduledDate { get; set; }
        public double Price { get; set; }
        
        public HairCut() { }

        public HairCut(int clientId, DateTime scheduledDate, double price)
        {
            ClientId = clientId;
            ScheduledDate = scheduledDate;
            Price = price;
        }
    }
}
