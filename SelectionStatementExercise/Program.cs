using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {



            int favoriteNumber = 23;
            Console.WriteLine("Try to guess my favorite number between 1 - 30 you have three chances."); // input
            int userInput = int.Parse(Console.ReadLine());
            


            if (favoriteNumber > userInput)
            {
                Console.WriteLine("Too Low");
            }

            else if (favoriteNumber < userInput)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("You got Me ");
                
            }
            
            
            //Excerise2:
            
            Console.WriteLine("What is your favorite school subject?");
            String favoriteSubject = Console.ReadLine();


            switch (favoriteSubject)
            {


                case "math":
                    Console.WriteLine("I love doing math");
                    break;
                case "history":
                    Console.WriteLine("I love History");
                    break;
                case "p.e":
                    Console.WriteLine("I love P.E");
                    break;
                case "english":
                    Console.WriteLine("I love english ");
                    break;
                case "science":
                    Console.WriteLine("i love science");
                    break;
            }








        }
    }
}