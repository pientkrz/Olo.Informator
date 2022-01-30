using System;

namespace Olo.Domain.Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public int FirstName { get; set; }
        public int Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Contact> ContactChannels { get; set; } = new List<Contact>();
    }
}
