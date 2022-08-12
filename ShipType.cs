namespace BattleShipV2
{
    // Implement the ShipType enum and its methods.
    // The ShipType enum represents ship types.The types are Carrier, Cruiser, Battleship, Submarine, and Destroyer.
    // Each ShipType has a unique length.


    internal class ShipType
    {
        private int length;

        public enum TypeShip
        {
            Carrier = 6,
            Battleship = 5,
            Cruiser = 4,
            Submarine = 3,
            Destroyer = 2
        }

        public ShipType(int length)
        {
            this.length = length;
        }

        public int getLength()
        {
            return length;
        }
    }
}
