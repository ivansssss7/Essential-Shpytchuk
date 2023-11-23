

namespace Essential2_Shpytchuk
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        private readonly DateTime dateWriteQuestionnaire;
        public DateTime DateWriteQuestionnaire
        {
            get { return dateWriteQuestionnaire; }
        }

        public User(string login, string name, string surname, int age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            dateWriteQuestionnaire = DateTime.Now;
        }

    }
}
