namespace Olo.Domain.Entities
{
    public class Team
    {
        public Team()
        {
            TeamMembers = new HashSet<TeamMember>();
        }

        public int TeamId { get; set; }
        public string Name { get; set; }
        public ICollection<TeamMember> TeamMembers { get; set; }
    }
}
