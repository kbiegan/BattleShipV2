namespace BattleShipV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            
           
            Input input = new Input();


            Battleship battleship = new Battleship(display, input);
            battleship.Run();
        }
    }
}