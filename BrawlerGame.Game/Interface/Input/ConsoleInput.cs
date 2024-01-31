namespace Interface;
using Game;

public class ConsoleInput : IInput
{

    public Choice Ask(IEnumerable<Choice> choices) //check this shit
    {
        var input = Console.ReadLine();
        if (int.TryParse(input, out var index))
        {
            if (index > 0 && index <= choices.Count())
            {
                return choices.ElementAt(index - 1);
            }
            else
            {
                Console.WriteLine("Invalid input");
                return Ask(choices);
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
            return Ask(choices);
        }
    }

}