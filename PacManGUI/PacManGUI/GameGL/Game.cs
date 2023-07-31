using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PacMan.GameGL
{
    public class Game
    {
        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, PacManGUI.Properties.Resources.simplebox);
            return blankGameObject;
        }
        public static GameObject getRewardGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.REWARD, PacManGUI.Properties.Resources.pallet);
            return blankGameObject;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = PacManGUI.Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = PacManGUI.Properties.Resources.vertical;
            }

            if (displayCharacter == '#')
            {
                img = PacManGUI.Properties.Resources.horizontal;
            }

            if (displayCharacter == '.')
            {
                img = PacManGUI.Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p') {
                img = PacManGUI.Properties.Resources.nova;
            }
            if (displayCharacter == 'O' || displayCharacter == 'O')
            {
                img = PacManGUI.Properties.Resources.enemy1;
            }
            if (displayCharacter == 'W' || displayCharacter == 'W')
            {
                img = PacManGUI.Properties.Resources.enemy2;
            }
            if (displayCharacter == 'R' || displayCharacter == 'R')
            {
                img = PacManGUI.Properties.Resources.enemy3;
            }
            if (displayCharacter == 'L' || displayCharacter == 'L')
            {
                img = PacManGUI.Properties.Resources.enemy4;
            }
            if(displayCharacter == 'F' || displayCharacter =='F')
            {
                img = PacManGUI.Properties.Resources.Bullet;
            }
            if (displayCharacter == 'V' || displayCharacter == 'V')
            {
                img = PacManGUI.Properties.Resources.enemy5;
            }

            if (displayCharacter == 'M' || displayCharacter == 'M')
            {
                img = PacManGUI.Properties.Resources.enemy6;
            }

         

            return img;
        }
    }
}
