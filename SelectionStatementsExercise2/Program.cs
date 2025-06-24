namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math, the universal language. Awesome!");
                    break;
                case "science":
                    Console.WriteLine(
                        "Learning about life and the world around us, can't get much better than Science!");
                        break;
                case "history":
                    Console.WriteLine("It's important to learn about the past, thats why I also love History!");
                    break;
                case "writing":
                    Console.WriteLine("Writing is how we conncect with other and share stories, great choice!");
                    break;
                case "art":
                    Console.WriteLine("Everyone can connect with art in their own way, thats why its so special, amazing!");
                    break;
                default:
                    Console.WriteLine("Interesting, I haven't taken that class but im sure its great!");
                    break;
            }
        }
    }
}