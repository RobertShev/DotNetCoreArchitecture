namespace DotNetCoreArchitecture.Domain
{
    public sealed class SignIn
    {
        public SignIn(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public SignIn() { }

        public string Login { get; private set; }

        public string Password { get; private set; }
    }
}
