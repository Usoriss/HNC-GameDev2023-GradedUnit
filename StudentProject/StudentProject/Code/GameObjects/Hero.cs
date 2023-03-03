using MonoGameEngine.StandardCore;
using System;
using System.Collections.Generic;
using System.Text;

using MonoGameEngine;
namespace StudentProject.Code.GameObjects
{
    class Hero : GameObject
    {
        //Referencing Bullet
        Bullet bullet = new Bullet();         //Referencing Box
        Box _box = new Box();         //Score
        private int _score = 0;         //Jumping Timer
        public int jumpTimer = 30;
        public Hero()
        {
            SetSprite("Player");
            GetSprite().SetLayerDepth(2);
        }
        private void CheckForObstacles()
        {
            //
            if (IsAtScreenEdge() || IsTouching<Ground>())
                RevertPosition();
            if (IsAtScreenEdge() || IsTouching<Box>())
                RevertPosition();
        }
        private void CheckColissions()
        {
            /*
              this following code allows the player to interact with the apples, increasing score. 
              This allows the user to see that they successfully interacted with the item
            */
            GameObject obj = GetOneIntersectingObject<Apple>();
            //this tells the program that if something is inside the program to do the following.
            if (obj != null)
            {
                //in this case it tells the hero class to add 10 score and to get rid of the apple
                GetScreen().GetOneObjectOfType<Hero>().AddScore(10);
                GetScreen().RemoveObject(obj);
            }
        }
        private void Gravity()
        {
            SetPosition(GetX(), GetY() + 5);
            CheckForObstacles();
        }
        private void JumpTimer()
        {
            jumpTimer--;
        }
        public override void Update(float deltaTime)
        {
            Gravity();
            CheckColissions();             //Moving Left and shooting Left
            if (GameInput.IsKeyHeld("A"))
            {
                if (GameInput.IsKeyPressed("E"))
                {
                    GetScreen().AddObject(bullet, (int)GetX(), (int)GetY());
                    bullet.shootLeft = true;
                    bullet.ShootLeft();
                }
                SetPosition(GetX() - 3, GetY());
                CheckForObstacles();
            }
            //Moving Right and shooting Right
            if (GameInput.IsKeyHeld("D"))
            {
                if (GameInput.IsKeyPressed("E"))
                {
                    GetScreen().AddObject(bullet, (int)GetX(), (int)GetY());
                    bullet.shootRight = true;
                    bullet.shootLeft = false;
                    bullet.ShootRight();
                }
                SetPosition(GetX() + 3, GetY());
                CheckForObstacles();
            }
            //For Shooting left or right when stationary
            if (GameInput.IsKeyPressed("E"))
            {
                GetScreen().AddObject(bullet, (int)GetX(), (int)GetY());
            }             //For jumping. P.S: Needs fixing.
            if (GameInput.IsKeyHeld("Space") || IsTouching<Ground>())
            {
                //canJump = false;
                //timer goes down when jumping, when hitting zero you can no longer jump, this will be obsolete soon
                SetPosition(GetX(), GetY() - 11);
                jumpTimer--;
                CheckForObstacles(); if (jumpTimer <= 0)
                {
                    SetPosition(GetX(), GetY() + 8);
                }
                else
                {
                    jumpTimer = 30;
                }
            }
        }
        public void AddScore(int points)
        {
            _score += points;
        }
        public int GetScore()
        {
            return _score;
        }
    }
}
