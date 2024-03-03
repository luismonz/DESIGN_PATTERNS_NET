using FactoryPattern.Space;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Player
{
    public class NonConfigurablePlayer
    {
        public string PlayerName;
        public int Health;
        public Coordinates InititalCoordinates;

        public NonConfigurablePlayer()
        {
            this.PlayerName = "GOOFY";
            this.Health = 500;
            this.InititalCoordinates = new Coordinates(0, 0);
        }

        public void WalkAround(int posX, int posY)
        {
            this.InititalCoordinates.Pos_X += posX;
            this.InititalCoordinates.Pos_Y += posY;
        }

    }
}
