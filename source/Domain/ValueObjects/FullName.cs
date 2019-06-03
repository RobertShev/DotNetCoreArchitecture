namespace DotNetCoreArchitecture.Domain
{
    public sealed class FullName
    {
        public FullName(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public FullName() { }

        public string Name { get; private set; }

        public string Surname { get; private set; }
    }
}
