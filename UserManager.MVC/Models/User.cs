namespace UserManager.MVC.Models
{
    public class User
    {
        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; }
        public string Surname { get; }
        public int Age { get; set; }
        public int Index { get; set; }

        
        public bool IsRetired()
        {
            return Age > 65;
        }
    }
}
