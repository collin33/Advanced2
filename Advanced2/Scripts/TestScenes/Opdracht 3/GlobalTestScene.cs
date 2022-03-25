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
        Texture2D TestMikuTexture;

        List<GameObject> GameObjects = new List<GameObject>();

        // GameObjects

        GameObject _gameObject1;
        GameObject _gameObject2;
        GameObject _gameObject3;
        GameObject _gameObject4;
        GameObject _gameObject5;
        GameObject _gameObject6;
        GameObject _gameObject7;
        GameObject _gameObject8;
        GameObject _gameObject9;

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

            GameObjects.Add(_gameObject1);
            GameObjects.Add(_gameObject2);
            GameObjects.Add(_gameObject3);
            GameObjects.Add(_gameObject4);
            GameObjects.Add(_gameObject5);
            GameObjects.Add(_gameObject6);
            GameObjects.Add(_gameObject7);
            GameObjects.Add(_gameObject8);
            GameObjects.Add(_gameObject9);

            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObjects[i] = new GameObject();
            }

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

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin(SpriteSortMode.FrontToBack);
            // TODO: Add your drawing code here
            _gameObject1._SpriteRenderer.Draw(_gameObject1._Transform, _spriteBatch, TestMikuTexture);
            _gameObject2._SpriteRenderer.Draw(_gameObject2._Transform, _spriteBatch, TestMikuTexture);
            _gameObject3._SpriteRenderer.Draw(_gameObject3._Transform, _spriteBatch, TestMikuTexture);
            _gameObject4._SpriteRenderer.Draw(_gameObject4._Transform, _spriteBatch, TestMikuTexture);
            _gameObject5._SpriteRenderer.Draw(_gameObject5._Transform, _spriteBatch, TestMikuTexture);
            _gameObject6._SpriteRenderer.Draw(_gameObject6._Transform, _spriteBatch, TestMikuTexture);
            _gameObject7._SpriteRenderer.Draw(_gameObject7._Transform, _spriteBatch, TestMikuTexture);
            _gameObject8._SpriteRenderer.Draw(_gameObject8._Transform, _spriteBatch, TestMikuTexture);
            _gameObject9._SpriteRenderer.Draw(_gameObject9._Transform, _spriteBatch, TestMikuTexture);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
        public void test()
        {
            //_gameObject1._Transform.Position = new Vector2(96, 96);
            //_gameObject2._Transform.Position = new Vector2(96, (int)(96 * 1.5));
            //_gameObject3._Transform.Position = new Vector2(96, 96 * 2);
            //_gameObject4._Transform.Position = new Vector2(96 * 2, 96);
            //_gameObject5._Transform.Position = new Vector2(96 * 2, (int)(96 * 1.5));
            //_gameObject6._Transform.Position = new Vector2(96 * 2, 96 * 2);
            //_gameObject7._Transform.Position = new Vector2(96 * 3, 96);
            //_gameObject8._Transform.Position = new Vector2(96 * 3, (int)(96 * 1.5));
            //_gameObject9._Transform.Position = new Vector2(96 * 3, 96 * 2);

            //_gameObject1._Transform.LayerDepth = 0;
            //_gameObject2._Transform.LayerDepth = 0.5f;
            //_gameObject3._Transform.LayerDepth = 1;
            //_gameObject4._Transform.LayerDepth = 0;
            //_gameObject5._Transform.LayerDepth = 0.5f;
            //_gameObject6._Transform.LayerDepth = 0;
            //_gameObject7._Transform.LayerDepth = 1;
            //_gameObject8._Transform.LayerDepth = 0.5f;
            //_gameObject9._Transform.LayerDepth = 0;
        }
    }
}
