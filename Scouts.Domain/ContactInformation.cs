namespace Scouts.Domain
{
    public class ContactInformation
    {
        public ContactInformation(string emailAddress, string phoneNumber)
        {
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

        public string EmailAddress { get; }
        public string PhoneNumber { get; }
    }
}