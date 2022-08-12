namespace BattleShipV2
{
    public class Display
    {
        public void PrintGameMenu()
        {
            Console.WriteLine("Hello Battleship!");
        }

        public void PrintString(string text)
        {
            Console.WriteLine(text);
        }

        public void displayBoard(Square[,] ocean)
        {
            for (int i = 0; i < ocean.Length; i++)
            {
                for (int j = 0; j < ocean.Length; j++)
                {
                    Console.WriteLine(ocean);
                }
            }
        }
        
    }
}
