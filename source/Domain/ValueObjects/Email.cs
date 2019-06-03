namespace DotNetCoreArchitecture.Domain
{
    public sealed class Email
    {
        public Email(string address)
        {
            Address = address;
        }

        public Email() { }

        public string Address { get; private set; }
    }
}
