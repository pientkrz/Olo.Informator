namespace Olo.Domain.Entities
{
    public class MatchHistory
    {
        public int MatchHistoryId { get; set; }
        public DateTime MatchDate { get; set; }
        public Team HostTeam { get; set; }
        public Team GuestTeam { get; set; }
        public ICollection<Player> MyProperty { get; set; } = new List<Player>();
    }

    public class PlayerHistory
    {
        public int PlayerHistoryId { get; set; }
        public int MatchHistoryId { get; set; }
        public int Goals { get; set; }
    }

    public abstract class MatchFact
    {
        public int MatchFactId { get; set; }
    }

    public class GoalFact : MatchFact
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }

    public class YellowCardFact : MatchFact
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }

    public class RedCardFact : MatchFact
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }

    public class Player
    {
        public int PlayerId { get; set; }
    }
}
