namespace BattleShipV2
{
    // The Square class has a Position property.The property is a tuple consisting of x and y coordinates.
    // The Square class has a SquareStatus field.
    // The Square class has method that returns a graphical representation of SquareStatus.

    internal class Square
    {
        // private (int x, int y);

        public SquareStatus Status { get; set; }


        // The Square class has a Position property.The property is a tuple consisting of x and y coordinates.

        private (int x, int y) Position;
        //The Square class has a SquareStatus field.




        public Square((int x, int y) position, SquareStatus squareStatus)
        {
            Position = position;
            this.Status = squareStatus;
        }

        //The Square class has method that returns a graphical representation of SquareStatus.
        public SquareStatus getSquareStatus()
        {
            return Status;
        }


    }
}
