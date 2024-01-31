namespace BrawlerGame.Test;
using Game;
using Interface;


public class ConsoleVisualiserTest
{
    [Fact]
    public void ShowContainsChoiceBodyTest()
    {
        // Arrange
        var visualiser = new ConsoleVisualiser();
        var choices = new List<Choice> {
            new Choice<string>("Throw Rock", _ => {}),
            new Choice<string>("Throw Paper", _ => {}),
            new Choice<string>("Throw Scissors", _ => {})
        };
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        visualiser.Show(choices);
        var actual = output.ToString();
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });

        // Assert
        foreach (var choice in choices)
        {
            Assert.Contains(choice.Body, actual);
        }
    }

    [Fact]
    public void ShowEmptyListTest()
    {
        // Arrange
        var visualiser = new ConsoleVisualiser();
        var choices = new List<Choice>();

        // Act
        var output = new StringWriter();
        Console.SetOut(output);
        visualiser.Show(choices);
        var actual = output.ToString();
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });

        // Assert
        Assert.Contains("No choices to show", actual);
    }

    // [Fact]
    // public void ShowFaultyGenericThrowsErrorTest() {
    //     // Arrange
    //     var visualiser = new ConsoleVisualiser();
    //     var choices = new List<Choice> {
    //         new Choice<string>("Throw Rock", _ => {}),
    //         new Choice<string>("Throw Paper", _ => {}),
    //         new Choice<int>("Throw Scissors", _ => {})
    //         //add one choice with a different generic type
    //     };
        
    //     // Act

    //     // Assert
    //     Assert.Throws<ArgumentException>(() => visualiser.Show(choices));
    // }
}