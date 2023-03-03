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
            //this follwing code will change the resolution of the game and the window, this allows me to see
            //when using this absoute tragedy of an aspect ratio. None should have to suffer this.
            /*
             changing the old Vector2 to a new value allows the change in resolution !!!!!!!REMEMBER THIS!!!!!!!
             */
            Settings.GameResolution = new Vector2(960f, 540f);
            Settings.ScreenDimensions = new Vector2(960f, 540f);
            Settings.BackgroundFill = Microsoft.Xna.Framework.Color.DarkRed;
            SetBackground("LevelOne");

            AddObject(new Hero(), 100, 200);

        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            // TODO: Add your Screen updated code below here

        }
    }
}
