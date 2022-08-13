namespace Module_12_1_5
{
    class User
    {
        public User(string login, string name, bool isPremium)
        {
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            IsPremium = isPremium;
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public void Greeting()
        {
            Console.WriteLine($"Hello, {Name}!\n");
        }
    }
}
