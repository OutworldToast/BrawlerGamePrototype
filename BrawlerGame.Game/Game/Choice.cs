namespace Game;

public abstract class Choice
{
    public abstract string Body { get; init; }
    public abstract void Execute(object input);
}

public class Choice<TInput>(string body, Action<TInput> action) : Choice
{
    public override string Body { get; init; } = body;
    public Action<TInput> Action { get; init; } = action;

    public override void Execute(object input) {
        if (input is TInput typedInput){
            Action(typedInput);
        } else { //should this be a throw?
            throw new ArgumentException($"Input is not of type {typeof(TInput)}");
        }
    }
}