using MonoGameEngine.StandardCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject.Code.GameObjects
{
    class Bullet : GameObject
    {
        public int _speed = 8;

        public bool shootLeft;
        public bool shootRight;

        public Bullet()
        {
            SetSprite("Bullet");
            GetSprite().SetOrigin(0.5f, 0.5f);
            GetSprite().SetLayerDepth(4);
        }



        public override void Update(float deltaTime)
        {

            if (shootLeft == true)
            {
                shootRight = false;
                ShootLeft();
            }
            if (shootRight == true)
            {
                shootLeft = false;
                ShootRight();
            }




            if (IsOffscreen())
            {
                GetScreen().RemoveObject(this);
            }


            //CheckCollisions(); 
        }

        public void ShootRight()
        {
            //shootRight = true;
            SetPosition(GetX() + _speed, GetY());
        }

        public void ShootLeft()
        {
            //shootLeft = true;
            SetPosition(GetX() - _speed, GetY());
        }

        //private void CheckCollisions()
        //{
        //    GameObject obj = GetOneIntersectingObject<Box>();
        //    if(obj != null)
        //    {
        //        GetScreen().RemoveObject(this);
        //    }
        //}
    }
}
