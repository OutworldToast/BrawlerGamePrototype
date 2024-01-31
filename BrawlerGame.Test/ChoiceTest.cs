namespace BrawlerGame.Test;
using Game;


public class ChoiceTest() {

    [Fact]
    public void ExecuteChoiceWithStringGenericTest() {
        // Arrange
        var str = "Kevin";
        var expected = $"Hello {str}\r\n";
        var choice = new Choice<string>("Say Hello", _ => {
            Console.WriteLine($"Hello {str}");
        });

        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        choice.Execute(str);
        var actual = output.ToString();

        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExecuteChoiceWithImmutableGenericTest() {
        // Arrange
        var num = 0;
        var expected = 0;
        var choice = new Choice<int>("Add 1", i => {
            i++;
        });

        // Act
        choice.Execute(num);
        var actual = num;

        // Assert
        Assert.Equal(expected, actual);
    }

    private class HasInt() { //used for testing
        public int Int { get; set; }
    }

    [Fact]
    public void ExecuteChoiceWithMockClassGenericTest() {
        //see integration for test with real class

        // Arrange
        var hasInt = new HasInt() {
            Int = 0
        };
        var expected = 1;
        var choice = new Choice<HasInt>("Add 1", i => {
            i.Int++;
        });


        // Act
        choice.Execute(hasInt);
        var actual = hasInt.Int;

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExecuteChoiceInvalidParameterTest() {
        // Arrange
        var str = "Kevin";
        var choice = new Choice<int>("Add 1", i => {
            i++;
        });

        // Act

        // Assert
        Assert.Throws<ArgumentException>(() => choice.Execute(str));
    }
}