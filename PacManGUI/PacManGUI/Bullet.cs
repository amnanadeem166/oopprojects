
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using PacManGUI.CollisionFramework;
using PacMan.GameGL;



namespace PacManGUI
{
    public class Bullet : GameObject
    {
        GameDirection dir;
        bool x = false;
        public Bullet(Image image, GameCell startCell, GameDirection dir) : base(GameObjectType.BULLET, image)
        {
            this.CurrentCell = startCell;
            this.dir = dir;
        }
        public bool X { get => x; set => x = value; }
        public void MoveBullet(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(Game.getBlankGameObject());

            }
            this.CurrentCell = gameCell;
        }
        public GameCell NextCell()
        {
            GameCell currentCell = this.CurrentCell;

            GameCell nextCell = this.CurrentCell.nextCell(dir);

            if (nextCell == currentCell || nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER || nextCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                x = true;
                currentCell = nextCell;
            }
            else
            {
                currentCell = nextCell;
            }
            return currentCell;

        }

        public bool IsActive { get; private set; } = true;
    }
}

