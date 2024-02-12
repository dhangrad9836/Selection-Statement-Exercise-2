namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercise 1");

            //Initialize an integer to represent a favorite number and assign a value with
            //a number of your choosing or you can assign a random number to this variable:

            //create a random number
            var r = new Random();

            //generate a random number between 1 and 1000
            var favNumber = r.Next(1, 1000);


            //ask user toguess your favorite number is
            Console.WriteLine("Can you guess my favorite number? ");

            //get user input and store in userInput variable
            var userInput = int.Parse(Console.ReadLine());

            //validate if user input is too low, too high, or if it's a correct guess
            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("You guesst it!!!");
            }


            Console.WriteLine($"My favorite number is: {favNumber}");



            Console.WriteLine("Exercise 2");
            //----------------------------- Exercise 2----------------------------------------

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