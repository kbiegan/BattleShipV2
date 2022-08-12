using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipV2
{
    // Implement the Ship class and its methods.
    // The Ship class has a List<Square> field.It contains the squares where the ship is located.

    internal class Ship
    {
        private List<Square> squares;
        private ShipType shipType;

        // czy statek ma byc poziomo czy pionowo

        public void Ship(List<Square> squares, ShipType shipType)
        {
            this.squares = squares;
            this.shipType = shipType;
        }

        public List<Square> getSquares()
        {
            return squares;
        }

        public ShipType GetShipType()
        {
            return shipType;
        }
    }
}
