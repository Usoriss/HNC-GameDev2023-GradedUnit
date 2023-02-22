using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameEngine;
using StudentProject.Code.Screens;

namespace StudentProject
{
    public class MyGame : Core
    { 
        protected override void Initialize()
        {
            Window.Title = "MyGame";
            // TODO: Add your game's initialization logic below here


            StartScreen<MyWorld>();
            base.Initialize();
        }
    }
}
