namespace BattleShipV2
{
    public class SquareStatus
    {
        // Each SquareStatus has a unicode character that can be used for printing it out. This unicode character is returned by Square.GetCharacter() method.
        public Status symbol;
        public string GetCharacter()
        {
            /*this.symbol = symbol;*/

            if (symbol == Status.Empty)
            {
                return "E";
            }
            else if (symbol == Status.Ship)
            {
                return "S";
            }
            else if (symbol == Status.Hit)
            {
                return "H";
            }
            else
            {
                return "M";
            }
        }
    }

    // The SquareStatus enum represents possible square statuses (empty, ship, hit, missed).

    public enum Status
    {
        Empty,
        Ship,
        Hit,
        Missed
    }
}
