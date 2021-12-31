namespace Olo.Domain.Entities
{
    public class Referee
    {
        public int RefereeId { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
