namespace Single_Responsibility_Principle;

public class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        user.Name = "John";
        user.Email = "jd@gmail.com";
        user.SaveDataBase();
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void SaveDataBase()
        {
            Console.WriteLine("Saving the user: "+ Name +" with the email: "+Email+" in the Database...");
        }
    }

    

}
