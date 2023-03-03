using Microsoft.Xna.Framework;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects;
using System.Drawing;

namespace StudentProject.Code.Screens
{
    public class MyWorld : Screen
    {
        //TO-DO : 
        //Add classes for box, barrel and scaffolding

        Hero _player;
        Text _score;
        Box _newBox = new Box();

        Enemy enemy = new Enemy();

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

            //Adding new object of player
            _player = new Hero();
            AddObject(_player, 500, 800);


            //Adding Boxes
            AddObject(_newBox, 800, 920);

            //Adding new apple
            AddObject(new Apple(), 600, 800);

            //Adding Score to screen
            _score = new Text("Score: 0", Microsoft.Xna.Framework.Color.White);
            AddText(_score, 100, 100);

            AddObject(enemy, 500, 300);

            BuildGround();

        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            // TODO: Add your Screen updated code below here

            //Updating Score
            _score.SetMessage("Score: " + _player.GetScore());

        }

        private void BuildGround()
        {
            //Place each ground at the bottom of the screen
            int yPosition = (int)Settings.GameResolution.Y - 90;

            //This is the size of the game screen, minus 1 wall width (64px)
            int screenRightEdge = (int)Settings.GameResolution.X - 64;

            //The number of ground to place/ how many iterations of our loop to run. 
            int numberOfWalls = 30;

            //The number of pixels between each ground. Change this if you want some space between each wall.
            int gapBetweenWalls = 0;

            for (int column = 0; column < numberOfWalls; column++)
            {
                //The wall's sprite is 64px wide, so move each new wall by 64 before placing it in the world
                int xPosition = column * (64 + gapBetweenWalls);

                //Place a wall object coming in from the left
                AddObject(new Ground(), xPosition, yPosition);

                //Place a wall object coming in from the right
                //AddObject(new Ground(), screenRightEdge - xPosition, yPosition);
            }
        }
    }
}
