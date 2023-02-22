using Microsoft.Xna.Framework;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects;
using System.Drawing;

namespace StudentProject.Code.Screens
{
    public class MyWorld : Screen
    {
        public override void Start(Core core)
        {
            base.Start(core);

            // TODO: Add your Screen starting code below here
            Settings.BackgroundFill = Color.DarkRed;
            SetBackground("Hero");

            AddObject(new Hero(), 100, 200);

        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            // TODO: Add your Screen updated code below here

        }
    }
}
