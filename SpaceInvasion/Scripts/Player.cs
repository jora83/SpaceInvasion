using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvasion.Scripts
{
    public class Player
    {
        int speed = 12;
        public PictureBox playerPictureBox;

        public Player()
        {
         

        }

        public Player(PictureBox p) 
        {
            playerPictureBox = p;

        }

        public void Buton()
        {
            Button putamadre = new Button();
            
        }

        public void MoveLeft()
        {
            playerPictureBox.Left -= speed;
        }
    }
}
