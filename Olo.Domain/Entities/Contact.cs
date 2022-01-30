namespace Olo.Domain.Entities
{
    public abstract class Contact
    {
        public int ContactId { get; set; }
    }

    public class EmailContact : Contact
    {
        public string Email { get; set; }
    }

    public class PhoneContact : Contact
    {
        public string PhoneNumber { get; set; }
    }

    public class MobileContact : Contact
    {
        public string MobileNumber { get; set; }
    }
}