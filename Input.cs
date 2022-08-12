namespace BattleShipV2
{
    public class Input
    {
        // The Input class is responsible for gathering all input. It also provides a seperate method for each case.
        // The Input class handles input validation.

        public string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
