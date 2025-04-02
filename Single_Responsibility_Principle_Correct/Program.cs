namespace Single_Responsibility_Principle_Correct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new();
            UserStorage userStorage = new();
            user.Name = "John Cena";
            user.Email = "jd@icloud.com";
            userStorage.SaveDataBase(user);
        }
    }
}
