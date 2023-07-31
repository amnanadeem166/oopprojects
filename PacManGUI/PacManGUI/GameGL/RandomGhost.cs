using PacManGUI.CollisionFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.GameGL
{
    class RandomGhost : Ghost
    {       
        public RandomGhost(Image G, GameCell start) : base(G, start)
        {
            Direction = GameDirection.Left;
        }
        static Random ghostDirection()
        {
            Random rand = new Random();
            return rand;
        }
        public override GameCell Move()
        {
                Random rand = ghostDirection();
            
            if (PreviousObject == GameObjectType.NONE)
            {
                CurrentCell.setGameObject(Game.getBlankGameObject());
            }
            if (PreviousObject == GameObjectType.REWARD)
            {
                CurrentCell.setGameObject(Game.getRewardGameObject());
            }
            GameCell currentCell = this.CurrentCell;
                GameCell nextCell = currentCell.nextCell(Direction);
            if (Collision.CheckReward(nextCell))
            {
                PreviousObject = GameObjectType.REWARD;
            }
            else if (Collision.CheckBlank(nextCell))
            {
                PreviousObject = GameObjectType.NONE;
            }
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                if (PreviousObject == GameObjectType.NONE)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                }
                if (PreviousObject == GameObjectType.REWARD)
                {
                    CurrentCell.setGameObject(Game.getRewardGameObject());
                }
            }
            else
            {
                currentCell.X = rand.Next(1, 20);
                currentCell.Y=rand.Next(1, 24);
            }
            return nextCell;
        }
    }
}
