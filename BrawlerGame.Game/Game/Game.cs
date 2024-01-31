namespace Game;

public class Game
{   
    private readonly IInput _input;
    private readonly IVisualiser _visualiser;
    public Game(IInput input, IVisualiser visualiser) {
        _input = input;
        _visualiser = visualiser;
    }

    public void WinBattle() {
        
    }
}