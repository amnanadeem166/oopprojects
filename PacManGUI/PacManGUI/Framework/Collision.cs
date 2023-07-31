
using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGUI.CollisionFramework
{
    class Collision
    {
        

        public static bool CheckCollision(Bullet fire)
        {
            if(fire.NextCell().CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                return true;
            }
            return false;
        }

        public static bool CheckCollisionBY(GameObject obj1 , GameObject obj2)
        {
            bool flag = false;

            if(obj1.CurrentCell.X == obj2.CurrentCell.X && obj1.CurrentCell.Y == obj2.CurrentCell.Y)
            {
                flag = true;
            }

            return flag;
        }

        public static bool CheckReward(GameCell cell)
        {
            if (cell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                return true;
            }
            return false;
        }
        public static bool CheckBlank(GameCell cell)
        {
            if(cell.CurrentGameObject.GameObjectType==GameObjectType.NONE)
            {
                return true;
            }   
            return false;
        }
        public static bool CheckEnemyWithReward(GameObject enemy)
        {
            GameCell temp = new GameCell();
            //if(enemy.CurrentCell.nextCell(enemy.di)
            return true;
        }







    }
}
