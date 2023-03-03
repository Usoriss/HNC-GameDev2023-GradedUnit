using MonoGameEngine;
using MonoGameEngine.StandardCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject.Code.GameObjects
{
    class Ground : GameObject
    {
        public Ground()
        {
            //Ground selects from 4 random sprites 
            int spriteChange = Core.GetRandomNumber(4);
            switch (spriteChange)
            {
                case 0:
                    SetSprite("Ground1");
                    break;
                case 1:
                    SetSprite("Ground2");
                    break;
                case 2:
                    SetSprite("Ground3");
                    break;
                case 3:
                    SetSprite("Ground4");
                    break;


            }

        }
        public override void Update(float deltaTime)
        {

        }
    }
}
