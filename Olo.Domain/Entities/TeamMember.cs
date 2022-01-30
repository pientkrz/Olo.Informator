namespace Olo.Domain.Entities
{
    // TODO: yellow/red cards history - probably nested class
    // with notes for example exclusion
    public class TeamMember
    {
        public int TeamMemberId { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
