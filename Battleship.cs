namespace BattleShipV2
{
    public class Battleship
    {
        Display display;
        Input input;

        public Battleship(Display display, Input input)
        {
            this.display = display;
            this.input = input;
        }
        public void Run()
        {
            display.PrintGameMenu();

            while (true)
            {
                string userAnswer = input.ReadString("Would you like to play? (Y/N)");
                
                if (userAnswer == "Y" || userAnswer == "y")
                {
                    Game game = new Game(display, input);
                    game.RunGame();
                }
                
                else
                {
                    display.PrintString("Program finished.");
                    break;
                }
            }
            
        }
    }
}
