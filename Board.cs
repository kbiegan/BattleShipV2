namespace BattleShipV2
{
    // The Board class has a Square[,] ocean field. This contains the squares that the board consists of.
    // The Board class has a IsPlacementOk() method that verifies if placement of ship is possible.

    internal class Board
    {
        private Square[,] ocean;
        private Display display;

        public Square[,] getOcean()
        {
            return ocean;
        }

        public void setOcean(Square[,] ocean)
        {
            this.ocean = ocean;
        }

        public Board(int boardSize)
        {
            ocean = new Square[boardSize,boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    ocean[i,j] = new Square((i, j), SquareStatus.Empty);
                }
            }
        }


        public void IsPlacementOk()
        {

        }



        public void printBoard()
        {
            display.displayBoard(ocean);
        }
    }
}
