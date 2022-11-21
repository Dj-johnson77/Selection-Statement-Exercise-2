namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");

            var subject = Console.ReadLine();

            FavSubject(subject);

        }
        public static void FavSubject(string subject)
        {
             
            
            switch (subject.ToLower())
            {
                case "math":
                    
                        Console.WriteLine("Good Choice!");
                        break;
                    
                case "science":
                    
                        Console.WriteLine("Good Choice!");
                        break;
                    
                case "history":
                    
                        Console.WriteLine("Good Choice!");
                        break;
                    
                case "english":
                    
                        Console.WriteLine("Good Choice!");
                        break;
                    
                case "reading":
                    
                        Console.WriteLine("Good Choice!");
                        break;
                    
                default:
                    
                        Console.WriteLine("I see.");
                        break;
                    
                
                
                                 

            }
            
        }
    }
}