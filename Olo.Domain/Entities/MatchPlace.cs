namespace Olo.Domain.Entities
{
    public class MatchPlace
    {
        public int MatchPlaceId { get; set; }
        public Address Address { get; set; }
        public ICollection<Contact> ContactChannels { get; set; } = new List<Contact>();
    }
}
