namespace Olo.Domain.Entities
{
    public class Season
    {
        public int SeasonId { get; set; }
        public DateTime BeginDate { get; set; }
        ICollection<League> Leagues { get; set; } = new List<League>();
    }
}
