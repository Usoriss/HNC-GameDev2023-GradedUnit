using MonoGameEngine.StandardCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject.Code.GameObjects
{
    class Apple : GameObject
    {
        public Apple()
        {
            SetSprite("Apple", 65, 0.8f, new int[] { 2 });
        }

        public override void Update(float deltaTime)
        {

        }
    }
}
