namespace Liskov_Substitution_Principle;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LSP Principle, people!");
        
        Flamingo flamingo = new Flamingo();
        Console.WriteLine("Flamingo: ");
        flamingo.Fly();

        Penguin penguin = new Penguin();
        Console.WriteLine("Penguin: ");
        penguin.Fly();
    }

    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("This Bird CAN fly");
        }
    }

    public class Flamingo: Bird
    {
        // A flamingo CAN fly :)
        
    }

    public class Penguin : Bird
    {
        // A penguin CAN'T fly :(
    }
}
