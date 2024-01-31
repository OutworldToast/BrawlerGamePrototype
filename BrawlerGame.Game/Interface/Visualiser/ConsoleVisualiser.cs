namespace Interface;
using Game;

public class ConsoleVisualiser : IVisualiser
{   
    private void WriteEqualsLine() {
        Console.WriteLine("====================================");
    }
    public void Show(IEnumerable<Choice> choices) {
        if (choices.Any()) {
            Console.WriteLine("Type the respective number to choose an option");
            WriteEqualsLine();
            for (int i = 0; i < choices.Count(); i++)
            {
                Console.WriteLine($"{i + 1}: {choices.ElementAt(i).Body}");
            }
            WriteEqualsLine();
        } else {
            Console.WriteLine("No choices to show");
        }
        
    }

    
}