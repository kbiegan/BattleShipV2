namespace BattleShipV2
{
    public class Game
    {
        Display display;
        Input input;

        public Game(Display display, Input input)
        {
            this.display = display;
            this.input = input;
        }
        public void RunGame()
        {
            display.PrintString("The game is running now!");
        }
    }
}
