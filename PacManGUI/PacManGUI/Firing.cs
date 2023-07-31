using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.GameGL;
using System.Drawing;
using System.Windows.Forms;

namespace PacManGUI
{
    class Firing : GameObject
    {
        public GameObjectType PreviousObject = GameObjectType.NONE;
        GameObject player;


        public Firing(Image image, GameCell startCell, GameObject player) : base(GameObjectType.BULLET, image)
        {
            this.CurrentCell = startCell;
            this.player = player;
        }


          private int speed = 20;
          private PictureBox Bullet =new  PictureBox();
          private Timer Bullettimer = new Timer(); 
        
        
            public void MakeBullet(Form form, GameDirection direction)
            {
                // Calculate the bullet's starting position based on the player's position
                int bulletLeft = player.CurrentCell.X; // Adjust this value based on the player's position
                int bulletTop = player.CurrentCell.Y;  // Adjust this value based on the player's position

                Bullet.BackColor = Color.Red;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "Bullet";
                Bullet.Left = bulletLeft;
                Bullet.Top = bulletTop;

                // Subscribe to the Bullettimer Tick event to handle bullet movement
                Bullettimer.Interval = 100; // Set the interval as needed
                Bullettimer.Tick += (sender, e) =>
                {
                    // Move the bullet based on the direction
                    switch (direction)
                    {
                        case GameDirection.Left:
                            Bullet.Left -= speed;
                            break;
                        case GameDirection.Right:
                            Bullet.Left += speed;
                            break;
                        case GameDirection.Up:
                            Bullet.Top -= speed;
                            break;
                        case GameDirection.Down:
                            Bullet.Top += speed;
                            break;
                    }

                    // Check for collisions or out-of-bounds conditions and stop the bullet if necessary
                    // For example, you can check if the bullet collides with walls, enemies, or goes out of bounds.
                    // If a collision or out-of-bounds condition occurs, you can stop the Bullettimer.
                };

                // Start the Bullettimer to begin bullet movement
                Bullettimer.Start();

                // Add the bullet's PictureBox to the form's Controls
                form.Controls.Add(Bullet);
            }

        }



    }

