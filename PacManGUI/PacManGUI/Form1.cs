using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacMan.GameGL;
using EZInput;
using Pacman;
using PacManGUI.CollisionFramework;
using PacManGUI;

namespace PacManGUI
{
    public partial class Form1 : Form
    {
        GamePacManPlayer nova;
        List<Ghost> ghost = new List<Ghost>();
        List<Bullet> bullets = new List<Bullet>();
        int PlayerHealth = 100;
        HorizontalGhost HGhost;
        HorizontalGhost HGhost2;
        VerticalGhost VGhost;
        VerticalGhost VGhost2;
        VerticalGhost VGhost3;
        RandomGhost RGhost;
        SmartGhost SGhost;
        Label lable = new Label();
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
           

            GameGrid grid = new GameGrid("maze.txt", 19, 42);
            Image novaimage = Game.getGameObjectImage('P');
            Image enemy1 = Game.getGameObjectImage('O');
            Image enemy2 = Game.getGameObjectImage('W');
            Image enemy3 = Game.getGameObjectImage('R');

            Image enemy6 = Game.getGameObjectImage('M');
            Image enemy4 = Game.getGameObjectImage('L');
            Image enemy5 = Game.getGameObjectImage('V');


            GameCell startCell = grid.getCell(3, 33);
            GameCell startRandom = grid.getCell(15, 22);
            GameCell startVertical2 = grid.getCell(9, 25);
            GameCell startVertical3 = grid.getCell(8, 35);
            GameCell startHorizontal2 = grid.getCell(17, 28);
            GameCell startVertical = grid.getCell(12, 22);
            GameCell startHorizontal = grid.getCell(11, 19);



            nova = new GamePacManPlayer(novaimage, startCell);
            HGhost = new HorizontalGhost(enemy1, startHorizontal);
            VGhost = new VerticalGhost(enemy2, startVertical);
            RGhost = new RandomGhost(enemy3, startRandom);
            HGhost2 = new HorizontalGhost(enemy4, startHorizontal2);
            VGhost2 = new VerticalGhost(enemy5, startVertical2);
            VGhost3 = new VerticalGhost(enemy6, startVertical3);


            ghost.Add(VGhost2);
            ghost.Add(VGhost3);
            ghost.Add(HGhost);
            ghost.Add(VGhost);
            ghost.Add(HGhost2);
            ghost.Add(RGhost);

            printMaze(grid);
          
        }
        private void CreateScoreLable(GamePacManPlayer nova)
        {

            lable.Top = 20;
            lable.Left = 900;
            lable.ForeColor = Color.White;
            this.Controls.Add(lable);
        }

        void printMaze(GameGrid grid)
        {

            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);
                }

            }
        }
        private void gameLoop_Tick(object sender, EventArgs e)
        {
            CheckCollisions();

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                GameCell playerCell = nova.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                nova.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                nova.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                nova.move(GameDirection.Down);
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                GameCell NewCell = nova.CurrentCell.nextCell(GameDirection.Down);
                Bullet f = new Bullet(PacManGUI.Properties.Resources.Bullet, NewCell, GameDirection.Down);
                bullets.Add(f);
                CheckCollisions();

            }

            MoveBullet();
            RemoveBullets();

            for (int i = 0; i < ghost.Count; i++)
            {
                ghost[i].Move();
            }


            UpdateHealthBar(PlayerHealth);
            lable.Text = nova.score.ToString();
        }
        private void CheckCollisions()
        {
           
            foreach (Ghost ghost in ghost)
            {
                if (Collision.CheckCollisionBY(nova, ghost))
                {
                    PlayerHealth--;

                    if (PlayerHealth <= 0)
                    {
                        // If the player's health is zero or less, end the game
                        gameLoop.Enabled = false;
                        this.Hide();
                        ShowGameEnd(PacManGUI.Properties.Resources.pacman_gameover);
                        break; // Exit the loop since the game is over
                    }
                }
            }

        }





        private void UpdateHealthBar(int health)
        {
            // Set the ProgressBar's value to the player's health
            healthbar.Value = health;

            // Check if the player's health is zero or less
            if (health <= 0)
            {
                // If the player's health is zero or less, end the game
                gameLoop.Enabled = false;
                this.Hide();
                ShowGameEnd(PacManGUI.Properties.Resources.pacman_gameover);
            }
        }



        private void RemoveBullets()
        {
            for (int i = 0;i < bullets.Count;i++)
            {
                if (bullets[i].X)
                {
                    // Remove the bullet as well (assuming bullets are removed on collision)
                    bullets[i].CurrentCell.setGameObject(Game.getBlankGameObject());
                    bullets.RemoveAt(i);
                }
            }
        }


        private void MoveBullet()
        {
            for (int i = 0; i< bullets.Count; i++)
            {
                if (Collision.CheckCollision(bullets[i]))
                {
                    RemoveEnemy(bullets[i]);                    
                }
                bullets[i].MoveBullet(bullets[i].NextCell());
            }
        }

        private void RemoveEnemy(Bullet fire)
        {
            for (int i = 0; i < ghost.Count;i++)
            {
                if(fire.NextCell() == ghost[i].CurrentCell)
                {
                    ghost[i].CurrentCell.setGameObject(Game.getBlankGameObject());
                    ghost.RemoveAt(i);
                }
            }
        }

        private void ShowGameEnd(Image img)
        {
            gameLoop.Enabled = false;
            FrmGameEnd GameOver = new FrmGameEnd(img);
            DialogResult result = GameOver.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            if (result == DialogResult.No)
            {
                Restart();
            }
        }
        private void Restart()
        {
            this.Show();
            this.Controls.Clear();
            Label lable = new Label();
            this.Controls.Add(lable);
            GameGrid grid = new GameGrid("maze.txt", 21, 56);
            Image novaimage = Game.getGameObjectImage('P');
            Image enemy1 = Game.getGameObjectImage('O');
            Image enemySmart = Game.getGameObjectImage('B');
            Image enemy2 = Game.getGameObjectImage('W');
            Image enemyRandom = Game.getGameObjectImage('R');
            GameCell startCell = grid.getCell(3, 33);
            GameCell startRandom = grid.getCell(19, 10);
            GameCell startSmart = grid.getCell(4, 4);
            GameCell startVertical = grid.getCell(12, 22);
            GameCell startHorizontal = grid.getCell(11, 20);
            nova = new GamePacManPlayer(novaimage, startCell);
            nova.score = 0;
            HGhost = new HorizontalGhost(enemy1, startHorizontal);
            VGhost = new VerticalGhost(enemy2, startVertical);
            RGhost = new RandomGhost(enemyRandom, startRandom);
            SGhost = new SmartGhost(enemySmart, startSmart, nova);
            ghost.Add(HGhost);
            ghost.Add(VGhost);
            ghost.Add(SGhost);
            ghost.Add(RGhost);
            printMaze(grid);
            gameLoop.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

