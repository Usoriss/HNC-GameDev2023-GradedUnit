using MonoGameEngine;
using MonoGameEngine.StandardCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject.Code.GameObjects
{
    class Box : GameObject
    {
        private int _boxLives = 5;
        public Box()
        {
            SetSprite("Box");
        }

        private void BoxHealth()
        {
            GameObject bullet = GetOneIntersectingObject<Bullet>();
            if (bullet != null)
            {
                _boxLives--;
                GetScreen().RemoveObject(bullet);
                SetSprite("boxHealthAnim", 64, 0.1f, new int[] { 2 }, LoopType.None);
            }
            if (_boxLives == 0)
            {
                //GetScreen().RemoveObject(this);
                SetSprite("Box Broken");
            }

        }

        public int GetLives()
        {
            return _boxLives;
        }

        public override void Update(float deltaTime)
        {
            BoxHealth();
        }
    }
}
