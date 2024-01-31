namespace Program;
using Game;
using Interface;
class Program
{
    static void Main(string[] args)
    {
        // Create a new game instance
        Game game = new Game(new ConsoleInput(), new ConsoleVisualiser());
        string str = "Kevin";

        var choices = new List<Choice>() {
                new Choice<string>("Start", (string input) => {
                    Console.WriteLine($"Hello {input}");
                }),
                new Choice<string>("Exit", (string input) => {
                    Console.WriteLine($"Goodbye {input}");
                })
        };

        IVisualiser visualiser = new ConsoleVisualiser();
        IInput input = new ConsoleInput();

        visualiser.Show(choices);
        input.Ask(choices).Execute(str);

        // Run the game
        //game.Run();
    }
}