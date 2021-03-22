using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a406530022_Project
{
    public partial class Form4 : Form
    {
        public bool check = false;
        int moveUp = 0;
        int enemyMove = 30;
        Random rnd = new Random();
        int bulletSpeed = 80;
        bool shooting = false;
        int score = 0;
        Person ingame_person;

        public Form4(Person p)
        {
            InitializeComponent();
            label1.SendToBack();
            ingame_person = p;
            Enemy1.Left = 800;
            Enemy2.Left = 1000;
            Bullet.Left = 800;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (PlayerTank.Location.Y > 390)
                {
                    moveUp = 0;
                }
                else
                {
                    moveUp = 30;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (PlayerTank.Location.Y < 0)
                {
                    moveUp = 0;
                }
                else
                {
                    moveUp = -30;
                }
            }
            else if (e.KeyCode == Keys.Space)
            {

                if (shooting == false)
                {
                    bulletSpeed = 80;
                    Bullet.Left = PlayerTank.Left + 50;
                    Bullet.Top = PlayerTank.Top;
                    shooting = true;
                }
            }
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveUp = 0;
            }
            else if (e.KeyCode == Keys.Down)
            {
                moveUp = 0;
            }
        }


        private void enemyHit()
        {
            if (Bullet.Bounds.IntersectsWith(Enemy1.Bounds))
            {
                score += 1;
                Enemy1.Left = 800;
                int ranP = rnd.Next(0, 300);
                Enemy1.Top = ranP;
                shooting = false;
                bulletSpeed = 0;
                Bullet.Top = -100;
                Bullet.Left = -100;

            }
            else if (Bullet.Bounds.IntersectsWith(Enemy2.Bounds))
            {
                score += 1;
                Enemy2.Left = 800;
                int ranP = rnd.Next(0, 300);
                Enemy2.Top = ranP;
                shooting = false;
                bulletSpeed = 0;
                Bullet.Top = -100;
                Bullet.Left = -100;

            }
        }

        private void gameOver()
        {
            playTimer.Enabled = false;
            MessageBox.Show("You Score = " + score );
            if(ingame_person.getHighScore()<=int.Parse(label1.Text))
            {
                ingame_person.setHighScore(int.Parse(label1.Text));
            }
            score = 0;
            label1.Text = "0";
            Enemy1.Left = 600;
            Enemy2.Left = 900;
            Bullet.Top = -100;
            Bullet.Left = -100;
            //playTimer.Enabled = true;
            this.Close();
        }

        public Person return_player()
        {
            return ingame_person;
        }

        private void playTimer_Tick(object sender, EventArgs e)
        {
            PlayerTank.Top += moveUp;
            Bullet.Left += bulletSpeed;
            Enemy1.Left -= enemyMove;
            Enemy2.Left -= enemyMove;
            label1.Text = "" + score;

            if (Enemy1.Left <= 0 || Enemy2.Left <= 0 )
            {
                gameOver();

            }

            if (shooting && Bullet.Left >560)
            {
                shooting = false;
                bulletSpeed = 0;
                Bullet.Top = PlayerTank.Location.Y;
                Bullet.Left = -100;
            }
            enemyHit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Form4_Closing(Object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Form1_newRecord(ingame_person);
        }
    }
}
