namespace Interface_Segregation_Principle_Correct;

internal class Program
{
    static void Main(string[] args)
    {
        Human human = new();
        Robot robot = new();
        
        human.Work();
        human.Eat();
        Console.WriteLine();
        robot.Work();
    }
}
