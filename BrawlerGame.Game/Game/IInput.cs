using Game;

namespace Game;

public interface IInput
{
    Choice Ask(IEnumerable<Choice> choices);
}
