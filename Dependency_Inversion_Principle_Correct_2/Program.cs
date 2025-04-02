namespace Dependency_Inversion_Principle_Correct_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Project project1 = new([new BackEndDeveloper(), new FrontEndDeveloper(), new MobileDeveloper()]);
            project1.ProjectDevelop();

        }
    }
}
