using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Advanced2
{
    public class GlobalTestScene : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Stanrdard texture for all GameObjects
        Texture2D TestMikuTexture;

        //A collection GameObjects we will be using in this scene, and the list to hold them
        List<GameObject> GameObjects = new List<GameObject>();
        GameObject _gameObject1;
        GameObject _gameObject2;
        GameObject _gameObject3;
        GameObject _gameObject4;
        GameObject _gameObject5;
        GameObject _gameObject6;
        GameObject _gameObject7;
        GameObject _gameObject8;
        GameObject _gameObject9;

        //Scene Management ints
        int NoOfScenes = 4;
        int CurrentScene = 4;
        int AmountOfGameObjects = 9;

        bool SpacebarHeld = false;

        public GlobalTestScene()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // 2D Textures
            TestMikuTexture = Content.Load<Texture2D>("MikuLeek");

            //Add all _gameObjects to the GameObjects list
            GameObjects.Add(_gameObject1);
            GameObjects.Add(_gameObject2);
            GameObjects.Add(_gameObject3);
            GameObjects.Add(_gameObject4);
            GameObjects.Add(_gameObject5);
            GameObjects.Add(_gameObject6);
            GameObjects.Add(_gameObject7);
            GameObjects.Add(_gameObject8);
            GameObjects.Add(_gameObject9);

            //Create test objects using the GameObject list
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObjects[i] = new GameObject();
            }

            SceneSwitch();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Start == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Space))
            { SceneSwitch(); SpacebarHeld = true; }
            else if (SpacebarHeld == true)
            {
               SpacebarHeld = false;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin(SpriteSortMode.FrontToBack);
            // TODO: Add your drawing code here

            for (int i = 0; i < AmountOfGameObjects; i++)
            {
                GameObjects[i]._SpriteRenderer.Draw(GameObjects[i]._Transform, _spriteBatch, TestMikuTexture);
            }

            _spriteBatch.End();
            base.Draw(gameTime);
        }

        void SceneSwitch()
        {
            if (SpacebarHeld == false)
            {
                if (CurrentScene == NoOfScenes)
                {
                    CurrentScene = 0;
                }
                else
                {
                    CurrentScene += 1;
                }

                for (int i = 0; i < GameObjects.Count; i++)
                {
                    GameObjects[i]._Transform.ResetTransform();
                }

                Debug.WriteLine("Current: " + CurrentScene + " Total: " + NoOfScenes);
                switch (CurrentScene)  // Call the correct void that updates the GameObject Transforms
                {
                    case 0:
                        Test0();
                        break;
                    case 1:
                        Test1();
                        break;
                    case 2:
                        Test2();
                        break;
                    case 3:
                        Test3();
                        break;
                    case 4:
                        Test4();
                        break;
                    default:
                        break;
                }
            }
        }

        #region Voids that update GameObject Transforms during a scene switch
        void Test0() //LayerDepth
        {
            AmountOfGameObjects = 9;
            GameObjects[0]._Transform.Position = new Vector2(96, 96);
            GameObjects[1]._Transform.Position = new Vector2(96, (int)(96 * 1.5));
            GameObjects[2]._Transform.Position = new Vector2(96, 96 * 2);
            GameObjects[3]._Transform.Position = new Vector2(96 * 2, 96);
            GameObjects[4]._Transform.Position = new Vector2(96 * 2, (int)(96 * 1.5));
            GameObjects[5]._Transform.Position = new Vector2(96 * 2, 96 * 2);
            GameObjects[6]._Transform.Position = new Vector2(96 * 3, 96);
            GameObjects[7]._Transform.Position = new Vector2(96 * 3, (int)(96 * 1.5));
            GameObjects[8]._Transform.Position = new Vector2(96 * 3, 96 * 2);

            GameObjects[0]._Transform.LayerDepth = 0;
            GameObjects[1]._Transform.LayerDepth = 0.5f;
            GameObjects[2]._Transform.LayerDepth = 1;
            GameObjects[3]._Transform.LayerDepth = 0;
            GameObjects[4]._Transform.LayerDepth = 0.5f;
            GameObjects[5]._Transform.LayerDepth = 0;
            GameObjects[6]._Transform.LayerDepth = 1;
            GameObjects[7]._Transform.LayerDepth = 0.5f;
            GameObjects[8]._Transform.LayerDepth = 0;
        }
        void Test1() //Origin
        {
            AmountOfGameObjects = 4;
            GameObjects[0]._Transform.Position = new Vector2(96, (int)(96*1.5));
            GameObjects[1]._Transform.Position = new Vector2(96, (int)(96*1.5));
            GameObjects[2]._Transform.Position = new Vector2(96, (int)(96*1.5));
            GameObjects[3]._Transform.Position = new Vector2(96, (int)(96*1.5));

            GameObjects[0]._Transform.AnchorPoint = new Vector2(0, 0);
            GameObjects[1]._Transform.AnchorPoint = new Vector2(0, 1);
            GameObjects[2]._Transform.AnchorPoint = new Vector2(1, 0);
            GameObjects[3]._Transform.AnchorPoint = new Vector2(1, 1);
        }
        void Test2() //Position
        {
            AmountOfGameObjects = 5;
            GameObjects[0]._Transform.Position = new Vector2(50, 50  +46);
            GameObjects[1]._Transform.Position = new Vector2(250, 50 +46);
            GameObjects[2]._Transform.Position = new Vector2(150, 150+46);
            GameObjects[3]._Transform.Position = new Vector2(50, 250 +46);
            GameObjects[4]._Transform.Position = new Vector2(250, 250+46);
        }
        void Test3() //Rotate
        {
            AmountOfGameObjects = 5;
            GameObjects[0]._Transform.Position = new Vector2(96, 96);
            GameObjects[1]._Transform.Position = new Vector2(96 * 2, 96);
            GameObjects[2]._Transform.Position = new Vector2(96 * 3, 96);
            GameObjects[3]._Transform.Position = new Vector2(96 * 4, 96);
            GameObjects[4]._Transform.Position = new Vector2(96 * 5, 96);

            GameObjects[0]._Transform.Rotation = 0;
            GameObjects[1]._Transform.Rotation = 45;
            GameObjects[2]._Transform.Rotation = 90;
            GameObjects[3]._Transform.Rotation = 180;
            GameObjects[4]._Transform.Rotation = 360;
        }
        void Test4() //Scale
        {
            AmountOfGameObjects = 6;
            // GameObject transform positions
            GameObjects[0]._Transform.Position = new Vector2(0              , 0              +48);
            GameObjects[1]._Transform.Position = new Vector2(96 * 3         , 96 * 0         +48);
            GameObjects[2]._Transform.Position = new Vector2(96 * 3         , (int)(96 * 1.5)+48);
            GameObjects[3]._Transform.Position = new Vector2((int)(96 * 4.5), 96 * 0         +48);
            GameObjects[4]._Transform.Position = new Vector2((int)(96 * 4.5), 96 * 1         +48);
            GameObjects[5]._Transform.Position = new Vector2((int)(96 * 4.5), 96 * 2         +48);

            // GameObject Anchorpoints
            GameObjects[0]._Transform.AnchorPoint = new Vector2(0, 0);
            GameObjects[1]._Transform.AnchorPoint = new Vector2(0, 0);
            GameObjects[2]._Transform.AnchorPoint = new Vector2(0, 0);
            GameObjects[3]._Transform.AnchorPoint = new Vector2(0, 0);
            GameObjects[4]._Transform.AnchorPoint = new Vector2(0, 0);
            GameObjects[5]._Transform.AnchorPoint = new Vector2(0, 0);

            GameObjects[0]._Transform.Scale = new Vector2(3, 3);
            GameObjects[1]._Transform.Scale = new Vector2((float)(1.5), (float)(1.5));
            GameObjects[2]._Transform.Scale = new Vector2((float)(1.5), (float)(1.5));
            GameObjects[3]._Transform.Scale = new Vector2(1, 1);
            GameObjects[4]._Transform.Scale = new Vector2(1, 1);
            GameObjects[5]._Transform.Scale = new Vector2(1, 1);
        }
        #endregion
    }
}
