namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ask user for their favorite school subject and store in a variable
            Console.WriteLine("Please enter your favorite school subject: ");
            string userFavSchoolSubject = Console.ReadLine();

            //validate using switch statemets if user favorite subject is listed
            //if not the add an appropriate default clause

            switch (userFavSchoolSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math the world of numbers");
                    break;
                case "science":
                    Console.WriteLine("Science is fun");
                    break;
                case "history":
                    Console.WriteLine("What we can learn from our history.");
                    break;
                case "computer science":
                    Console.WriteLine("The real science");
                    break;
                case "spanish":
                    Console.WriteLine("hablas español");
                    break;
                default:
                    Console.WriteLine("Subject not listed");
                    break;
            }
            Console.ReadLine();
        }
    }
}