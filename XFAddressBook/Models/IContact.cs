namespace XFAddressBook.Models
{
    interface IContact
    {
        string Name { get; }
        string Contact { get; }
    }

    class Address : IContact
    {
        public string Name { get; }
        public string Contact { get; }

        public Address(string name, string address) =>
            (Name, Contact) = (name, address);
    }

    class Phone : IContact
    {
        public string Name { get; }
        public string Contact { get; }

        public Phone(string name, string number) =>
            (Name, Contact) = (name, number);
    }

    class Email : IContact
    {
        public string Name { get; }
        public string Contact { get; }

        public Email(string name, string email) =>
            (Name, Contact) = (name, email);
    }
}
